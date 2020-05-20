using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTodoList.Data.Context
{
    public class EmployeeTodoListDataFillerContext : DbContext
    {
        public EmployeeTodoListDataFillerContext(DbContextOptions<EmployeeTodoListDataFillerContext> options) :
            base(options)
        {

        }
    }
}
