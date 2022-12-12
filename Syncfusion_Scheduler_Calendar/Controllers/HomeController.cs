using Syncfusion_Scheduler_Calendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Syncfusion_Scheduler_Calendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Resources = new string[] { "Owners" };
            //ViewBag.DataSource = GetResourceData();
            return View();
        }

        public JsonResult GetOwnerResourceData()
        {
            return Json(new List<OwnerRes>
            {
                new OwnerRes { text = "Nancy", id = 1, color = "#ffaa00" },
                new OwnerRes { text = "Steven", id = 2, color = "#f8a398" },
                new OwnerRes { text = "Michael", id = 3, color = "#7499e1" },
            });
        }

        public JsonResult GetResourceData()
        {
            return Json(new List<ResourceData>
            {
                new ResourceData
                {
                    Id = 1,
                    Subject = "Workflow Analysis",
                    StartTime = new DateTime(2022, 12, 3, 10, 0, 0),
                    EndTime = new DateTime(2022, 12, 3, 13, 0, 0),
                    IsAllDay = false,
                    OwnerId = 1
                },
                new ResourceData
                {
                    Id = 2,
                    Subject = "Requirement planning",
                    StartTime = new DateTime(2022, 12, 4, 10, 0, 0),
                    EndTime = new DateTime(2022, 12, 4, 13, 0, 0),
                    IsAllDay = false,
                    OwnerId = 2
                },
                new ResourceData
                {
                    Id = 3,
                    Subject = "Quality Analysis",
                    StartTime = new DateTime(2022, 12, 5, 10, 0, 0),
                    EndTime = new DateTime(2022, 12, 5, 13, 0, 0),
                    IsAllDay = false,
                    OwnerId = 3
                }
            });
        }
    }
}