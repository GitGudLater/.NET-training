using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hometask14.Controllers
{
    public class ThirdController : Controller
    {
        // GET: Third
        [HttpPost]
        public ActionResult CheckYourLuck()
        {
            Models.Calculations calculations = new Models.Calculations();
            return View(calculations);
        }
        [HttpGet]
        public ActionResult CheckYourLuck(Models.Calculations calculations)
        {
            if(calculations.X1==1)
            {
                calculations.NumberA = calculations.GetNumber(0, 7);
                calculations.NumberB = calculations.GetNumber(0, 7);
                calculations.NumberC = calculations.GetNumber(0, 7);
            }
            else
            {
                calculations.X2 = calculations.GetNumber(1, 6);
            }
            return View(calculations);
        }
    }
}