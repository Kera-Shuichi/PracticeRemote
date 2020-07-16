using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr01_WindowsForm
{
    public partial class Form1 : Form
    {
        /* 
         * 講義ではやりませんでしたが、
         * このようなコメントの仕方もあります。 
         */
         /*最初に文字を表示する方法について
          *「デザイン編集画面」より「テキストボックス」を右クリックし「プロパティ」を表示
          * 「Text」プロパティに文字を入れておくとその文字が画面起動時に表示されている。
          *
          */

        public Form1()
        {
            InitializeComponent();
        }

        // メッセージ表示ボタン押下
        private void DispButton_Click(object sender, EventArgs e)
        {
            // 変数の宣言・初期化(空白文字を代入)
            string message = "";

            // テキストボックスに入力された文字を「message」変数に代入
            message = MessageText.Text;

            // message変数内の文字をメッセージボックスで表示する
            MessageBox.Show(message);
        }

        // 入力内容の削除ボタン押下
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // テキストボックスに空白を代入(空白で上書きし、入力内容を削除する)
            MessageText.Text = "";

            //// 別回答
            //MessageText.Text = string.Empty;            
        }

        // 画面起動時のメソッド
        // ※デザイン画面にて、「フォーム(画面そのもの)」をダブルクリックすると画面起動時の処理を記載できるようになる
        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
