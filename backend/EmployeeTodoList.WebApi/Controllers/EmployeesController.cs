using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeTodoList.Core.Modules.Employees.Abstractions;
using EmployeeTodoList.Data.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: api/Employees
        [HttpGet]
        public async Task<List<Employee>> GetAllAsync()
        {
            return  await _employeeService.GetAllAsync();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<Employee> GetAsync(int id)
        {
            return  await _employeeService.GetByIdAsync(id);
        }

        // POST: api/Employees
        [HttpPost]
        public async Task PostAsync([FromBody] Employee model)
        {
            await _employeeService.AddAsync(model);
        }

        // PUT: api/Employees/
        [HttpPut()]
        public async Task PutAsync([FromBody] Employee model)
        {
            await _employeeService.UpdateAsync(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            Employee model = await _employeeService.GetByIdAsync(id);
            await _employeeService.DeleteAsync(model);
        }
    }
}
