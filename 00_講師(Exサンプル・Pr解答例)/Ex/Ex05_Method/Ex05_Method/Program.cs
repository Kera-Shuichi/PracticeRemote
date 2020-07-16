using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personクラスのオブジェクト生成(インスタンス化)
            Person p = new Person();
            Person p2 = new Person("コンストラクタ名");

            // フィールドへの代入
            p.name = "テスト人名";
            p.weight = 100.2;
            p.height = 187.2;
            p.birthday = new DateTime(1995, 1, 2);

            // 戻り値のあるメソッドの呼び出し
            int age = p.GetAgeAt(DateTime.Today);
            int age2 = p.GetAge();

            // 年齢の出力
            Console.WriteLine(age);
            Console.ReadLine();


            // Parsonクラスのオブジェクト生成
            // フィールド代入の別の書き方
            Person p3 = new Person
            {
                name = "田中",
                weight = 72.6,
                height = 182.5,
                birthday = new DateTime(1988, 4, 11)
            };

            // BMIを求める
            double bmi = p3.GetBmi();

            // コンソールに出力
            Console.WriteLine("{0}({1})のBMIは、{2:#.0}", p3.name, p3.GetAge(), bmi);
            //string output = p3.name + "(" + p3.GetAge().ToString() + ")のBMIは、" + bmi.ToString();
            //string output2 = string.Format("{0}({1})のBMIは、{2:#.0}", p3.name, p3.GetAge(), bmi);
            Console.ReadLine();

        }
    }

    class Person
    {
        // フィールド
        public string name;
        public double weight;
        public double height;
        public DateTime birthday;

        // コンストラクタ
        public Person()
        {
            this.name = "誰か";
        }

        public Person(string name)
        {
            this.name = name;
        }

        // メソッドの定義
        public int GetAgeAt(DateTime today)
        {
            int age = today.Year - this.birthday.Year;

            if (today.Month < birthday.Month)
            {
                age--;
            }
            else if (today.Month == birthday.Month && today.Day < birthday.Day)
            {
                age--;
            }

            return age;
        }

        // GetAgeメソッドの定義
        public int GetAge()
        {
            return GetAgeAt(DateTime.Today);
        }

        // GetBmiメソッドの定義
        public double GetBmi()
        {
            double mh = this.height / 100d;
            return this.weight / (mh * mh);
        }
    }
}
