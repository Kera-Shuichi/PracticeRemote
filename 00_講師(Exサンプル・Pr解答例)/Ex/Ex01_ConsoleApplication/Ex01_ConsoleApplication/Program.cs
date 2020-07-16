using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // コンソールに文字を出力する
            //Console.WriteLine("こんにちは、世界！");
            //Console.WriteLine("Hello World!");

            DispLines();

            Console.ReadLine();
        }

        private static void DispLines()
        {
            Console.WriteLine("こんにちは、世界！");
            Console.WriteLine("Hello World!");
        }
    }
}
