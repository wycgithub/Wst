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
    public partial class Enter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 检测用户和密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            //string name = UseName.Text;
            //string word = PassWord.Text;
            //UserService uService = new UserService();
            //if(uService.GetByCondition(P=>P.UserName==name&&P.UserPwd==word)==null)
            //{
            //    ClientScript.RegisterClientScriptBlock(this.GetType(), "Vaildate", "alert('用户或密码错误')", true);
            //}
            //else
            //{

            //}

            Users u = new Users() { UserName = UseName.Text, UserPwd = PassWord.Text, UserID=1 };
            UserService uService = new UserService();
            uService.Update(u);
        }
    }
}