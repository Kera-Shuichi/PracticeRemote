using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr27_JavaScript_ajax
{
    public partial class CheckInput : System.Web.UI.Page
    {
        /// <summary>
        /// ajax戻り値用エラーメッセージ
        /// </summary>
        protected string ResponceErrorMessage { get; set; } = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            // URLパラメータより情報取得
            string date = this.Request.QueryString["date"];
            string status = this.Request.QueryString["status"];
            string genre = this.Request.QueryString["genre"];
            string menu = this.Request.QueryString["menu"];

            // 以下は入力チェックなので、解説省略
            // 日付
            if (!DateTime.TryParse(date, out _))
            {
                this.ResponceErrorMessage = "日付データが未入力または形式が不正です。";
                return;
            }

            // ステータス １・２・３のどれでもない場合
            if(!(status=="1" || status == "2" || status == "3"))
            {
                this.ResponceErrorMessage = "いつの食事か選択してください。(朝・昼・夜)";
                return;
            }

            // ジャンル未選択
            if (!int.TryParse(genre, out int genreParse) || genreParse == 0)
            {
                this.ResponceErrorMessage = "ジャンルが未選択です。";
                return;
            }

            // メニュー未選択
            if (!int.TryParse(menu, out int menuParse) || menuParse == 0)
            {
                this.ResponceErrorMessage = "メニューが未選択です。";
                return;
            }
        }
    }
}