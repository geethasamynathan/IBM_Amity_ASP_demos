using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmptyMVCDemo1.Models;

namespace EmptyMVCDemo1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["eid"] = 101;
            ViewData["ename"] = "Geetha";

            ViewBag.eid = 102;
            ViewBag.ename = "Fransy";

            EmployeeBusinessLayer employee = new EmployeeBusinessLayer();
            Employee emp = employee.GetEmployeeDetails();
            ViewData["emp1"] = emp;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}