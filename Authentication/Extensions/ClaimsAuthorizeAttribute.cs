using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Authentication.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class ClaimsAuthorizeAttribute : TypeFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="claimName"></param>
        /// <param name="claimValue"></param>
        public ClaimsAuthorizeAttribute(string claimName, string claimValue) : base(typeof(RequisitoClaimFilter))
        {
            Arguments = new object[] { new Claim(claimName, claimValue) };
        }
    }
}
