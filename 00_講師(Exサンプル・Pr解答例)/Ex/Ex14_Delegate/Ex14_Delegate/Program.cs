using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // ②デリゲート型の変数を宣言、代入
            MyDelegate func = DelegateFunction;

            // ③デリゲート型の変数に代入したメソッドの呼び出し
            func(100);
            Console.ReadLine();

            // 補足：デリゲート型の引数を持つメソッドの呼び出し
            DoSomething(func);
        }

        // ①デリゲート型の作成
        public delegate void MyDelegate(int p);

        /// <summary>
        /// 引数をコンソールに出力するメソッド
        /// </summary>
        /// <param name="i">引数</param>
        public static void DelegateFunction(int i)
        {
            Console.WriteLine("{0}が引数として渡されました", i);
        }

        public static void DoSomething(MyDelegate function)
        {
            // デリゲート型変数(function)に入っているメソッドの呼び出し
            function(15);
            Console.ReadLine();
        }
    }
}
