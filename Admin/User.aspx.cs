using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wst.Model;
using Wst.Service;

namespace Wst.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            UserService uService = new UserService();
            Users user = new Users() { UserName = UseName.Text, UserPwd = PassWord.Text};
            uService.Add(user);
        }
    }
}