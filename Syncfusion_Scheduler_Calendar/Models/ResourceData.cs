using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Syncfusion_Scheduler_Calendar.Models
{
    public class ResourceData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAllDay { get; set; }
        public int OwnerId { get; set; }
    }
}