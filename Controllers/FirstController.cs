using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hometask14.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        [HttpGet]
        public ActionResult SimpleOperations()
        {
            Models.Calculations calculations = new Models.Calculations() { NumberA = 2, Solution = '+', NumberB = 2 };
            return View(calculations);
        }

        [HttpGet]
        public ActionResult SolutionOfSimpleOperations()
        {
            Models.Calculations calculations = new Models.Calculations();
            calculations.NumberA = calculations.GetNumber(6, 10);
            calculations.NumberB = calculations.GetNumber(1, 4);
            calculations.GetTask();
            calculations.NumberC = calculations.GetNumber(1, 5);
            return View(calculations);
        }

        [HttpPost]
        public ActionResult SimpleOperations(Models.Calculations calculations)
        {
            if (calculations.Solution=='+')
            {
                calculations.NumberC = calculations.GetSum(calculations.NumberA, calculations.NumberB);
            }
            else if(calculations.Solution=='-')
            {
                calculations.NumberC = calculations.GetDiff(calculations.NumberA, calculations.NumberB);
            }
            else if(calculations.Solution=='/')
            {
                calculations.NumberC = calculations.GetDeg(calculations.NumberA, calculations.NumberB);
            }
            else if(calculations.Solution=='^')
            {
                calculations.NumberC = calculations.GetPower(calculations.NumberA, calculations.NumberB);
            }
            else
            {
                calculations.NumberC = calculations.GetMultiply(calculations.NumberA, calculations.NumberB);
            }
            return View(calculations);
        }

        [HttpPost]
        public ActionResult SolutionOfSimpleOperations(Models.Calculations calculations)
        {
            if(calculations.Solution == '+')
            {
                calculations.X2 = calculations.GetSum(calculations.NumberA, calculations.NumberC);
            }
            if (calculations.Solution == '-')
            {
                calculations.X2 = calculations.GetDiff(calculations.NumberA, calculations.NumberC);
            }
            if (calculations.Solution == '*')
            {
                calculations.X2 = calculations.GetMultiply(calculations.NumberA, calculations.NumberC);
            }
            if (calculations.Solution == '/')
            {
                calculations.X2 = calculations.GetDeg(calculations.NumberA, calculations.NumberC);
            }
            calculations.GetAnsver();
            calculations.NumberA = calculations.GetNumber(6, 10);
            calculations.NumberB = calculations.GetNumber(1, 4);
            calculations.GetTask();
            calculations.NumberC = calculations.GetNumber(1, 5);
            return View(calculations);
        }
    }
}