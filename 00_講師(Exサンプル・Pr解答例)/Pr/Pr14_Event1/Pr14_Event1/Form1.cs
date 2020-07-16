using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr14_Event1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MouseDownイベントの登録
            btnEvent.MouseDown += this.BtnEvent_MouseDown;

            //MouseUpイベントの登録
            btnEvent.MouseUp += this.BtnEvent_MouseUp;
        }

        private void BtnEvent_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("ボタンを離した"); ;
        }

        private void BtnEvent_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("ボタンを押した");
        }
    }
}
