using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class ApplicationUser:IdentityUser
    {   [MaxLength(5)]
        [Required]
        public string Currency { get; set; }
        public string CompanyID { get; set; }
        public ICollection<AllowedUser> AllowedSubProjects { get; set; }
        public ICollection<InvoiceRatesPerUser> InvoiceRates { get; set; }
        public Company Company { get; set; }


    }
}
