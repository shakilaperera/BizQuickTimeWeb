using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class SubProject
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(15)]
        [Display(Name = "Sub Project ID")]
        public string SubProjectID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(5)]
        [Display(Name = "Calc Type 1")]
        public string CalcType1 { get; set; }
        [Required]
        [MaxLength(5)]
        [Display(Name = "Calc Type 2")]
        public string CalcType2 { get; set; }
        [Required]
        [MaxLength(5)]
        [Display(Name = "Calc Type 3")]
        public string CalcType3 { get; set; }
    }
}
