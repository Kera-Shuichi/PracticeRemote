using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr22_Screen_Transfer
{
    public partial class SamplePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            // 入力値をセッション変数に設定
            Session["name"] = tbxName.Text;
            Session["message"] = txtTweet.Text;

            // 画面遷移
            Response.Redirect("SamplePage2.aspx");
        }
    }
}