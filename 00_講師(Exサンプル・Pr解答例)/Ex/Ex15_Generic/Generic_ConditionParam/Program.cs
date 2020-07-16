using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_ConditionParam
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericClass<Member> gc = new GenericClass<Member>();
            var gc = new GenericClass<Member>();
            
            gc.SetXName(11, "福井");
            gc.Show();
            Console.ReadLine();
        }
    }

    class Member
    {
        public int No { get; set; }
        public string Name { get; set; }

        public Member()
        {
            No = 0;
            Name = string.Empty;
        }
    }

    class GenericClass<T> where T : Member, new()
    {
        T mem = new T();
        public void Show()
        {
            Console.WriteLine("mem.Name = {0}. mem.No = {1}", mem.Name, mem.No);
        }

        public void SetXName(int n, string str)
        {
            mem.No = n;
            mem.Name = str;
        }
    }
}
