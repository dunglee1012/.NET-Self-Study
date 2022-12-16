using PracticeWebApp12_12.Models;

namespace PracticeWebApp12_12.Logics
{
    public class Manager
    {
        NorthwindContext context = new NorthwindContext();
        public List<Employee> getAllList()
        {
            return context.Employees.ToList();
        }
        public List<Employee> GetEmployees(int empId, DateTime birthYear, string country, int reportedTo)
        {
            List<Employee> employees = context.Employees
                .Where(x => x.BirthDate != null)
                .ToList();
            if (empId != 0)
                employees = employees.Where(x => x.EmployeeId == empId).ToList();
            if (country != null)
                employees = employees.Where(x => x.Country.Equals(country)).ToList();
            if (reportedTo != 0)
                employees = employees.Where(x => x.ReportsTo == reportedTo).ToList();
            return employees;
        }

        public void DeleteEmployee(int empId)
        {
            Employee e = context.Employees.FirstOrDefault(x => x.EmployeeId == empId);
            if (e != null)
            {
                List<Employee> emp = context.Employees.Where(x => x.EmployeeId == empId).ToList();
                context.Employees.RemoveRange(emp);
                context.Employees.Remove(e);
                context.SaveChanges();
            }
        }
    }


}
