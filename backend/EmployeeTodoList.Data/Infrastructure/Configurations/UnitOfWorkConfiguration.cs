using EmployeeTodoList.Data.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeTodoList.Data.Infrastructure.Configurations
{
    public static class UnitOfWorkConfiguration
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
