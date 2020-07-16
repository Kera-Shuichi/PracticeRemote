using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex22_ScreenTransition
{
    public partial class Anchor2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string category = Request.QueryString["Category"];
            string pageIndex = Request.QueryString["PageIndex"];
            string.IsNullOrEmpty(category);

        }
    }
}