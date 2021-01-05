using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SparkAuto.Data;
using SparkAuto.Models;

namespace SparkAuto.Pages.Cars
{        
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public EditModel(ApplicationDbContext _db)
        {
            this.db = _db;
        }

        [BindProperty]
        public Car Car { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            Car = await db.Cars.FindAsync(id);
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var carObj = await db.Cars.FindAsync(Car.Id);

                carObj.VIN = Car.VIN;
                carObj.Make = Car.Make;
                carObj.Model = Car.Model;
                carObj.Style = Car.Style;
                carObj.Miles = Car.Miles;
                carObj.Color = Car.Color;


                await db.SaveChangesAsync();
                StatusMessage = "Car Modifié avec succeés";
                return RedirectToPage("Index", new { userId = Car.UserId });
            }

            return Page();
        }
    }
}

