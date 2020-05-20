using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeTodoList.Data.Context;
using EmployeeTodoList.Data.Domains;
using EmployeeTodoList.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTodoList.Data.Repositories
{
    internal class ToDoTaskRepository: GenericRepository<EmployeeTodoListContext, ToDoTask>, IToDoTaskRepository
    {
        public ToDoTaskRepository(EmployeeTodoListContext context) : base(context)
        {
        }

        public override async Task<List<ToDoTask>> GetAllAsync()
        {
            return await Items.ToListAsync();
        }
    }
}
