using System;
using System.Collections.Generic;
using System.Text;
using EmployeeTodoList.Data.Domains;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTodoList.Data.Context
{
    public class EmployeeTodoListContext : DbContext
    {
        public EmployeeTodoListContext(DbContextOptions<EmployeeTodoListContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasMany(x => x.ToDoTasks);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}
