using Microsoft.EntityFrameworkCore;
using PRN211_Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Demo2.Manager
{
    internal class EmployeeManager
    {
        public List<Employee> GetEmployees()
        {
            using (var context = new PE_Fall21B5Context())
            {
                return context.Employees
                    .Include(x => x.DepartmentNavigation).ToList();
            }
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            using (var context = new PE_Fall21B5Context())
            {
                return context.Employees
                    .Include(x => x.DepartmentNavigation)
                    .Where(x => x.Name.Contains(name))
                    .ToList();
            }
        }

        public Employee GetEmployeesById(int position)
        {
            using (var context = new PE_Fall21B5Context())
            {
                return context.Employees
                    .Where(x => x.Id == position).FirstOrDefault();
            }
        }

        public List<Employee> GetEmployeesByPosition(string position)
        {
            using (var context = new PE_Fall21B5Context())
            {
                return context.Employees
                    .Include(x => x.DepartmentNavigation)
                    .Where(x => x.Position.Equals(position))
                    .ToList();
            }
        }

        public List<Employee> GetEmployeesBySex(string sex)
        {
            using (var context = new PE_Fall21B5Context())
            {
                return context.Employees
                    .Include(x => x.DepartmentNavigation)
                    .Where(x => x.Sex.Equals(sex))
                    .ToList();
            }
        }
    }
}
