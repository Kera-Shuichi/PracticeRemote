using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr16_Exception_Finally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            try
            {
                // 3.処理の開始
                //int a = int.Parse(txtValue.Text);
                int a;
                if (int.TryParse(txtValue.Text, out a) == false)
                {
                    MessageBox.Show("数値で入力して下さい。");
                    return;
                }
                JudgeNum(a);
            }
            // 4.例外をキャッチ
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
            }
            // 5.finallyを利用して、「処理が終了しました。」
            finally
            {
                MessageBox.Show("処理が終了しました。");
            }
        }

        // 2.数値判定メソッド作成、引数は入力された数値
        private static void JudgeNum(int target)
        {
            //数値の判定処理        
            if (target <= 10)
            {
                //10以下⇒「○○を入力しました。」
                string msg = string.Format
                     ("{0}を入力しました。", target.ToString());
                MessageBox.Show(target + "を入力しました。");
            }
            else
            {
                //10より大⇒独自に定義した例外を発生
                //    　　　　例外のMessageプロパティで「10より大きい…」
                throw new MyException("10より…");
            }


        }
    }

    // 1.独自例外クラスの作成
    class MyException : Exception
    {
        public MyException() : base()
        {
        }
        public MyException(string message) : base(message)
        {
        }
    }
}
