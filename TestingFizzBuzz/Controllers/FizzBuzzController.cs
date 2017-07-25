using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingFizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index(int value)
        {
            for(int i = 1; i <=value; i++)
            {
                if (i % 15 == 0)
                    ViewBag.Output += "FizzBuzz";
                else if (i % 3 == 0)
                    ViewBag.Output += "Fizz";
                else if(i % 5 == 0)
                    ViewBag.Output += "Buzz";
                else
                ViewBag.Output += i.ToString();
            }

            return View();
        }
    }
}