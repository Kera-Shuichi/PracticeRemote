using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr22_Screen_Transfer
{
    public partial class QueryStringMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //初回リクエスト時のみアイテム追加
            if (!IsPostBack)
            {
                //製品の追加
                ProductList.Items.Add(string.Empty);
                ProductList.Items.Add("CD");
                ProductList.Items.Add("DVD");
                ProductList.Items.Add("BD");
                //メーカーの追加
                MakerList.Items.Add("");
                MakerList.Items.Add("SONY");
                MakerList.Items.Add("TOSHIBA");
                MakerList.Items.Add("SHARP");
            }
        }

        protected void CheckButton_Click(object sender, EventArgs e)
        {
            //QueryStringSub.aspxへの遷移(パラメータで値を渡す)
            string url = string.Format
                ("QueryStringSub.aspx?Product={0}&Maker={1}",
                ProductList.SelectedValue,
                MakerList.SelectedValue);

            Response.Redirect(url);
        }
    }
}