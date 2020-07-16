using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr22_Screen_Transfer
{
    public partial class QueryStringSub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //パラメータ(クエリ文字列)から値を取得
            string product = Request.QueryString["Product"];
            string maker = Request.QueryString["Maker"];

            //製品の表示　ProductTextLabel
            if (product == string.Empty)
            {
                ProductTextLabel.Text = "未選択";
            }
            else
            {
                ProductTextLabel.Text = product;
            }
            //メーカーの表示
            if (maker == string.Empty)
            {
                MakerTextLabel.Text = "未選択";
            }
            else
            {
                MakerTextLabel.Text = maker;
            }
        }
    }
}