using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjection
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
        public static IServiceCollection AddPersistence(this IServiceCollection
            services)
        {

            return services;
        }
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<DataDBContext>(options =>
            options.UseMySql(configuration.GetConnectionString("DbConnection"),
           MySqlServerVersion.LatestSupportedServerVersion));

        }

    }
}
