using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr04_ControlStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //　①の課題
        private void ifButton_Click(object sender, EventArgs e)
        {
            //・「0」～「9」   → 「１桁の数字を入力しました。」と表示。			
            //・「10」～「99」 → 「2桁の数字を入力しました。」と表示。			
            //・それ以外の数字 → 「その他の数字を入力しました。」と表示。			

            //　入力された文字列をint型に変換
            int num = int.Parse(ifText.Text);

            //　入力された値に応じて、if文で処理を分岐
            if (0 <= num && num < 10)
            {
                ifResult.Text = "1桁の数字を入力しました。";
            }
            else if (10 <= num && num < 100)
            {
                ifResult.Text = "2桁の数字を入力しました。";
            }
            else
            {
                ifResult.Text = "その他の数字を入力しました。";
            }
        }

        //　②の課題
        private void switchButton_Click(object sender, EventArgs e)
        {
            //・「1」 → 「1を入力しました。」と表示。		
            //・「2」 → 「2を入力しました。」と表示。		
            //・「3」「4」 → 「3か4を入力しました。」と表示。		
            //・それ以外 → 「その他の数を入力しました。」と表示。		

            //　入力された文字列をint型に変換
            string text = switchText.Text;
            int num = int.Parse(text);

            //　入力された値に応じて、switch文で処理を分岐
            switch (num)
            {
                case 1:
                    switchResult.Text = "1を入力しました。";
                    break;
                case 2:
                    switchResult.Text = "2を入力しました。";
                    break;
                case 3:
                case 4:
                    switchResult.Text = "3か4を入力しました。";
                    break;
                default:
                    switchResult.Text = "その他の数を入力しました。";
                    break;
            }
        }

        //　③の課題
        private void forButton_Click(object sender, EventArgs e)
        {
            //　for文での計算の実行
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                sum += i;
            }

            // 結果の表示
            forResult.Text = sum.ToString();
        }

        // ④の課題
        private void whileButton_Click(object sender, EventArgs e)
        {
            // 入力された数字を取得
            int num = int.Parse(whileText.Text);

            // 結果の*を合計するための変数
            string result = string.Empty;

            // 入力された回数だけ、*を合計する

            ////while文の場合
            //int count = 0;
            //while (count < num)
            //{
            //    result += "*";
            //    count++;
            //}

            // do文の場合
            if (num > 0)
            {
                int count = 1;
                do
                {
                    result += "*";
                    count++;
                } while (count <= num);
            }

            // 結果の表示
            whileResult.Text = result;
        }

        // ⑤の課題
        private void foreachButton_Click(object sender, EventArgs e)
        {
            //　for文での計算の実行
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                // iが4になったら、ループを抜ける
                if (i == 4)
                {
                    break;
                }

                sum += i;
            }

            //　結果の表示
            foreachResult.Text = sum.ToString();
        }
    }
}
