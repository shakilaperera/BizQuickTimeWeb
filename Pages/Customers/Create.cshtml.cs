using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BizQuickTime.Web.Model;
using BizQuickTime.Web.Models;

namespace BizQuickTime.Web.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly BizQuickTime.Web.Models.BQTDataContext _context;

        public CreateModel(BizQuickTime.Web.Models.BQTDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}