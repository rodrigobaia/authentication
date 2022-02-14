using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Authentication.Auth
{
    /// <summary>
    /// 
    /// </summary>
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            #region [ Usado apenas para modelar a base com o Migration do EntityFramework ] 



             var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseMySql(DbConnection.ConnectionString, serverVersion,
                       providerOptions => providerOptions.EnableRetryOnFailure());

            #endregion [ Usado apenas para modelar a base com o Migration do EntityFramework ] 

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
