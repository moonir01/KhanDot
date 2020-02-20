     using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demoMdl.Models;

namespace demoMdl.Controllers
{
    public class Employee1Controller : Controller
    {
        // GET: Employee1
        public ActionResult Index()
        {
            var date = getempdetails();
            return View(date);
        }

        private emp getempdetails()
        {
            return new emp
            {
                empid = 100,
                empname = "Md.Monirozzaman Khan",
                empdesignation = "Manager",
                empage = "35",
                empsalary=3500


            };
        }
    }
}