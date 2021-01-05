using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Models;

namespace SparkAuto.Pages.Services
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public DetailsModel(ApplicationDbContext _db)
        {
            this.db = _db;
        }

        public Service Service { get; set; }
        public List<ServiceDetails> ServiceDetails { get; set; }

        public void OnGet(int serviceId)
        {
            Service = db.Services.Include(m => m.Car).Include(m => m.Car.ApplicationUser)
                      .Where(m => m.Id == serviceId).FirstOrDefault();

            ServiceDetails = db.ServiceDetails.Where(m => m.ServiceId == serviceId).ToList();
        }
    }
}
