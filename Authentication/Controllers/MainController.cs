using Authentication.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Authentication.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class MainController: ControllerBase
    {
        private readonly INotifierBusiness _notifierBusiness;
        public readonly IUser AppUser;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="notifierBusiness"></param>
        /// <param name="appUser"></param>
        public MainController(INotifierBusiness notifierBusiness,
                            IUser appUser)
        {
            _notifierBusiness = notifierBusiness;
            AppUser = appUser;

            if (appUser.IsAuthenticated())
            {
                UsuarioId = appUser.GetUserId();
                UsuarioAutenticado = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected Guid UsuarioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected bool UsuarioAutenticado { get; set; }

        /// <summary>
        /// Valida se a operação esta ok
        /// </summary>
        /// <returns></returns>
        protected bool ValidOperation()
        {
            return !_notifierBusiness.HasNotification();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        protected ActionResult CustomResponse(object result = null)
        {
            if (ValidOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notifierBusiness.GetNotifications().Select(n => n.Message)
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid) NotificarErroModelInvalida(modelState);
            return CustomResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelState"></param>
        protected void NotificarErroModelInvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                var errorMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(errorMsg);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        protected void NotificarErro(string mensagem)
        {
            _notifierBusiness.Handle(new Business.Models.Notification(mensagem));
        }
    }
}
