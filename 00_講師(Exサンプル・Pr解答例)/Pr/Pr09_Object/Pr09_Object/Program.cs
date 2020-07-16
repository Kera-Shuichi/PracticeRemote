using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr09_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            Console.WriteLine("object");

            //指定したオブジェクトが現在のオブジェクトと等しいか
            Console.WriteLine(obj.Equals(""));

            //型情報を返す
            Console.WriteLine(obj.GetType());

            //現在のオブジェクトを表す「String」を返す
            //オブジェクトクラスはクラスのフルネームを返す
            Console.WriteLine(obj.ToString());

            string str = "あいうえお";
            Console.WriteLine("string");

            Console.WriteLine(str.Equals("あいうえお"));
            Console.WriteLine(str.GetType());
            Console.WriteLine(str.ToString());

            Console.ReadLine();
        }
    }
}
