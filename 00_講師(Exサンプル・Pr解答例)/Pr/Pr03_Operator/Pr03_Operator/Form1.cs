using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr03_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //①次の計算を行って、結果を変数に格納しましょう。
            //1 + 2
            //10 - 3
            //9 × 9
            //10 ÷ 5　（計算結果を求める）
            //10 ÷ 3　（あまりを求める）
            //3 ×1.5 (計算結果を小数で求める)
            //10 ÷ 4 (計算結果を小数で求める)


            // 計算の実行と、結果の格納
            int result1 = 1 + 2;
            int result2 = 10 - 3;
            int result3 = 9 * 9;
            int result4 = 10 / 5;
            int result5 = 10 % 3;
            double result6 = 3 * 1.5;
            double result7 = 10 / 4.0;

            // 計算結果の出力
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
        }
    }
}
