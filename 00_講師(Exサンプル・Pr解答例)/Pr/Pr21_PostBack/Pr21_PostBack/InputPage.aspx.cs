  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr22_PostBack
{
    public partial class InputPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //パネルの表示制御
            //InputPanel  ConfirmPanel  CompletePanel
            InputPanel.Visible = true;
            ConfirmPanel.Visible = false;
            CompletePanel.Visible = false;
        }

        protected void btnInputOK_Click(object sender, EventArgs e)
        {
            //パネルの表示制御
            //InputPanel  ConfirmPanel  CompletePanel
            InputPanel.Visible = false;
            ConfirmPanel.Visible = true;
            //CompletePanel.Visible = false;

            //入力内容の反映
            //InputValueLabel(ラベル)  ValueInput(テキストボックス)
            InputValueLabel.Text = ValueInput.Text;

        }

        protected void btnConfirmOK_Click(object sender, EventArgs e)
        {
            //パネルの表示制御
            //InputPanel  ConfirmPanel  CompletePanel
            InputPanel.Visible = false;
            //ConfirmPanel.Visible = false;
            CompletePanel.Visible = true;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ////パネルの表示制御
            ////InputPanel  ConfirmPanel  CompletePanel
            InputPanel.Visible = true;
            ConfirmPanel.Visible = false;
            CompletePanel.Visible = false;
        }
    }
}