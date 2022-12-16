using Microsoft.AspNetCore.Mvc;
using PracticeWebApp12_12.Logics;
using PracticeWebApp12_12.Models;
using System.Linq;

namespace PracticeWebApp12_12.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List(int empId, DateTime birthYear, string country, int reportedTo)
        {
            Manager manager = new Manager();
            //int reP = Convert.ToInt32(reportedTo);
            List<Employee> employees = manager.GetEmployees(empId, birthYear, country, reportedTo);
            List<Employee> allE = manager.getAllList();
            List<string> c1 = new List<string>();
            
            foreach(Employee e in allE)
            {
                if (!c1.Contains(e.Country))
                {
                    c1.Add(e.Country);
                }

            }
            List<int> r1 = new List<int>();
            foreach(Employee e in allE)
            {

                if (!r1.Contains(Convert.ToInt32(e.ReportsTo)))
                {
                    r1.Add(Convert.ToInt32(e.ReportsTo));
                }
            }

            ViewBag.listCo = c1;
            ViewBag.listRe = r1;
            ViewBag.Eplo = employees;
            ViewBag.CurEmployees = empId;
            ViewBag.CurReportedTo = reportedTo;
            ViewBag.CurCountry = country;
            ViewBag.CurBirthYear = birthYear.ToString("yyyy");

            return View(employees);
        }

        public ActionResult Delete(int empId)
        {
            Manager manager = new Manager();
            manager.DeleteEmployee(empId);
            return RedirectToAction("List");
        }
    }
}
