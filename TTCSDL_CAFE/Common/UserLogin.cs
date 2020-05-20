using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTCSDL_CAFE.Common
{
    [Serializable]
    public class UserLogin
    {
        public string UserID { get; set; }
        public string UserName { set; get; }
    }
}