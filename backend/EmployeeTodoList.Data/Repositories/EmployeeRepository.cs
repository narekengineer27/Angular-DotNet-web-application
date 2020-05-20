using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTodoList.Data.Context;
using EmployeeTodoList.Data.Domains;
using EmployeeTodoList.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTodoList.Data.Repositories
{
    internal class EmployeeRepository: GenericRepository<EmployeeTodoListContext, Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeTodoListContext context) : base(context)
        {
        }

        public override async Task<List<Employee>> GetAllAsync()
        {
            return await Items.Include(x => x.ToDoTasks).OrderBy(x => x.Name).ToListAsync();
        }

        public override async Task<Employee> GetByIdAsync(int id)
        {
            return await Items.Include(x => x.ToDoTasks).FirstOrDefaultAsync(x => x.EmployeeId == id);
        }
    }
}
