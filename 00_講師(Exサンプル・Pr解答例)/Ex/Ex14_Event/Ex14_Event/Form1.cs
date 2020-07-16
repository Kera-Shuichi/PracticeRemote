using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex14_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("クリックイベントが発生しました。");
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Click += Button1_Click;
            //this.button1.Click -= Button1_Click;

            //指定ディレクトリ・ファイル変更を監視、イベントを発生させるクラス
            FileSystemWatcher fsw = new FileSystemWatcher(@"C:\Users\kourogi\Desktop\Ex14");

            fsw.Created += Fsw_Created;
            fsw.Deleted += Fsw_Deleted;

            // 指定したフォルダ内の監視を開始
            fsw.EnableRaisingEvents = true;
        }

        private void Fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + "削除");
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.FullPath + "作成");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("クリックイベントが発生しました。");
        }
    }
}
