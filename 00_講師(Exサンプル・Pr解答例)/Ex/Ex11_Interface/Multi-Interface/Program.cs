using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            MysClass mc = new MysClass();
            mc.Show("IFirst-str1");
            mc.Show("ISoecond-str1", "ISecond-str2");
            Console.ReadLine();
        }
    }

    interface IFirst
    {
        void Show(string str1);
    }

    interface ISecond
    {
        void Show(string str1, string str2);
    }

    class MysClass : IFirst, ISecond
    {
        public void Show(string str1)
        {
            Console.WriteLine("str1 = {0}", str1);
        }

        public void Show(string str1, string str2)
        {
            Console.WriteLine("str1 = {0}, str2 = {1}", str1, str2);
        }
    }
}
