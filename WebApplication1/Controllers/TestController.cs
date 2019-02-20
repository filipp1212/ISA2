using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Labor1.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello world";
        }

        public ActionResult GetView()
        {
            return View("MyView");
        }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }
    }
}