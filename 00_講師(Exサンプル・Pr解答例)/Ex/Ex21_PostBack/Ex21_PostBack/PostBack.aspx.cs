using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex21_PostBack
{
    public partial class PostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 現在日時の表示
            dateTimeLabel.Text = DateTime.Now.ToString();

            // ポストバックか判断
            if (!IsPostBack)
            {
                postBackLabel.Text = "初回のリクエスト";
            }
            else
            {
                postBackLabel.Text = "2回目以降のリクエスト";
            }
        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            sendCheck.Checked = true;
        }
    }
}