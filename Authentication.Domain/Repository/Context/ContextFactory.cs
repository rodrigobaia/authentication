using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
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
    public class ContextFactory : IDesignTimeDbContextFactory<AuthContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public AuthContext CreateDbContext(string[] args)
        {
            #region [ Usado apenas para modelar a base com o Migration do EntityFramework ] 



            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

            var optionsBuilder = new DbContextOptionsBuilder<AuthContext>();

            optionsBuilder.UseMySql(DbConnection.ConnectionString, serverVersion,
                       providerOptions => providerOptions.EnableRetryOnFailure());

            #endregion [ Usado apenas para modelar a base com o Migration do EntityFramework ] 

            return new AuthContext(optionsBuilder.Options);
        }
    }
}
