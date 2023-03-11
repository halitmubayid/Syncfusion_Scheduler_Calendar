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
            ViewBag.Cars = getCarDTOs();
            ViewBag.DataSource = getCarLoadChartDTOs();

            DateTime StartDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            DateTime EndDateTime = new DateTime(StartDateTime.Year, StartDateTime.Month, StartDateTime.AddMonths(1).AddDays(-1).Day);

            return View();
        }

        private List<Car> getCarDTOs()
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

        private List<CarLoadChart> getCarLoadChartDTOs()
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

    }
}