using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public interface IEmployeeRespository
    {
        IEnumerable<Employee> GetAll();

        Employee Get(int id);

        Employee Add(Employee employee);

        void Remove(int id);

        bool Update(Employee employee);
    }
}
