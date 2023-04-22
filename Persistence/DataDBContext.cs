//using Business.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityTypeConfigurations;


namespace Persistence
{
    public class DataDBContext : IdentityDbContext<User> /*IdentityDbContext<User>,*/ /*ICustomerDbContext, IContactDbContext, IProjectDbContext,*/
    //IProjectTaskDbContext, ITeamDbContext, IEmployeeDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DataDBContext(DbContextOptions<DataDBContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new ContractConfiguration());
            builder.ApplyConfiguration(new ProjectConfiguration());
            builder.ApplyConfiguration(new ProjectTaskConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(builder);
        }
    }
    // For Migration
    // For My SQL - Add-Migration <Name> -Project Persistence -StartupProject WebAPI
    // For Update
    // For My SQL - Update-database 
}
