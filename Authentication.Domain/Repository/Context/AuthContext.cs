using Authentication.Domain.Repository.Config;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
    public class AuthContext: DbContext
    {

        public AuthContext(DbContextOptions<AuthContext> options)
            : base(options) 
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationId>(new ApplicationIdConfig().Configure   );

        }

        /// <summary>
        /// Set
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            return (DbSet<TEntity>)base.Set<TEntity>();
        }
    }
}
