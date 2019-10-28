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
    public class IndexModel : PageModel
    {
        private readonly BizQuickTime.Web.Models.BQTDataContext _context;

        public IndexModel(BizQuickTime.Web.Models.BQTDataContext context)
        {
            _context = context;
        }

        public IList<SubProject> SubProject { get;set; }

        public async Task OnGetAsync()
        {
            SubProject = await _context.SubProject.ToListAsync();
        }
    }
}
