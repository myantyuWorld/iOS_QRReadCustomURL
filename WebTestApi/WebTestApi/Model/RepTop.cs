using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KubotaTestApi.Model
{
    public class RepTop
    {
        /// <summary>
        /// 入力帳票ID
        /// </summary>
        public string RepTopId { get; set; }
        /// <summary>
        /// 入力帳票名称
        /// </summary>
        public string RepTopName { get; set; }

        public RepTop(string RefTopId, string RepTopName)
        {
            this.RepTopId = RefTopId;
            this.RepTopName = RepTopName;
        }
    }
}
