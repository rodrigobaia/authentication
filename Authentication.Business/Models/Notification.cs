using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Business.Models
{
    /// <summary>
    /// Notificação
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Mensagem</param>
        public Notification(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code">Código</param>
        /// <param name="message">Mensagem</param>
        public Notification(int code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary>
        /// Código
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Mensagem
        /// </summary>
        public string Message { get; set; }
    }
}
