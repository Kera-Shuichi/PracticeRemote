using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Ex23_StateTransition
{
    public partial class AppSetting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTest1.Text = 
                System.Configuration.ConfigurationManager.AppSettings["Test1"];
            lblTest2.Text =
                ConfigurationManager.AppSettings["Test2"];
        }
    }
}