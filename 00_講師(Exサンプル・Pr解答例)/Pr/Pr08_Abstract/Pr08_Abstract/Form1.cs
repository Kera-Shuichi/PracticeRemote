using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr08_Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //④-1:開始ボタンを押した時に、
            //    ①で作成した派生クラスのインスタンスを生成、
            BenchMarkSub sub = new BenchMarkSub(10000);

            //④-2:repeatメソッドを呼び出す。
            //⑤戻り値として処理時間が返ってくる。（ミリ秒:文字列）
            string sec = sub.repeat();

            //⑥出力ウィンドウに⑤の結果（～ミリ秒）を表示する。
            Console.WriteLine(sec + "ミリ秒");
        }
    }

    public abstract class Benchmark
    {
        //処理回数
        private int count;
        //コンストラクタ
        public Benchmark(int count)
        {
            this.count = count;
        }

        public abstract void benchmark();

        public string repeat()
        {
            //Stopwatchオブジェクトの作成
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //計測開始
            sw.Start();
            for (int i = 0; i < count; i++)
                benchmark();
            //計測終了
            sw.Stop();
            //計測時間をミリ秒で返す
            return sw.ElapsedMilliseconds.ToString();
        }
    }

    //①Benchmarkクラスの派生クラスを作成。
    class BenchMarkSub : Benchmark
    {
        //②コンストラクタを追加。
        public BenchMarkSub(int count) : base(count)
        {

        }

        //③benchmark()メソッドを追加し、計測したい処理を追加。
        //　　　　　　　　　　　　　　　「"処理速度計測中・・・"」
        public override void benchmark()
        {
            Console.WriteLine("処理速度計測中・・・");
        }
    }
}
