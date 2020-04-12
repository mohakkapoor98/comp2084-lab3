using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var PhoneNew = new List<Phone>
              {
                  new Phone {PhoneName = "Iphone 11 Pro Max", ScreenSize = 155, Manufacturer = "Apple" , DateReleased = new DateTime(2019,10,1), MSRP = 2000 },
                  new Phone {PhoneName = "F9", ScreenSize = 175, Manufacturer = "Oppo" , DateReleased = new DateTime(2018,5,1), MSRP = 1000 },
                  new Phone {PhoneName = "Smartpad", ScreenSize = 100, Manufacturer = "Nokia" , DateReleased = new DateTime(2016,4,7), MSRP = 2000 },
              };
            return View(PhoneNew);
        }
    }
}