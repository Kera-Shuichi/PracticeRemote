using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("達川", 62, null);
            var p2 = new Person("大野", null ,177.0);

            int? i;

            p1.OutPutData();
            p2.OutPutData();
            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public Nullable<double> Height { get; set; }
        public Person(string name, int? age, double? height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public void OutPutData()
        {
            int age = 0;
            double height = 0;

            // HasValue
            if (Age.HasValue)
            {
                age = Age.Value;
            }
            if (Height.HasValue)
            {
                height = Height.Value;
            }

            // NULL合体演算子
            age = Age ?? -1;
            height = Height ?? -1;

            Console.WriteLine("{0}/ {1}/ {2}", Name, age, height);
        }
    }
}
