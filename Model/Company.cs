using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class Company
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Company ID")]
        public int CompanyID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Currency { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Vat Number")]
        public string VatNumber { get; set; }
        [Display(Name = "Vat Percentage")]
        public int VatPercentage { get; set; }
        [Display(Name = "Company Registration No")]
        public string CompanyRegNo { get; set; }
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNo { get; set; }
        [EmailAddress]
        
        public string Email { get; set; }
        [Display(Name = "Company Logo")]
        public Byte[] CompanyLogo { get; set; }

    }
}
