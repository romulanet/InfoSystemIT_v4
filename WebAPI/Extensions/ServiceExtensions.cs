//using CompanyEmployees.Contracts;
//using Microsoft.EntityFrameworkCore;
//using CompanyEmployees.Repository;
using Business.Behaviors;
using Domain.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using static System.Net.Mime.MediaTypeNames;
using Persistence.Repositories;
using WebAPI.Middleware;
using Business;

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
        
       
        //public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        //   services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
}
