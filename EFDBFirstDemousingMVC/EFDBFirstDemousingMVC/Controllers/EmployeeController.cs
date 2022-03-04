using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirstDemousingMVC.Models;
namespace EFDBFirstDemousingMVC.Controllers
{
    public class EmployeeController : Controller
    {
        EF_DB_First_DemoEntities entities = new EF_DB_First_DemoEntities();
        // GET: Employee
        public ActionResult Index()
        {
            entities.Employees.ToList();
            return View(entities.Employees.ToList());
        }
        public ActionResult GetAllEmployee()
        {
            entities.Employees.ToList();
            return View(entities.Employees.ToList());
          
        }
        public ActionResult Details(int id)
        {
            Employee employee = entities.Employees.FirstOrDefault(e => e.Empid == id);
            return View(employee);

        }
        public ActionResult EmployeeByDepartment(int departmentid)
        {
            List<Employee> Employees = entities.Employees
                .Where(emp => emp.DepartmentId == departmentid).ToList();
            return View(Employees);

        }
    }
}