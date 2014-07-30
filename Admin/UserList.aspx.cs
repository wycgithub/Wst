using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wst.Service;

namespace Wst.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserService uService = new UserService();
            Repeater1.DataSource=uService.GetAll();
            Repeater1.DataBind();
        }
        protected void ModButton_Click(object sender, EventArgs e)
        {
           
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Del")
                Response.Write(e.Item.ItemIndex);
        }

        protected void DelButton_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            UserService uService = new UserService();
        }
    }
}