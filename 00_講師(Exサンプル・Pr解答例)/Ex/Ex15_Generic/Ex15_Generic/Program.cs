using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            IntClass intClass = new IntClass();
            intClass.Value = 999;

            GenericClass<int, IntClass> generic = new GenericClass<int, IntClass>();

            generic.Value1 = 111;
            generic.Value2 = intClass;

            int test = generic.Value2.Value;
        }
    }

    class GenericClass<T, U>
    {
        public T Value1 { get; set; }
        public U Value2 { get; set; }
    }

    class IntClass
    {
        public int Value { get; set; }
    }
}
