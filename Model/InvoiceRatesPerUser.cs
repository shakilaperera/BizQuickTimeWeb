using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class InvoiceRatesPerUser
    {
        [Key]
        public string UserID { get; set; }
        
        public bool Expenses { get; set; }
        [Display(Name = "Daily Rate")]
        public decimal DailyRate { get; set; }
        [Display(Name = "Hourly Rate")]
        public decimal HourlyRate { get; set; }
    }
}
