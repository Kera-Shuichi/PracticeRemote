using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr14_Event2
{
    class Program
    {
        static void Main(string[] args)
        {
            //足し算クラスのオブジェクト生成 SumClass
            SumClass sc = new SumClass();

            //イベントの登録手続き
            sc.FinishSum += Sc_FinishSum;

            //足し算の実行メソッド呼び出し
            sc.Execute(4, 67);

            Console.ReadLine();
        }

        // イベントハンドラの定義
        private static void Sc_FinishSum(object sender, FinishSumEventArgs e)
        {
            Console.WriteLine(e.Sum);
        }
    }

    /// <summary>
    /// 足し算イベントの情報格納クラス
    /// 足し算の結果をイベント情報として持つ
    /// </summary>
    class FinishSumEventArgs : EventArgs
    {
        //結果を保持するプロパティ
        public int Sum { get;}

        //コンストラクタでプロパティの初期化
        public FinishSumEventArgs(int i)
        {
            Sum = i;
        }
    }

    /// <summary>
    /// 足し算イベントを発行するクラス
    /// </summary>
    class SumClass
    {
        // イベントの宣言
        public event EventHandler<FinishSumEventArgs> FinishSum;

        // イベントを発行するメソッドの定義
        protected virtual void OnFinishSum(FinishSumEventArgs e)
        {
            if (FinishSum != null)
            {
                FinishSum(this, e);
            }
        }

        /// <summary>
        /// イベントを発行するメソッドの呼び出し
        /// 足し算を行う
        /// </summary>
        /// <param name="num1">数字1</param>
        /// <param name="num2">数字2</param>
        public void Execute(int num1, int num2)
        {
            //足し算を行い、イベント情報に格納する
            int result = num1 + num2;
            FinishSumEventArgs e = new FinishSumEventArgs(result);

            //イベントを発生させる（OnEventNameの呼び出し）
            OnFinishSum(e);
        }
    }
}
