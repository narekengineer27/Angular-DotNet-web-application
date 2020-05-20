using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeTodoList.Data.Domains;
using Task = System.Threading.Tasks.Task;

namespace EmployeeTodoList.Core.Modules.Employees.Abstractions
{
    public interface IEmployeeService
    {
        Task AddAsync(Employee model);
        Task UpdateAsync(Employee model);
        Task DeleteAsync(Employee model);
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
    }
}
