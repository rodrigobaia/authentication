using Microsoft.AspNetCore.Identity;
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
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; } = String.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; } = String.Empty;

        /// <summary>
        /// 
        /// </summary>
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Avatar { get; set; } = String.Empty;

        /// <summary>
        /// 
        /// </summary>
        public AspnetUserAccess? Access { get; set; }
    }
}
