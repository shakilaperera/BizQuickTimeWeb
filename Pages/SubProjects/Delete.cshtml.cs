using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BizQuickTime.Web.Model;
using BizQuickTime.Web.Models;

namespace BizQuickTime.Web.Pages.SubProjects
{
    public class DeleteModel : PageModel
    {
        private readonly BizQuickTime.Web.Models.BQTDataContext _context;

        public DeleteModel(BizQuickTime.Web.Models.BQTDataContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SubProject = await _context.SubProject.FindAsync(id);

            if (SubProject != null)
            {
                _context.SubProject.Remove(SubProject);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
