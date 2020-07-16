using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            // アップキャスト
            object objM = new Magazine();
            object objP = new Person();

            // ダウンキャスト
            Magazine mag1 = (Magazine)objM;
            Person per1 = (Person)objP;

            // どうなる？
            object obj2 = new Magazine();
            //Person p1 = (Person)obj2;

            // is演算子
            object obj3 = new Magazine();
            bool b1 = obj3 is Magazine;
            bool b2 = obj3 is object;
            bool b3 = obj3 is Person;
            Console.WriteLine("{0}, {1}, {2}", b1, b2, b3);
            Console.ReadLine();

            // as演算子
            object obj4 = new Magazine();
            Person mag2 = obj4 as Person;

            if (mag2 != null)
            {
                Console.WriteLine("成功");
            }
            else
            {
                Console.WriteLine("失敗");
            }
            Console.ReadLine();
        }
    }

    class Magazine
    {

    }

    class Person
    {

    }
}
