using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BizQuickTime.Web.Model;
using BizQuickTime.Web.Models;

namespace BizQuickTime.Web.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly BizQuickTime.Web.Models.BQTDataContext _context;

        public DetailsModel(BizQuickTime.Web.Models.BQTDataContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
