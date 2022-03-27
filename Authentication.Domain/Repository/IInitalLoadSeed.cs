using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInitalLoadSeed
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task InitialLoadAsync();
    }
}
