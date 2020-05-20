using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using EmployeeTodoList.Data.Domains;


namespace EmployeeTodoList.Core.Modules.Tasks.Abstractions
{
    public interface IToDoTaskService
    {
        Task AddAsync(ToDoTask model);
        Task UpdateAsync(ToDoTask model);
        Task DeleteAsync(ToDoTask model);
        Task<List<ToDoTask>> GetAllAsync();
        Task<ToDoTask> GetByIdAsync(int id);
    }
}
