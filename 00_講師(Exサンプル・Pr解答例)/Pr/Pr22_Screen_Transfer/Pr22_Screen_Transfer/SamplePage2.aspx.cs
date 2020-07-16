using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr22_Screen_Transfer
{
    public partial class SamplePage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Redirect()を使用した場合
            // セッション変数を利用して取得
            string name = (string)Session["name"];
            string message = (string)Session["message"];

            lblName.Text = name;
            lblMsg.Text = message.Replace("\r\n", "<br />");    // 改行の反映

            // Transfer(), PostBackUrlを使用した場合
            //lblName.Text = Request.Form["tbxName"];
            //lblMsg.Text = Request.Form["txtTweet"].Replace("\r\n", "<br/>");

            // 日付時間の表示（問題指定外）
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}