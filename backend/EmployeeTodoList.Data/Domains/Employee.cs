using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTodoList.Data.Domains
{
    public class Employee:BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public List<ToDoTask> ToDoTasks { get; set; }
    }
}
