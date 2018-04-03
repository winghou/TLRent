using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.ViewModel
{
    /// <summary>
    /// 健康检测
    /// </summary>
   public class HealthView
    {
        /// <summary>
        /// 请求是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 返回消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 返回码
        /// </summary>
        public string Code { get; set; }
    }
}
