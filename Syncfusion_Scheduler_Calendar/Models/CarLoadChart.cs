using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Syncfusion_Scheduler_Calendar.Models
{
    public class CarLoadChart
    {
        public long Id { get; set; }
        public int CarId { get; set; }
        public string CostCenter { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Color { get; set; } = "#00f";
        public string MyGuid { get; set; }
        public bool IsAllDay { get; set; } = true;
    }
}