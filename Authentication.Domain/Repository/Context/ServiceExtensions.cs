using Authentication.Domain.Repository.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Repository.Context
{
    /// <summary>
    /// 
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IApplicationIdRepository, ApplicationIdRepository>();
        }

        public static void RegisterAuthContext(this IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

            services.AddDbContext<AuthContext>(options =>
                          options.UseMySql(DbConnection.ConnectionString, serverVersion,
                          providerOptions => providerOptions.EnableRetryOnFailure())
                        );

        }
    }
}
