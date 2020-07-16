using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr24_Web_Controls
{
    public partial class Practice1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            //◆出力内容の作成 cblLike◆
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //名前の追加
            sb.Append(txtName.Text);
            sb.Append(",");
            //年齢の追加
            sb.Append(txtOld.Text);
            sb.Append(",");
            //アドレスの追加
            sb.Append(txtMail.Text);
            sb.Append(",");
            //性別の追加
            sb.Append(rblSei.SelectedValue);
            sb.Append(",");
            //出身地方の追加
            sb.Append(ddlFrom.SelectedValue);
            //好物の追加
            foreach (ListItem ch in cblLike.Items)
            {
                if (ch.Selected == true)
                {
                    sb.Append(",");
                    sb.Append(ch.Text);
                }
            }

            //◆アンケート結果のファイル出力◆
            WriteFile(@"C:\temp\kekka.txt", sb.ToString(), true);


            //◆入力内容の初期化◆
            //テキストボックスの初期化
            foreach (Control ctl1 in Page.Controls)
            {
                foreach (Control ctl2 in ctl1.Controls)
                {
                    TextBox tbx = ctl2 as TextBox;

                    if (tbx != null)
                    {
                        tbx.Text = "";
                    }
                }
            }

            //性別選択の初期化
            rblSei.SelectedIndex = 0;

            //出身地方選択の初期化
            ddlFrom.SelectedIndex = 0;

            //好物の選択の初期化 cblLike
            foreach (ListItem li in cblLike.Items)
            {
                li.Selected = false;
            }

            cblLike.ClearSelection();

        }

        //ファイルの出力処理
        private void WriteFile(string fileName, string contents, bool append)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName, append))
            {
                sw.WriteLine(contents.ToString());
            }
        }
    }
}
