using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex22_ScreenTransition
{
    public partial class Anchor1 : System.Web.UI.Page
    {
        string category = "NotePC";
        int pageIndex = 2;

        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "Anchor2.aspx?Category=" +
                category + "&PageIndex=" + pageIndex;
        }
    }
}