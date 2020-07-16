using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Access
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicMembers clsA = new PublicMembers();
            clsA.intA = 1;
            clsA.MethodA();

            PrivateMembers clsB = new PrivateMembers();
            clsB.intB = 1;
            clsB.MethodB();

            InternalMembers clsC = new InternalMembers();
            clsC.intC = 1;
            clsC.MethodC();
        }
    }

    public class PublicMembers
    {
        public int intA = 0;

        public int MethodA() { return Test(); }
    }

    public class PrivateMembers
    {
        private int intB = 0;

        private int MethodB() { return intB; }
    }

    public class InternalMembers
    {
        internal int intC = 0;

        internal int MethodC() { return intC; }
    }
}
