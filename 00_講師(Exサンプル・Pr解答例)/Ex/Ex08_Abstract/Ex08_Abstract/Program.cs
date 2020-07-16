using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // 抽象クラスのインスタンス生成は不可
            //Calc ca = new Calc();

            Plus plus = new Plus();
            plus.SetValue(21, 15);
            plus.Answer();

            Minus minus = new Minus();
            minus.SetValue(21, 15);
            minus.Answer();
        }
    }

    // 計算用抽象クラス
    abstract class Calc
    {
        public int IntA { get; set; }
        public int IntB { get; set; }

        public abstract void Answer();

        public void SetValue(int paramA, int paramB)
        {
            this.IntA = paramA;
            this.IntB = paramB;
        }
    }

    
    class Plus : Calc
    {
        sealed public override void Answer()
        {
            Console.WriteLine(string.Format("{0}+{1}={2}", IntA, IntB, (IntA + IntB).ToString()));
            Console.ReadLine();
        }
    }

    //class Plus2 : Plus
    //{
    //    public override void Answer()
    //    {

    //    }
    //}

    // 引き算クラス
    // IntA - IntB
    class Minus : Calc
    {
        public override void Answer()
        {
            Console.WriteLine(string.Format("{0}-{1}={2}", IntA, IntB, (IntA - IntB).ToString()));
            Console.ReadLine();
        }
    }
}
