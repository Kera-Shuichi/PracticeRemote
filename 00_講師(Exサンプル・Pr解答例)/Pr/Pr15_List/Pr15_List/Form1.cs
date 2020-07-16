using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr15_List
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            //テキストボックスに入力された値を取得,リストに追加
            int number = int.Parse(tbxNum.Text);
            numbers.Add(number);

            //テキストボックス:tbxNum を空にする
            tbxNum.Text = string.Empty;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            // 出力結果ラベル:lblResult を空に
            lblResult.Text = string.Empty;

            //リストに登録されている全ての値をカンマ区切りでラベルに表示する
            // lblResult.Text = string.Join(",", numbers);

            // for文を使用する場合
            for (int i = 0; i < numbers.Count; i++)
            {
                lblResult.Text += numbers[i];

                // 末尾の不要なカンマを追加しない場合
                if (i != numbers.Count - 1)
                {
                    lblResult.Text += ",";
                }
            }

            // 末尾の不要なカンマを最後に削除する場合
            // lblResult.Text = lblResult.Text.Remove(lblResult.Text.Length - 1, 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //テキストボックス tbxNum、ラベル lblResultの表示をクリア 
            tbxNum.Text = string.Empty;
            lblResult.Text = string.Empty;

            //リストに登録されている値を全てクリア
            numbers.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }
    }
}
