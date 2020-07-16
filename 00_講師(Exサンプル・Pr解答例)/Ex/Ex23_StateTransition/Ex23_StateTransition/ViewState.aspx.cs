using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex23_StateTransition
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSetViewState_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "のり");
            dic.Add(2, "テープ");

            // ViewStateにデータを格納
            ViewState["ProductInfo"] = dic;
            ViewState["FavoriteBook"] = "111";

            // ViewStateからデータを取得
            string s = ViewState["FavoriteBook"] as string;
            Dictionary<int, string> dic2 = ViewState["ProductInfo"] as Dictionary<int, string>;
        }
    }
}