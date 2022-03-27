using Authentication.Domain.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Repository.Impl
{
    /// <summary>
    /// 
    /// </summary>
    internal class ApplicationIdRepository : RepositoryBase<ApplicationId, string>, IApplicationIdRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="authContext"></param>
        public ApplicationIdRepository(AuthContext authContext) 
                                    : base(authContext)
        {
        }
    }
}
