using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Wst.Model
{
    public class Users :IEntity
    {
        public string UserName { get; set; }
        public string UserPwd { get; set; }

        public DateTime CreateTime { get { return DateTime.Now; } set { value = DateTime.Now; } }
        public DateTime LastTime { get { return DateTime.Now; } set { value = DateTime.Now; } }
        public int TabID { get; set;}
    }
}