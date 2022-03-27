using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class AspNetUserClaim
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserId { get; set; } = String.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string ClaimType { get; set; } = String.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string ClaimValue { get; set; } = String.Empty;
    }
}
