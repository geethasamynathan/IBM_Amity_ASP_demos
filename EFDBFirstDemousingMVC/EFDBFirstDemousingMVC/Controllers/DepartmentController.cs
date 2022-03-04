using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirstDemousingMVC.Models;

namespace EFDBFirstDemousingMVC.Controllers
{
    public class DepartmentController : Controller
    {
        EF_DB_First_DemoEntities entities = new EF_DB_First_DemoEntities();
        // GET: Department
        public ActionResult Index()
        {
            return View(entities.Departments.ToList());
        }
    }
}