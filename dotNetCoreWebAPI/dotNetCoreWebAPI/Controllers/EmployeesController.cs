using System.Collections.Generic;
using System.Linq;
using dotNetCore.Data;
using dotNetCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private EmployeeRepository repository = new EmployeeRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return repository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return repository.Get(id);
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee value)
        {
            return repository.Insert(value);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee value)
        {
            return repository.Update(value);
        }
    }
}
