using System.Collections.Generic;
using System.Linq;
using dotNetCore.Data;
using dotNetCore.Entity;
using Microsoft.AspNetCore.Mvc;

namespace dotnetCore.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        EmployeeRepository repository = new EmployeeRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return repository.GetEmployees(null).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return repository.GetEmployees(id).FirstOrDefault();
        }
    }
}
