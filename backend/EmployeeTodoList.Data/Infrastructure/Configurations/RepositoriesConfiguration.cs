using EmployeeTodoList.Data.Repositories;
using EmployeeTodoList.Data.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeTodoList.Data.Infrastructure.Configurations
{
    public static class RepositoriesConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IToDoTaskRepository, ToDoTaskRepository>();

            return services;
        }
    }
}
