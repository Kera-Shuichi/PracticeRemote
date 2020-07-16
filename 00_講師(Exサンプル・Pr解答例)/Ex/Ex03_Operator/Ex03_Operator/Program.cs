using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 変数宣言
            int intX = 16;
            int intY = 6;
            int calcResult = 0;
            bool judgeResult = true;

            // 演算子の実行（演算子は変更可）
            calcResult = intX + intY;
            Console.WriteLine(calcResult);
            string str = Console.ReadLine();
           
            // 代入演算子（演算子は変更可）
            intX += intY;
            Console.WriteLine(intX);
            //Console.ReadLine();

            // インクリメント演算子（デクリメント演算子に変更可）
            intX = intY++;
            Console.WriteLine(intX);
            //Console.ReadLine();

            // 比較演算子（変更可）
            judgeResult = (intX == intY);
            Console.WriteLine(judgeResult);
            Console.ReadLine();

            // 論理演算子（変更可）
            judgeResult = (intX > 5) && (intY > 10);
            Console.WriteLine(judgeResult);
            Console.ReadLine();

            // 条件演算子
            judgeResult = (intX == intY);
            string strResult = judgeResult ? "正解" : "不正解";
            Console.WriteLine(strResult);
            Console.ReadLine();
        }
    }
}
