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
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TPrimarykey"></typeparam>
    internal class RepositoryBase<TModel, TPrimarykey> : IRepositoryBase<TModel, TPrimarykey> where TModel : EntityBase<TPrimarykey>
    {
        private readonly AuthContext _authContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="authContext"></param>
        public RepositoryBase(AuthContext authContext)
        {
            _authContext = authContext;
        }
    }
}
