using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        static readonly IEmployeeRespository respository = new EmployeeRepository();
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return respository.GetAll();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return respository.Get(id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public string Post(Employee employee)
        {
            Employee temp = new Employee();
            temp = employee;
            if (employee == null)
            {
                throw new Exception();
            }           
            employee = respository.Add(temp);
            return "Employee added Successfully!!";
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public string Put(int id, Employee employee)
        {
            //employee.Id = id;
            if (employee == null)
            {
                throw new Exception();
            }
            Employee temp = new Employee();
            temp = employee;
            respository.Update(temp);
            return "Updated Successfully !!";
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            respository.Remove(id);
            return "Deleted Successfully";
        }
    }
}
