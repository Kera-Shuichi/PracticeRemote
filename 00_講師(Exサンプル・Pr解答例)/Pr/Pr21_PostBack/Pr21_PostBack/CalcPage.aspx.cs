using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr22_PostBack
{
    public partial class CalcPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // デザインで項目を設定しない場合
            //if (IsPostBack == false)
            //{
            //    OperatorList.Items.Add("＋");
            //    OperatorList.Items.Add("－");
            //    OperatorList.Items.Add("×");
            //    OperatorList.Items.Add("÷");
            //}
        }

        protected void ExecButton_Click(object sender, EventArgs e)
        {
            // 数値に変換した入力値を保持する変数
            double leftValue;
            double rightValue;

            //入力値チェック
            if (double.TryParse(LeftValueInput.Text, out leftValue) == false ||
                double.TryParse(RightValueInput.Text, out rightValue) == false)
            {
                return;
            }

            // 計算処理
            switch (OperatorList.SelectedValue)
            {
                case "＋":
                    AnswerLabel.Text = (leftValue + rightValue).ToString();
                    break;
                case "－":
                    AnswerLabel.Text = (leftValue - rightValue).ToString();
                    break;
                case "÷":
                    AnswerLabel.Text = (leftValue / rightValue).ToString();
                    break;
                case "×":
                    AnswerLabel.Text = (leftValue * rightValue).ToString();
                    break;
            }
        }
    }
}
