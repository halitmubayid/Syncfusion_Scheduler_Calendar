using Syncfusion.EJ2.Schedule;
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
            ViewBag.Resources = new string[] { "Cars" };
            ViewBag.Cars = getCars();
            ViewBag.DataSource = getCarLoadCharts();
            ViewBag.DataSource = getCarLoadCharts();
            ViewBag.V_CostCenter = new SelectList(getCostCenters().Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
            }), "Id", "Name");

            DateTime StartDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            DateTime EndDateTime = new DateTime(StartDateTime.Year, StartDateTime.Month, StartDateTime.AddMonths(1).AddDays(-1).Day);

            return View();
        }

        [HttpPost]
        public ActionResult LoadChartSave(CarLoadChart carLoadChart)
        {
            return Json(carLoadChart);
        }

        public ActionResult Delete()
        {
            ViewBag.datasource = GetScheduleData();
            
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.WorkWeek }
            };

            ViewBag.view = viewOption;

            return View();
        }

        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Meeting",
                StartTime = new DateTime(2023, 2, 15, 10, 0, 0),
                EndTime = new DateTime(2023, 2, 15, 12, 30, 0),
                IsAllDay = false,
            });
            return appData;
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public bool IsAllDay { get; set; }
        }

        private List<Car> getCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Id = 101,
                    Name = "c101"
                },
                new Car
                {
                    Id = 102,
                    Name = "c102"
                },
                new Car
                {
                    Id = 103,
                    Name = "c103"
                },
                new Car
                {
                    Id = 104,
                    Name = "c104"
                },
                new Car
                {
                    Id = 105,
                    Name = "c105"
                }
            };
        }

        private List<CarLoadChart> getCarLoadCharts()
        {
            return new List<CarLoadChart>
            {
                new CarLoadChart
                {
                    Id = 201,
                    CarId = 101,
                    CostCenter = "c101",
                    Subject = "sc101",
                    StartTime = new DateTime(2023, 3, 1, 0, 0, 0),
                    EndTime = new DateTime(2023, 3, 1, 0, 0, 0),
                    MyGuid = Guid.NewGuid().ToString(),
                },
                new CarLoadChart
                {
                    Id = 202,
                    CarId = 102,
                    CostCenter = "c102",
                    Subject = "sc102",
                    StartTime = new DateTime(2023, 3, 2, 0, 0, 0),
                    EndTime = new DateTime(2023, 3, 2, 0, 0, 0),
                    MyGuid = Guid.NewGuid().ToString(),
                },
                new CarLoadChart
                {
                    Id = 203,
                    CarId = 103,
                    CostCenter = "c103",
                    Subject = "sc103",
                    StartTime = new DateTime(2023, 3, 3, 0, 0, 0),
                    EndTime = new DateTime(2023, 3, 3, 0, 0, 0),
                    MyGuid = Guid.NewGuid().ToString(),
                },
                new CarLoadChart
                {
                    Id = 204,
                    CarId = 104,
                    CostCenter = "c104",
                    Subject = "sc104",
                    StartTime = new DateTime(2023, 3, 4, 0, 0, 0),
                    EndTime = new DateTime(2023, 3, 4, 0, 0, 0),
                    MyGuid = Guid.NewGuid().ToString(),
                },
                new CarLoadChart
                {
                    Id = 205,
                    CarId = 105,
                    CostCenter = "c105",
                    Subject = "sc105",
                    StartTime = new DateTime(2023, 3, 5, 0, 0, 0),
                    EndTime = new DateTime(2023, 3, 5, 0, 0, 0),
                    MyGuid = Guid.NewGuid().ToString(),
                }
            };
        }

        private List<CostCenter> getCostCenters()
        {
            return new List<CostCenter>
            {
                new CostCenter
                {
                    Id = 301,
                    Name = "CC-1"
                },
                new CostCenter
                {
                    Id = 302,
                    Name = "CC-2"
                },
                new CostCenter
                {
                    Id = 303,
                    Name = "CC-3"
                },
                new CostCenter
                {
                    Id = 304,
                    Name = "CC-4"
                },
                new CostCenter
                {
                    Id = 305,
                    Name = "CC-5"
                }
            };
        }

    }
}