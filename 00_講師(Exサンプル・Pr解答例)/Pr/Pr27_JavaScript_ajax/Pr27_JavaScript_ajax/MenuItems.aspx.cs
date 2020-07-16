using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr27_JavaScript_ajax
{
    public partial class MenuItems : System.Web.UI.Page
    {
        /// <summary>aspxに渡すためのデータ格納用</summary>
        protected string MenuItemsText { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            // URLクエリパラメータよりジャンルを取得
            string genre = this.Request.QueryString["genre"].ToString();

            List<string> items = new List<string>();

            // 空白追加
            items.Add("");

            // 選択されているジャンルによって作成する文字列を変える
            switch (genre)
            {
                case "1":
                    items.Add("和食日替わり定食");
                    items.Add("天ぷら定食");
                    items.Add("蕎麦");
                    items.Add("うどん");
                    break;

                case "2":
                    items.Add("ステーキセット");
                    items.Add("オムライス");
                    break;

                case "3":
                    items.Add("ラーメン");
                    items.Add("天津飯");
                    items.Add("麻婆豆腐定食");
                    break;
            }

            // string.joinを使用して1つの文字列生成(カンマ区切り)
            this.MenuItemsText = string.Join(",", items);
        }
    }
}