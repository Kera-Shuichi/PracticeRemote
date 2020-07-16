using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt = new Point();
            object o = new Point();

            int i = 0;

            pt.DoSomething(o);
            pt.DoSomething(i);
            pt.DoSomething(pt);
        }
    }

    class Point
    {
        public void DoSomething(object o)
        {
            Console.WriteLine(o);
            Console.ReadLine();
        }
    }
}
