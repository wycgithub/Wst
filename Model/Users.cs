using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wst.Model
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public DateTime CreateTime { get; set;}
        public DateTime LastTime { get; set; }
        public int TabID { get; set;}
    }
}