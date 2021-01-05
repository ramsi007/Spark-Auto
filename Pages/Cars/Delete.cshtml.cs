using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SparkAuto.Data;
using SparkAuto.Models;

namespace SparkAuto.Pages.Cars
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public DeleteModel(ApplicationDbContext _db)
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
                db.Cars.Remove(carObj);
                await db.SaveChangesAsync();
                StatusMessage = "Car supprimé avec succeés";
                return RedirectToPage("Index", new { userId = Car.UserId });
            }

            return Page();
        }
    }
}
