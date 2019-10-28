using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class Activity
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(15)]
        [Display(Name = "Activity ID")]
        public string ActivityId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Activity Name")]
        public string ActivityName { get; set; }
        [Required]
        [MaxLength(5)]
        [Display(Name = "Calc Type 1")]
        public string CalcType1 { get; set; }
        [Display(Name = "Calc Type 2")]
        public string CalcType2 { get; set; }
        [Display(Name = "Calc Type 3")]
        public string CalcType3 { get; set; }
        [Display(Name = "Estimation Qty")]
        public int EstimationQty { get; set; }
        [MaxLength(10)]
        [Display(Name = "Estimation Unit")]
        public string EstimationUnit { get; set; }
        [Display(Name = "Estimated Value")]
        public decimal EstimatedValue { get; set; }
        [Display(Name = "Capped Value")]
        public decimal CappedValue { get; set; }
        [Display(Name = "Purchase Order")]
        public string PurchaseOrder { get; set; }
        [Display(Name = "Purchase Order Qty")]
        public int PurchaseOrderQty { get; set; }
        [Display(Name = "PO Gross Amount")]
        public decimal POGrossAmount { get; set; }
        [MaxLength(50)]
        [Display(Name = "Short ID")]
        public string ShortId { get; set; }


    }
}
