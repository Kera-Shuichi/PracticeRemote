//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using X = System.Windows.Forms;

namespace Pr09_NamespaceA
{
    public partial class Form1 : System.Windows.Forms.Form // デフォルト設定？のSystemクラスを継承
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ①
        private void btn1_Click(object sender, System.EventArgs e)
        {
            lblTest.Text = "あいうえお";
        }
    }
}
