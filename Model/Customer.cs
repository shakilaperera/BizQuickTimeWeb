using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class Customer
    {  
        public int ID { get; set; }
        [Required]
        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Phone]
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }
        [Display(Name = "Vat Number")]
        public string VatNumber { get; set; }
    }
}
