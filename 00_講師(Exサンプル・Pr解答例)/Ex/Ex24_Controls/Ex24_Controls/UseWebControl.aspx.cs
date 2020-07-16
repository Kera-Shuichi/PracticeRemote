using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex24_Controls
{
    public partial class UseWebControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "入力値は" + TextBox1.Text;

            Panel1.Width = 300;
            Panel1.BackColor = System.Drawing.Color.Red;

            //this.div1.Style.Clear();
            //this.div1.Style.Add(HtmlTextWriterStyle.Width, "300px");
            //this.div1.Style.Add(HtmlTextWriterStyle.BackgroundColor, "red");

            // ラベルの追加
            Label lbl = new Label();
            lbl.Text = "TEST";
            form1.Controls.Add(lbl);
        }
    }
}