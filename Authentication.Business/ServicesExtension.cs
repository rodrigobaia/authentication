using Authentication.Business.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Business
{
    public static class ServicesExtension
    {
        /// <summary>
        /// Registar os objetos de Negocio
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterBusiness(this IServiceCollection services)
        {
            services.AddScoped<INotifierBusiness, NotifierBusiness>();
        }
    }
}
