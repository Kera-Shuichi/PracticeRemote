using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Pr23_State_Transfer
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 初回起動時のみ処理を行う
            if (!IsPostBack)
            {
                // 今日の日付を選択状態にする Calendar1
                Calendar1.SelectedDate = Calendar1.TodaysDate;

                // 日付のテキストボックスに、今日の日付を表示する tbxDate
                tbxDate.Text = Calendar1.TodaysDate.ToString("yyyy/MM/dd");

                // 重要度の項目設定 listImportance
                listImportance.Items.Add(ConfigurationManager.AppSettings["LEVEL1"]);
                listImportance.Items.Add(ConfigurationManager.AppSettings["LEVEL2"]);
                listImportance.Items.Add(ConfigurationManager.AppSettings["LEVEL3"]);

                //tbxToDo.TextMode = TextBoxMode.MultiLine;
            }

            // アプリケーション名をページのタイトルに設定する
            Page.Title = Application["Title"].ToString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // テキストボックスに表示させる（年/月/日)   tbxDate    
            tbxDate.Text = Calendar1.SelectedDate.ToString("yyyy/MM/dd");
        }

        protected void btnExec_Click(object sender, EventArgs e)
        {
            // 未入力がなければ、画面遷移する tbxDate tbxToDo
            // 未入力があれば、画面遷移しない、ラベルにエラー表示 lblErr
            if(tbxDate.Text == string.Empty || tbxToDo.Text == string.Empty)
            {
                lblErr.Text = "未入力項目があります。";
                return;
            }

            //画面遷移
            Session["Date"] = tbxDate.Text;
            Session["Importance"] = listImportance.SelectedValue;
            Session["Todo"] = tbxToDo.Text;

            Response.Redirect("Page2.aspx");
        }
    }
}