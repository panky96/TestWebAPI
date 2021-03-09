using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class EmployeeRepository : IEmployeeRespository
    {
        private List<Employee> employees = new List<Employee>();
        private int next_id = 1;
        public EmployeeRepository()
        {
            employees.Add(new Employee() { Id = next_id++, EmployeeName = "Pankaj", EmployeeDepartment = "Development", Location = "Banglore" });
            employees.Add(new Employee() { Id = next_id++, EmployeeName = "Paarth", EmployeeDepartment = "Testing", Location = "Nashik" });
            employees.Add(new Employee() {Id = next_id++,EmployeeName= "Anu",EmployeeDepartment="HR",Location="Pune"  });
        }
        public Employee Add(Employee employee)
        {
            if (employee == null)
            {
                throw new NotImplementedException();
            }
                     
            employees.Add(employee);
            return employee;
        }

        public Employee Get(int id)
        {
            return employees.Find(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public void Remove(int id)
        {
            employees.RemoveAll(e => e.Id == id);
        }

        public bool Update(Employee employee)
        {

            if (employee == null)
            {
                throw new NotImplementedException();
            }
            int index = employees.FindIndex(e => e.Id == employee.Id);
            if (index == -1)
            {
                return false;
            }
            employees.RemoveAt(index);
            employees.Add(employee);
            return true;
        }
    }
}
