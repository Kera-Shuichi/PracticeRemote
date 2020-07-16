using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04_ControlStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIf_Click(object sender, EventArgs e)
        {
            // 入力値保持用の変数宣言
            int inputPoint = int.Parse(tbxIf.Text);

            if(inputPoint == 100)
            {
                MessageBox.Show("Excellent!");
            }
            else if(inputPoint >= 70)
            {
                MessageBox.Show("Fine!");
            }
            else if(inputPoint >= 50)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NG");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // 入力値保持用の変数宣言
            int inputNumber = 
                int.Parse
                (tbxSwitch.Text);

            switch (inputNumber)
            {
                case 1:
                case 2:
                    MessageBox.Show("One or Two");
                    break;
                case 3:
                    MessageBox.Show("Three");
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // 階乗をもとめる処理

            //// while文
            //int factorial = 1;
            //int n = int.Parse(tbxWhile.Text);

            //while (n > 1)
            //{
            //    factorial *= n;
            //    n--;
            //}
            //MessageBox.Show(factorial.ToString());

            //// do文
            //int factorial = 1;
            //int n = int.Parse(tbxWhile.Text);
            //int i = 1;

            //do
            //{
            //    factorial *= i;
            //    i++;
            //} while (i <= n);
            //MessageBox.Show(factorial.ToString());

            // for文
            int n = int.Parse(tbxWhile.Text);
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i == 5)
                {
                    break;
                }

                factorial *= i;
            }
            MessageBox.Show(factorial.ToString());
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            // 合計値保持変数
            int total = 0;
            // 計算対象を保持する配列
            int[] inputCalc = new int[] { 10, 63, -92, 104 };

            foreach(int value in inputCalc)
            {
                if (value <= 0)
                {
                    continue;
                }

                total += value;
            }
            MessageBox.Show(total.ToString());
        }

    }
}
