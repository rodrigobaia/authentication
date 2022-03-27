using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace Authentication.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class RequisitoClaimFilter : IAuthorizationFilter
    {
        private readonly Claim _claim;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="claim"></param>
        public RequisitoClaimFilter(Claim claim)
        {
            _claim = claim;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new StatusCodeResult(401);
                return;
            }

            if (!CustomAuthorization.ValidarClaimsUsuario(context.HttpContext, _claim.Type, _claim.Value))
            {
                context.Result = new StatusCodeResult(403);
            }
        }
    }
}
