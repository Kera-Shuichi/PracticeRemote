using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Staic
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass s1 = new SampleClass();
            SampleClass s2 = new SampleClass();
            SampleClass s3 = new SampleClass();
            
            Console.WriteLine(SampleClass.GetInstanceCount());
            Console.ReadLine();

            Date dt1 = new Date(2006, 4, 23);
            if (dt1.IsWorldCupYear())
            {
                Console.WriteLine("World Cup Year!");
            }
            Console.ReadLine();

            if (Date.IsWorldCupYear2(1926))
            {
                Console.WriteLine("World Cup Year!");
            }
            Console.ReadLine();
        }
    }

    class SampleClass
    {
        private static int instanceCount = 0;

        public SampleClass()
        {
            instanceCount++;
        }

        public static int GetInstanceCount()
        {
            return instanceCount;
        }
    }

    public class Date
    {
        private int year; private int month; private int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public bool IsWorldCupYear()
        {
            return (year % 4 == 2 && year >= 1930);
        }

        public static bool IsWorldCupYear2(int year)
        {
            return (year % 4 == 2 && year >= 1930);
        }
    }
}
