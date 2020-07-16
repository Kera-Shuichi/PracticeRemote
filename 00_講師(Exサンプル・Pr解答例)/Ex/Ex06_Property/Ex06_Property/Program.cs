using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personクラスのインスタンス化
            Person p = new Person();
            // Nameへ代入
            p.Name = "なにがし";

            //p.Weight = 60.5;
            p.Height = 70;
            Console.WriteLine(p.Height);
            Console.ReadLine();
        }
    }

    class Person
    {
        // 自動プロパティ
        public string Name { get; set; }

        // 読み取り専用プロパティ
        public double Weight { get; }

        // 代入制限
        private double height;
        public double Height
        {
            // 参照は制限なし
            get { return height; }

            // 代入は50より大きい場合のみ
            set
            {
                if ( value > 50 )
                {
                    height = value;
                }
            }
        }
    }
}
