using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();

            Ex09_Namespace.Class1 cl1 = new Class1();
            Ex09_NamespaceA.Class1 cl2 = new Ex09_NamespaceA.Class1();
        }
    }

    class Class1
    {

    }
}
