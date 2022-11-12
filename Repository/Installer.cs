using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public static class Installer
    {
        public static void ConfigureServices(IServiceCollection services, string dbConnString)
        {
            // for init db context             
            services.AddDbContext<SQLContext>(opt => opt.UseSqlServer(dbConnString));

            services.AddScoped<IBaseRepository<User>, SQLRepository<User>>();
            services.AddScoped<IBaseRepository<UserPassword>, SQLRepository<UserPassword>>();
            services.AddScoped<IBaseRepository<RegisterAttempt>, SQLRepository<RegisterAttempt>>();
            services.AddScoped<IBaseRepository<Product>, SQLRepository<Product>>();
            services.AddScoped<IBaseRepository<Category>, SQLRepository<Category>>();
            services.AddScoped<IBaseRepository<ProductDiscount>, SQLRepository<ProductDiscount>>();
            services.AddScoped<IBaseRepository<Order>, SQLRepository<Order>>();
            services.AddScoped<IBaseRepository<OrderDetails>, SQLRepository<OrderDetails>>();
            services.AddScoped<IBaseRepository<UserRole>, SQLRepository<UserRole>>();
            services.AddScoped<IBaseRepository<AuditLog>, SQLRepository<AuditLog>>();


        }

        public static void Configure(IServiceScope serviceScope)
        {
            serviceScope.ServiceProvider.GetService<SQLContext>().Database.Migrate();
        }
    }

}
