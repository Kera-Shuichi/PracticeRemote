using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr02_WindowsFormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // デザイン画面の各プロパティから設定することも可能だが、下記のようにプログラムで行うことも可能

        // 画面起動時の処理(デザイン画面でフォーム(画面そのもの)をダブルクリックすることで作成可能)
        private void Form1_Load(object sender, EventArgs e)
        {
            // ラベルの文字を変更
            lblTest.Text = "あいうえお";

            // テキストボックスの文字を変更
            tbxTest.Text  = "かきくけこ";

            // ピクチャボックスの画像を変更
            pbxTest.ImageLocation = @"C:\Users\IP_PC_075\Pictures\neko.jpg";

            // リストボックスの中身を追加
            lbxTest.Items.Add("A");
            lbxTest.Items.Add("B");
            lbxTest.Items.Add("C");

            // コンボボックスの中身を追加
            cbxTest.Items.Add("A");
            cbxTest.Items.Add("B");
            cbxTest.Items.Add("C");

            // チェックボックスのチェック状態を変更
            chkTest.Checked = true;

            // ラジオボタンの選択状態を変更
            rdoTest3.Checked = true;
        }
    }
}
