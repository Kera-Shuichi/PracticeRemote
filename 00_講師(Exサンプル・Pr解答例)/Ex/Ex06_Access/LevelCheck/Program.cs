using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex06_Access.PublicMembers clsA = new Ex06_Access.PublicMembers();
            clsA.intA = 1;
            clsA.MethodA();

            Ex06_Access.PrivateMembers clsB = new Ex06_Access.PrivateMembers();
            clsB.intB = 1;
            clsB.MethodB();

            Ex06_Access.InternalMembers clsC = new Ex06_Access.InternalMembers();
            clsC.intC = 1;
            clsC.MethodC();
        }
    }
}
