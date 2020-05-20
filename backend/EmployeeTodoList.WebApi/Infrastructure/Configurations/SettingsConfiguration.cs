using EmployeeTodoList.WebApi.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace EmployeeTodoList.WebApi.Infrastructure.Configurations
{
    public static class SettingsConfiguration
    {
        public static EmployeeTodoListSettings AddSettings(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddSingleton(configuration);
            services.Configure<EmployeeTodoListSettings>(configuration);
            services.AddScoped(cfg => cfg.GetService<IOptionsSnapshot<EmployeeTodoListSettings>>().Value);
            services.AddScoped(cfg => cfg.GetService<IOptionsSnapshot<EmployeeTodoListSettings>>().Value.ConnectionStrings);

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider.GetService<EmployeeTodoListSettings>();
        }
    }
}
