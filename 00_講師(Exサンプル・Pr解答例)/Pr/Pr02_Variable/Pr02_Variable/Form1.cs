using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr02_Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 変数ボタン押下時の処理
        private void hensuButton_Click(object sender, EventArgs e)
        {
            showVariable();
        }

        // 定数ボタン押下時の処理
        private void teisuButton_Click(object sender, EventArgs e)
        {
            // 定数の宣言
            // int 
            const int a = 8;

            // string
            const string b = "インフォメーションポート";

            // 定数の出力
            Console.WriteLine(a);

            // 定数の代入
            //a = 10;
        }

        // 配列ボタン押下時の処理
        private void arrayButton_Click(object sender, EventArgs e)
        {
            // 配列の宣言
            // ファースト　セカンド　サード
            string[] position = new string[3];
            position[0] = "ファースト";
            position[1] = "セカンド";
            position[2] = "サード";

            // 配列の出力
            Console.WriteLine(position[0]);
            Console.WriteLine(position[1]);
            Console.WriteLine(position[2]);

        }

        private void showVariable()
        {
            // 変数の宣言
            // int 
            int b = 1;

            // long
            long longB = 1;

            // float
            float c = 1.1f;

            // char
            char d = 'a';

            // string
            string f = "あいうえお";

            // 変数の出力
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
