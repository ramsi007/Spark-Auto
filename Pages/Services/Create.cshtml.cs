using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Models;
using SparkAuto.Models.ViewModels;

namespace SparkAuto.Pages.Services
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public CreateModel(ApplicationDbContext _db)
        {
            this.db = _db;
        }
        [BindProperty]
        public CarServiceViewModel CarServiceVM { get; set;}

        public IActionResult OnGet(int carId)
        {
            CarServiceVM = new CarServiceViewModel()
            {
                Car = db.Cars.Include(m => m.ApplicationUser).Where(m => m.Id == carId).FirstOrDefault(),
                Service = new Service()
            };

            List<string> ListServiceTypeInShoopingCart = db.ServiceShoopingCarts
                .Include(m => m.ServiceType).Where(m => m.CarId == carId)
                .Select(m => m.ServiceType.Name).ToList();

            IQueryable<ServiceType> ListServiceType = from s in db.ServiceTypes
                                                      where !(ListServiceTypeInShoopingCart.Contains(s.Name))
                                                      select s;

            CarServiceVM.ServiceTypes = ListServiceType.ToList();

            CarServiceVM.ServiceShoopingCarts = db.ServiceShoopingCarts.Include(m => m.ServiceType)
                .Where(m => m.CarId == carId).ToList();

            foreach (var item in CarServiceVM.ServiceShoopingCarts)
            {
                CarServiceVM.Service.TotalPrice += item.ServiceType.Price;
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAddToCart()
        {
            ServiceShoopingCart serviceShoopingCart = new ServiceShoopingCart()
            {
                CarId = CarServiceVM.Car.Id,
                ServiceTypeId = CarServiceVM.ServiceDetails.ServiceTypeId
            };
            await db.ServiceShoopingCarts.AddAsync(serviceShoopingCart);
            await db.SaveChangesAsync();
            return RedirectToPage("Create", new { carId = CarServiceVM.Car.Id }); 
        }

        public async Task<IActionResult> OnPostRemoveFromCart(int serviceCartId)
        {
            ServiceShoopingCart serviceShoopingCart = await db.ServiceShoopingCarts.FindAsync(serviceCartId);
            db.ServiceShoopingCarts.Remove(serviceShoopingCart);
            await db.SaveChangesAsync();
            return RedirectToPage("Create", new { carId = CarServiceVM.Car.Id });
        }


        public async Task<IActionResult> OnPost()
        {
            CarServiceVM.Service.DateAdded = DateTime.Now;
            CarServiceVM.Service.CarId = CarServiceVM.Car.Id;

            CarServiceVM.ServiceShoopingCarts = db.ServiceShoopingCarts.Include(m => m.ServiceType)
                .Where(m => m.CarId == CarServiceVM.Car.Id).ToList();

            foreach (var item in CarServiceVM.ServiceShoopingCarts)
            {
                CarServiceVM.Service.TotalPrice += item.ServiceType.Price;
            }

            await db.Services.AddAsync(CarServiceVM.Service);
            await db.SaveChangesAsync();

            foreach (var item in CarServiceVM.ServiceShoopingCarts)
            {
                ServiceDetails serviceDetails = new ServiceDetails()
                {
                    ServiceId = CarServiceVM.Service.Id,
                    SerivceName = item.ServiceType.Name,
                    SerivcePrice = item.ServiceType.Price,
                    ServiceTypeId = item.ServiceTypeId
                };

                db.ServiceDetails.Add(serviceDetails);
            }

                db.ServiceShoopingCarts.RemoveRange(CarServiceVM.ServiceShoopingCarts);
                await db.SaveChangesAsync();

            return RedirectToPage("../Cars/Index", new { userId = CarServiceVM.Car.UserId });
        }
    }
}
