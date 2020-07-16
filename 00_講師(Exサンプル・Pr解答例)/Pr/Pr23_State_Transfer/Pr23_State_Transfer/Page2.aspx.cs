using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr23_State_Transfer
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // アプリケーション名をページのタイトルに設定する
            Page.Title = Application["Title"].ToString();

            // 日付を取得する lblDate tbxDate
            lblDate.Text = (string)Session["Date"];
            // 重要度を取得する lblImportance listImportance
            lblImportance.Text = (string)Session["Importance"];
            // やることを取得する（改行を反映させて表示） lblToDo tbxToDo
            lblToDo.Text = ((string)Session["Todo"]).Replace("\n", "<br/>");
        }
    }
}