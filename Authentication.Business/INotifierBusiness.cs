using Authentication.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Business
{
    /// <summary>
    /// Interface de Business Notificação
    /// </summary>
    public interface INotifierBusiness
    {
        /// <summary>
        /// Tem Notificação?
        /// </summary>
        /// <returns></returns>
        bool HasNotification();

        /// <summary>
        /// Lista todas as notificações
        /// </summary>
        /// <returns></returns>
        IList<Notification> GetNotifications();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="notification"></param>
        void Handle(Notification notification);
    }
}
