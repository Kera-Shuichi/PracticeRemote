using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr17_Raise_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // 課題サンプル
            int[] arr = new int[5];
            try
            {
                arr[10] = 1;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("*******************");
                Console.WriteLine(ex);
                Console.WriteLine("-------------------");
                Console.WriteLine(ex.Source);
                Console.WriteLine("-------------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine("-------------------");
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-------------------");
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine("-------------------");
            }

            // int型の最大値
            int a1 = 2147483647;
            int b1 = 0;
            try
            {
                checked
                {
                    b1 = a1 + 1;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("*******************");
                Console.WriteLine(ex);
                Console.WriteLine("-------------------");
                Console.WriteLine(ex.Source);
                Console.WriteLine("-------------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine("-------------------");
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-------------------");
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine("-------------------");
                Console.ReadLine();
            }

            // その他エラー例
            // ①数値に変換できない文字列を変換しようとしたとき
            try
            {
                int number = int.Parse("ABC");
            }
            catch (FormatException ex)
            {
                ShowErrInfo(ex);
            }

            // ②引数がNullだったとき
            string nullObj = null;
            try
            {
                int str = int.Parse(nullObj);
            }
            catch (ArgumentNullException ex)
            {
                ShowErrInfo(ex);
            }

            // ③0で除算しようとしたとき
            int zero = 0;
            try
            {
                int result = 100 / zero;
            }
            catch (DivideByZeroException ex)
            {
                ShowErrInfo(ex);
            }

            // ④存在しないファイルを開こうとしたとき
            try
            {
                System.IO.StreamReader sr =
                    System.IO.File.OpenText(@"C:\test.txt");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                ShowErrInfo(ex);
            }

            // ⑤Dictionaryに追加していないキーを指定したとき
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("ABC", "123");
            try
            {
                Console.WriteLine(dict["ABc"]);
            }
            catch (KeyNotFoundException ex)
            {
                ShowErrInfo(ex);
            }

            // ⑥間違った型の要素を配列に格納しようとしたとき
            string[] a = { "1", "2" };
            object[] b = a;
            try
            {
                b[1] = 3;
            }
            catch (ArrayTypeMismatchException ex)
            {
                ShowErrInfo(ex);
            }

            Console.ReadLine();

        }

        private static void ShowErrInfo(Exception ex)
        {
            Console.WriteLine("*******************");
            Console.WriteLine(ex);
            Console.WriteLine("-------------------");
            Console.WriteLine(ex.Source);
            Console.WriteLine("-------------------");
            Console.WriteLine(ex.Message);
            Console.WriteLine("-------------------");
            Console.WriteLine(ex.ToString());
            Console.WriteLine("-------------------");
            Console.WriteLine(ex.TargetSite);
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }
    }
}
