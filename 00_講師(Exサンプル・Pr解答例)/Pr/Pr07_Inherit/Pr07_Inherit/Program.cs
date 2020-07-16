using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Monsterクラスの変数に、Monsterクラスのインスタンスを代入
            //ジバニャン
            Monster jibaNyan = new Monster();
            jibaNyan.Name = "ジバニャン";
            jibaNyan.HitPoint = 50;
            jibaNyan.Attack();

            //Monsterクラスの変数に、Bossクラスのインスタンスを代入
            //フユニャン
            Boss fuyuNyan = new Boss();
            fuyuNyan.Name = "フユニャン";
            fuyuNyan.HitPoint = 45;
            fuyuNyan.MagicPoint = 55;

            Monster monFuyuNyan = fuyuNyan;
            monFuyuNyan.Attack();

            //Bossクラスの変数に、Bossクラスのインスタンスを代入
            //ブチニャン
            Boss buchiNyan = new Boss();
            buchiNyan.Name = "ブチニャン";
            buchiNyan.HitPoint = 100;
            buchiNyan.MagicPoint = 100;

            buchiNyan.Attack();
            buchiNyan.CriticalAttack();
        }
    }

    class Monster
    {
        private string _name;
        private int _hitpoint;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitPoint
        {
            get { return _hitpoint; }
            set { _hitpoint = value; }
        }

        //モンスターの攻撃
        public void Attack()
        {
            Console.WriteLine("モンスター[{0}](HP:{1})の攻撃", Name, HitPoint);
            Console.ReadLine();
        }
    }

    class Boss : Monster
    {
        private int _magicpoint;

        public int MagicPoint
        {
            get { return _magicpoint; }
            set { _magicpoint = value; }
        }

        public void CriticalAttack()
        {
            Console.WriteLine("ボス[{0}](HP:{1}、MP:{2})のクリティカルアタック"
                , Name, HitPoint, MagicPoint);
            Console.ReadLine();
        }
    }
}
