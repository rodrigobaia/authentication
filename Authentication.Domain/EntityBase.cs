using Support.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain
{
    public class EntityBase
    {
    }

    public abstract class EntityBase<TPrimarykey> : EntityBase
    {
        /// <summary>
        /// 
        /// </summary>
        public TPrimarykey Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreatedIn { get; set; } = DateTime.Now.GetCurrentDate();
    }
}
