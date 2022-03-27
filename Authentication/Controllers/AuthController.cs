using Authentication.Auth;
using Authentication.Business;
using Authentication.Extensions;
using Authentication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Authentication.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/auth")]
    [ApiController]
    public class AuthController : MainController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AppSettings _appSettings;


        public AuthController(INotifierBusiness notifierBusiness,
                            SignInManager<IdentityUser> signInManager,
                              UserManager<IdentityUser> userManager,
                              IOptions<AppSettings> appSettings,
                              IUser appUser)
                        : base(notifierBusiness,
                              appUser)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }


        /// <summary>
        /// Login
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> LoginAsync(Dictionary<string, string> values)
        {
            if (values == null || !values.Any())
            {
                NotificarErro("Credencias Invalidas.");
                return CustomResponse();
            }

            var isValidCrentials = true;

            if (!values.Where(x => x.Key.ToUpper().Equals("CLIENTID")).Any())
            {
                NotificarErro("ClientId not found.");
                isValidCrentials = false;

            }

            if (!values.Where(x => x.Key.ToUpper().Equals("CLIENTSECRET")).Any())
            {
                NotificarErro("ClientSecret not found.");
                isValidCrentials = false;

            }

            if (!values.Where(x => x.Key.ToUpper().Equals("GRANTTYPE")).Any())
            {
                NotificarErro("grantType not found.");
                isValidCrentials = false;

            }

            if (!isValidCrentials)
            {
                return CustomResponse();

            }

            return Ok(values);
        }



        //private JwtSecurityToken GetToken(List<Claim> authClaims)
        //{
        //    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

        //    var token = new JwtSecurityToken(
        //        issuer: _configuration["JWT:ValidIssuer"],
        //        audience: _configuration["JWT:ValidAudience"],
        //        expires: DateTime.Now.AddHours(3),
        //        claims: authClaims,
        //        signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        //        );

        //    return token;
        //}
    }
}
