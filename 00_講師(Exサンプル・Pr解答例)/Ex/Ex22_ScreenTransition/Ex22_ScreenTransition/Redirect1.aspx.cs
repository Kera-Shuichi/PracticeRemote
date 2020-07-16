using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex22_ScreenTransition
{
    public partial class Redirect1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // セッション変数の初期化
            Session["Name"] = string.Empty;
            // 画面遷移
            Response.Redirect("Redirect2.aspx");
            // セッション変数に値を設定
            Session["Name"] = "Redirect1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // セッション変数の初期化
            Session["Name"] = string.Empty;
            // 画面遷移
            Response.Redirect("Redirect2.aspx", true);
            // セッション変数に値を設定
            Session["Name"] = "Redirect2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // セッション変数の初期化
            Session["Name"] = string.Empty;
            // 画面遷移
            Response.Redirect("Redirect2.aspx", false);
            // セッション変数に値を設定
            Session["Name"] = "Redirect3";
        }
    }
}