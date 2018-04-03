using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.ViewModel
{
    /// <summary>
    /// Token
    /// </summary>
    public class UserTokenView
    {
        public int TokenId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public System.DateTime Timeout { get; set; }
        public int UserType { get; set; }
        public System.DateTime CreateTime
        {
            get; set;
        }
    }
}
