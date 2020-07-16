using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex21_PostBack
{
    public partial class HelloWorldByWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtYourName.Text = "名前を入力して！";
            }
        }

        protected void btnHello_Click(object sender, EventArgs e)
        {
            // ラベルに「Hello! ＜入力した名前＞」を表示する
            lblResult.Text = "Hello! " + txtYourName.Text;
        }
    }
}