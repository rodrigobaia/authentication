using Authentication.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Business.Impl
{
    internal class NotifierBusiness : INotifierBusiness
    {

        private List<Notification> _notifications;

        /// <summary>
        /// 
        /// </summary>
        public NotifierBusiness()
        {
            _notifications = new List<Notification>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Notification> GetNotifications()
        {
            return _notifications;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="notification"></param>
        public void Handle(Notification notification)
        {
            _notifications.Add(notification);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool HasNotification()
        {
            return _notifications.Any();
        }
    }
}
