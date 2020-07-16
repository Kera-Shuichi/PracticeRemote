using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07_Inherit_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //Monsterクラスの変数に、Monsterクラスのインスタンスを代入
            //ジバニャン
            Monster jibaNyan = new Monster("ジバニャン", 50);
            jibaNyan.Attack();

            //Monsterクラスの変数に、Bossクラスのインスタンスを代入
            //フユニャン
            Boss fuyuNyan = new Boss("フユニャン", 45, 55);

            Monster monFuyuNyan = fuyuNyan;
            monFuyuNyan.Attack();

            //Bossクラスの変数に、Bossクラスのインスタンスを代入
            //ブチニャン
            Boss buchiNyan = new Boss("ブチニャン", 100, 100);

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

        //コンストラクタ
        public Monster(string name, int hitpoint)
        {
            Name = name;
            HitPoint = hitpoint;
        }

        //モンスターの攻撃
        public virtual void Attack()
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

        public Boss(string name, int hitpoint, int magicpoint): base(name, hitpoint)
        {
            MagicPoint = magicpoint;
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("ボス[{0}](HP:{1}、MP:{2})の同一ターン2回目の攻撃", Name, HitPoint, MagicPoint);
            Console.ReadLine();
        }

        public void CriticalAttack()
        {
            Console.WriteLine("ボス[{0}](HP:{1}、MP:{2})のクリティカルアタック"
                , Name, HitPoint, MagicPoint);
            Console.ReadLine();
        }
    }
}
