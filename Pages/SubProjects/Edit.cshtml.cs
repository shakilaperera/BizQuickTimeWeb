using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BizQuickTime.Web.Model;
using BizQuickTime.Web.Models;

namespace BizQuickTime.Web.Pages.SubProjects
{
    public class EditModel : PageModel
    {
        private readonly BizQuickTime.Web.Models.BQTDataContext _context;

        public EditModel(BizQuickTime.Web.Models.BQTDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SubProject SubProject { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SubProject = await _context.SubProject.FirstOrDefaultAsync(m => m.ID == id);

            if (SubProject == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SubProject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubProjectExists(SubProject.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SubProjectExists(int id)
        {
            return _context.SubProject.Any(e => e.ID == id);
        }
    }
}
