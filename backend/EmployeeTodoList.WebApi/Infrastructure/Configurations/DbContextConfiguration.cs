using EmployeeTodoList.Data.Context;
using EmployeeTodoList.WebApi.Infrastructure.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeTodoList.WebApi.Infrastructure.Configurations
{
    public static class DbContextConfiguration
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, ConnectionStringsSettings settings)
        {
            services.AddDbContext<EmployeeTodoListContext>(options => options.UseSqlServer(settings.DefaultConnection));
            services.AddDbContext<EmployeeTodoListDataFillerContext>(options => options.UseSqlServer(settings.DefaultConnection));

            return services;
        }
    }
}
