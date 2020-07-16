using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Prop = 100;
            mc.Show(string.Format("mc.Prop = {0}", mc.Prop));

            Console.ReadLine();
        }
    }

    // インターフェイス
    interface IMyInterface
    {
        void Show(string str);

        int Prop { get; set; }
    }

    class MyClass: IMyInterface
    {
        // メソッドの実装
        public void Show(string str)
        {
            Console.WriteLine("Showメソッド: {0}", str);
        }

        // プロパティの実装
        public int Prop { get; set; }
    }
}
