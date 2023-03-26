//using CompanyEmployees.Contracts;
//using Microsoft.EntityFrameworkCore;
//using CompanyEmployees.Repository;
using Serilog;
using Serilog.Events;

namespace WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
         public static void LogConfiguration()
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
               .WriteTo.File("./Log/IInfoSystemITLog.txt", rollingInterval:
                   RollingInterval.Day)
               .CreateLogger();
        }

        //public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        //   services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
}
