using EmployeeTodoList.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeTodoList.WebApi.Infrastructure.Configurations
{
    public static class EntityFrameworkMigrationConfiguration
    {
        public static void RunEntityFrameworkMigrations(this IServiceCollection services)
        {
            using (IServiceScope scope = services.BuildServiceProvider().CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<EmployeeTodoListContext>()
                    .Database.Migrate();
                scope.ServiceProvider.GetRequiredService<EmployeeTodoListDataFillerContext>()
                    .Database.Migrate();
            }
        }
    }
}
