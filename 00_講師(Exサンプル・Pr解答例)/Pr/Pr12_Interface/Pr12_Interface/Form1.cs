using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr12_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsole_Click(object sender, EventArgs e)
        {
            ConsoleLogWriter log = new ConsoleLogWriter();
            log.Write("{0} {1}", DateTime.Now, "ConsoleSample");
        }

        private void btnPlain_Click(object sender, EventArgs e)
        {
            PlainTextLogWriter log = new PlainTextLogWriter();
            log.Write("{0} {1}", DateTime.Now, "PlainTextSample");
        }
    }

    //抽象クラス⇒インターフェイスに 修正の必要あり。
    public interface ILogWriter
    {
        void Write(string format, params object[] args);

        void Write(string arg);
    }

    //LogWriterクラスを継承⇒ILogWriterインターフェイスの実装
    public class ConsoleLogWriter : ILogWriter
    {
        public void Write(string format, params object[] args)
        {
            string msg = string.Format(format, args);
            Write(msg);
        }

        public void Write(string arg)
        {
            Console.WriteLine(arg);
        }
    }

    //LogWriterクラスを継承⇒ILogWriterインターフェイスの実装
    public class PlainTextLogWriter : ILogWriter
    {
        public void Write(string format, params object[] args)
        {
            string msg = string.Format(format, args);
            Write(msg);
        }

        public void Write(string arg)
        {
            using (System.IO.StreamWriter tw = new System.IO.StreamWriter("Debug.log", true))
            {
                tw.WriteLine(arg);
            }
        }
    }

    public interface ILogMsg
    {
        void ShowMessage(string arg);
    }
}
