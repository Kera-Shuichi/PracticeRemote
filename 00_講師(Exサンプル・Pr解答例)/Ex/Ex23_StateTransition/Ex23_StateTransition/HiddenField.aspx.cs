using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex23_StateTransition
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // HiddenFieldへ代入
                hdnTest.Value = DateTime.Now.ToString() + "テストデータ";
            }
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            // HiddenFieldの参照
            lblTest.Text = hdnTest.Value;
        }
    }
}