using System;
using System.Collections.Generic;
using System.Text;
using EmployeeTodoList.Data.Domains.Enums;

namespace EmployeeTodoList.Data.Domains
{
    public class ToDoTask:BaseEntity
    {
        public int ToDoTaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PriorityLevel PriorityLevel { get; set; }
        public State State { get; set; }
        public double Estimate { get; set; }
    }
}
