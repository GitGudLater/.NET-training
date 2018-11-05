using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hometask14.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        [HttpGet]
        public ActionResult Polynoms()
        {
            Models.Calculations calculations = new Models.Calculations() { NumberA = 1, NumberB = 2, NumberC = 1 };
            return View(calculations);
        }

        [HttpGet]

        public ActionResult SolutionOfPolynom()
        {
            Models.Calculations calculations = new Models.Calculations() { NumberA = 1, NumberB = 2, NumberC = 1 ,X1 = 2};
            return View(calculations);
        }

        [HttpPost]
        public ActionResult Polynoms(Models.Calculations calculations)
        {
            calculations.GetX(calculations.NumberA, calculations.NumberB, calculations.NumberC);
            return View(calculations);
        }

        [HttpPost]

        public ActionResult SolutionOfPolynom(Models.Calculations calculations)
        {
            calculations.GetPolynomSolution();
            return View(calculations);
        }
    }
}