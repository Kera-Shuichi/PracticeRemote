using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex22_ScreenTransition
{
    public partial class Transfer2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // QueryStringコレクションの取得
            string queryString = string.Empty;
            foreach(string key in Request.QueryString)
            {
                queryString += "key[" + key + "] value[" +
                    Request.QueryString[key] + "]<br />";
            }

            // Formコレクションの取得
            string formString = string.Empty;
            foreach (string key in Request.Form)
            {
                formString += "key[" + key + "] value[" +
                    Request.Form[key] + "]<br />";
            }

            // 取得した値をコントロールに設定
            Label1.Text = queryString;
            Label2.Text = formString;
        }
    }
}