using System;
using System.Collections.Generic;
using System.Text;
using EmployeeTodoList.Core.Modules.Employees.Abstractions;
using EmployeeTodoList.Core.Modules.Employees.Services;
using EmployeeTodoList.Core.Modules.Tasks.Abstractions;
using EmployeeTodoList.Core.Modules.Tasks.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeTodoList.Core.Infrastructure.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IToDoTaskService, ToDoTaskService>();

            return services;
        }
    }
}
