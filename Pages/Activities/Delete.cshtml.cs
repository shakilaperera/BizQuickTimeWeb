using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BizQuickTime.Web.Model;
using BizQuickTime.Web.Models;

namespace BizQuickTime.Web.Pages.Activities
{
    public class DeleteModel : PageModel
    {
        private readonly BizQuickTime.Web.Models.BQTDataContext _context;

        public DeleteModel(BizQuickTime.Web.Models.BQTDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Activity Activity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Activity = await _context.Activity.FirstOrDefaultAsync(m => m.ID == id);

            if (Activity == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Activity = await _context.Activity.FindAsync(id);

            if (Activity != null)
            {
                _context.Activity.Remove(Activity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
