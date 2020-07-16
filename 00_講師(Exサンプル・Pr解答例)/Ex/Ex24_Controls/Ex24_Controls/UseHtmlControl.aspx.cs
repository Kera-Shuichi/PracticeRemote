using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex24_Controls
{
    public partial class UseHtmlCotrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_ServerClick(object sender, EventArgs e)
        {
            span1.InnerText = "入力値は" + text1.Value;

            div1.Style.Clear();
            div1.Style.Add(HtmlTextWriterStyle.Width, "600px");
            div1.Style.Add(HtmlTextWriterStyle.BackgroundColor, "red");
        }
    }
}