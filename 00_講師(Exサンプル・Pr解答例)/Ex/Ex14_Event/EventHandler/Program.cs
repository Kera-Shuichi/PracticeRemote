using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            // TextFinderクラスのオブジェクト生成
            TextFinder tf = new TextFinder(@"C:\Users\kourogi\Desktop\Ex14\Program.cs");

            // イベントハンドラの登録
            tf.TextFound += Tf_TextFound;

            // 「public」から始まる行でイベント発生
            tf.Execute("public");

            Console.ReadLine();
        }

        private static void Tf_TextFound(object sender, TextFoundEventArgs e)
        {
            Console.WriteLine(e.Line);
        }
    }

    // ①イベント情報を格納する「カスタムEventArgs」クラスを定義
    public class TextFoundEventArgs : EventArgs
    {
        public TextFoundEventArgs(string line)
        {
            Line = line;
        }
        public string Line { get; }
    }

    // ②イベントを発行するクラスの定義
    public class TextFinder
    {
        private string _filename;
        public TextFinder(string filename)
        {
            _filename = filename;
        }

        // (a)イベントの宣言
        public event EventHandler<TextFoundEventArgs> TextFound;
        
        // (b)イベントを発行する「OnEventNameメソッド」の定義
        protected virtual void OnTextFound(TextFoundEventArgs e)
        {
            if(TextFound != null)
            {
                TextFound(this, e);
            }
        }

        // (c)「OnEventName」の呼び出しコードの記述
        public void Execute(string target)
        {
            using(StreamReader sr = new StreamReader(_filename))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    if (line.TrimStart().StartsWith(target))
                    {
                        TextFoundEventArgs e = new TextFoundEventArgs(line);
                        OnTextFound(e);
                    }
                }
            }
        }
    }

}
