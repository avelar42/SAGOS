using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Config
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastrucute(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextBase>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ContextBase).Assembly.FullName)));
            //services.AddDatabaseDeveloperPageExceptionFilter();
            return services;
        }
    }
}
