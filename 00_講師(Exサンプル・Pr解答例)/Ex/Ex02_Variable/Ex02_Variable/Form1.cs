using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hensuButton_Click(object sender, EventArgs e)
        {
            // 変数の宣言
            string dispMoji = "変数を表示する";

            // 出力ウィンドウへの表示
            Console.WriteLine(dispMoji);

        }

        private void teisuButton_Click(object sender, EventArgs e)
        {
            // 変数の宣言
            int radius = 5;

            // 定数の宣言
            const double pi = 3.14;

            // 半径5の面積を表示
            Console.WriteLine(radius * radius * pi);
        }

        // 配列ボタン押下
        private void arrayButton_Click(object sender, EventArgs e)
        {
            // 1次元配列の宣言
            string[] countryNames;
            countryNames = new string[3];
            countryNames[0] = "イギリス";
            countryNames[1] = "オランダ";
            countryNames[2] = "フランス";

            Console.WriteLine(countryNames[0]);
            Console.WriteLine(countryNames[1]);
            Console.WriteLine(countryNames[2]);
        }
    }
}
