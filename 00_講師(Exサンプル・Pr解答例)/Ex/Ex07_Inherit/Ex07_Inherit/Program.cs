using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            // 基底クラスの使用
            Person p = new Person("武田", 23);
            Console.WriteLine(p.Format());
            Console.ReadLine();

            // 派生クラスの使用
            Employee emp = new Employee("森本", 42, 1340, "営業部");
            Console.WriteLine(emp.Format());
            Console.ReadLine();

            // 派生クラス→基底クラスの代入
            p = emp;
            
            // 基底クラス→派生クラスの代入
            //emp = p;
            emp = (Employee)p;
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string pName, int pAge)
        {
            Name = pName;
            Age = pAge;
        }

        // 「名前（年齢）」の文字列を返すメソッド
        // 例）Name: 田中、Age: 30の場合は「田中（30）」という文字列を返す
        public virtual string Format()
        {
            string result = string.Empty;

            result = string.Format("{0}（{1}）", Name, Age);
            result = Name + "（" + Age + "）";

            return result;
        }
    }

    /// <summary>
    /// Personクラスを継承したクラス
    /// </summary>
    class Employee : Person
    {
        public int Id { get; set; }

        public string DeptName { get; set; }

        public Employee(string eName, int eAge, int id, string deptName): base(eName, eAge)
        {
            Id = id;
            DeptName = deptName;
        }

        //「部署名：名前（年齢）」の文字列を返すメソッド
        public override string Format()
        {
            return string.Format("{0}：{1}", DeptName, base.Format());
        }
    }
}
