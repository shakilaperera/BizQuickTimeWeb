using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class Project
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Project ID")]
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        [Display(Name = "Invoicing Company ID")]
        public string InvoicingCompanyId { get; set; }
        [Display(Name = "Company ID")]
        public string CompanyId { get; set; }

    }
}
