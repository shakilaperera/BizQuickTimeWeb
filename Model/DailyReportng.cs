using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BizQuickTime.Web.Model
{
    public class DailyReportng
    {
        public int ID { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public string ProjectId { get; set; }
        public string SubProject { get; set; }
        public string ACtivityId { get; set; }
        public string WorkDescription { get; set; }
        public decimal Hours { get; set; }

    }
}
