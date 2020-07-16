using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr27_JavaScript_ajax
{
    public partial class GenreItems : System.Web.UI.Page
    {
        /// <summary>aspxに渡すためのデータ格納用</summary>
        protected string GenreItemsText { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            // リスト型オブジェクト作成
            List<string> items = new List<string>();

            // ジャンルドロップダウンリストのアイテムをAdd
            items.Add("");
            items.Add("和食");
            items.Add("洋食");
            items.Add("中華");

            // string.joinを使用して1つの文字列生成(カンマ区切り)
            this.GenreItemsText = string.Join(",", items);
        }
    }
}