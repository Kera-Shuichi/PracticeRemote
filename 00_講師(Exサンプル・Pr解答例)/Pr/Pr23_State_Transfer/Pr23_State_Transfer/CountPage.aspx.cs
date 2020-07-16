using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr23_State_Transfer
{
    public partial class CountPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 初回起動時
            if (!IsPostBack)
            {
                // ViewStateの初期化
                ViewState["Count"] = 0;
            }
        }

        protected void btnPush_Click(object sender, EventArgs e)
        {
            // ViewStateにクリック数を保持する
            int i = (int)ViewState["Count"];

            // 1回目クリック時
            if(i == 0)
            {
                // 開始時間(現在日時)をHiddenFieldに保持 hdnStartTime
                hdnStartTime.Value = DateTime.Now.ToString();
            }

            // カウントアップ
            i++;

            // クリック数をラベルへ表示
            lblCount.Text = i.ToString();

            // ViewStateにクリック数を格納
            ViewState["Count"] = i;

            // 10回目クリック時
            if(i == 10)
            {
                // ボタンの無効化
                btnPush.Enabled = false;

                // 終了時刻取得
                DateTime endTime = DateTime.Now;

                // 開始時刻取得
                DateTime startTime = DateTime.Parse(hdnStartTime.Value);

                // 所要時間の計算
                string time = (endTime - startTime).ToString();

                // 所要時間の出力
                lblTime.Text = time;
            }
        }
    }
}