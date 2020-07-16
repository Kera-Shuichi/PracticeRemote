using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    // デリゲート型の作成
    public delegate void MyDelegate(int i);

    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.ReadLine();
        }

        //デリゲート型と同じ戻り値・引数となるメソッド1
        public static void DelegateFunction1(int n)
        {
            Console.WriteLine("{0}が引数として渡されました。", n);
        }

        //デリゲート型と同じ戻り値・引数となるメソッド2
        public static void DelegateFunction2(int n)
        {
            Console.WriteLine("引数は、{0}です。", n);
        }

        public static void Execute()
        {
            // デリゲート型変数の宣言・代入
            MyDelegate func = DelegateFunction1;

            // デリゲート型変数にメソッドの追加
            func += DelegateFunction2;

            // MyClassのインスタンス生成
            MyClass mc = new MyClass();

            // 引数にデリゲート型変数を設定、呼び出し
            mc.DoSomething(func);
        }
    }

    class MyClass
    {
        // 引数がデリゲート型のメソッド
        public void DoSomething(MyDelegate function)
        {
            for(int i = 0; i < 2; i++)
            {
                //デリゲート型変数(Function)に入っているメソッドの呼び出し
                function(i);
            }
        }
    }
}
