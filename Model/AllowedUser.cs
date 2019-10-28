using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class AllowedUser
    {
        public string UserID { get; set; }
        public string SubProjectID { get; set; }
        public bool Expenses { get; set; }
        public ApplicationUser User { get; set; }
        public SubProject SubProject { get; set; }

    }
}
