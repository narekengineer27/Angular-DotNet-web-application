using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeTodoList.Core.Modules.Tasks.Abstractions;
using EmployeeTodoList.Data.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoTasksController : ControllerBase
    {
        private readonly IToDoTaskService _toDoTaskService;

        public ToDoTasksController(IToDoTaskService toDoTaskService)
        {
            _toDoTaskService = toDoTaskService;
        }

        // GET: api/ToDoTasks
        [HttpGet]
        public async Task<List<ToDoTask>> GetAllAsync()
        {
            return await _toDoTaskService.GetAllAsync();
        }

        // GET: api/ToDoTasks/5
        [HttpGet("{id}")]
        public async Task<ToDoTask> GetAsync(int id)
        {
            return await _toDoTaskService.GetByIdAsync(id);
        }

        // POST: api/ToDoTasks
        [HttpPost]
        public async Task Post([FromBody] ToDoTask model)
        {
            await _toDoTaskService.AddAsync(model);
        }

        // PUT: api/ToDoTasks
        [HttpPut("")]
        public async Task Put( [FromBody] ToDoTask model)
        {
            await _toDoTaskService.UpdateAsync(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            ToDoTask model = await _toDoTaskService.GetByIdAsync(id);
            await _toDoTaskService.DeleteAsync(model);
        }
    }
}
