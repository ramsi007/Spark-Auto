using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Models.ViewModels;

namespace SparkAuto.Pages.Cars
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public IndexModel(ApplicationDbContext _db)
        {
            this.db = _db;
        }

        public CustomerAndCarViewModel CustomerAndCarVM { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet(string UserId = null)
        {
            if (UserId == null)
            {
                var claimIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
                UserId = claim.Value;
            }

            CustomerAndCarVM = new CustomerAndCarViewModel
            {
                UserObj = db.ApplicationUsers.Find(UserId),
                Cars = await db.Cars.Where(m => m.UserId == UserId).ToListAsync()
            };

            return Page();
        }

    }
}


