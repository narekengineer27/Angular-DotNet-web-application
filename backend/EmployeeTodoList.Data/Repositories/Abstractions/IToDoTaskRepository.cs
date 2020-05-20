using System;
using System.Collections.Generic;
using System.Text;
using EmployeeTodoList.Data.Domains;

namespace EmployeeTodoList.Data.Repositories.Abstractions
{
    public interface IToDoTaskRepository: IGenericRepository<ToDoTask>
    {
    }
}
