using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 変数を用意
            string message = "";

            // テキストボックスの入力内容を変数に代入
            message = textBox1.Text;

            // メッセージを表示する
            MessageBox.Show(message);
        }
    }
}
