using Authentication.Auth;
using Authentication.Business;
using Authentication.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Authentication
{
    /// <summary>
    /// 
    /// </summary>
    public static class ServiceExtension
    {
        /// <summary>
        /// Registrar Serviços
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterServices(this IServiceCollection services)
        {
            services.RegisterBusiness();
            services.AddScoped<IUser, AspNetUser>();
            services.AddScoped<IInitalLoadSeed, InitalLoadSeed>();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void AddIdentityConfig(this IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

            services.AddDbContext<ApplicationDbContext>(options =>
                          options.UseMySql(DbConnection.ConnectionString, serverVersion,
                          providerOptions => providerOptions.EnableRetryOnFailure())
                        );

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddErrorDescriber<IdentityMensagensPortugues>()
                .AddDefaultTokenProviders();

            var appSettings = new AppSettings();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = appSettings.ValidoEm,
                    ValidIssuer = appSettings.Emissor
                };
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="serviceProvider"></param>
        public static void RegisterSeed(this IServiceCollection services, IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {

            }
        }
    }
}
