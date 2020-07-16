using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateUtilityクラスのオブジェクト生成
            DateUtility du = new DateUtility();
            

            // チェック対象日の設定
            DateTime date = new DateTime(2020, 4, 30);

            // メソッドの呼び出し1
            bool eom1 = du.IsEndOfMonth(date);
            // 出力(「月末です」が表示される)
            Console.WriteLine(eom1 == true ? "月末です" : "月末ではありません");
            Console.ReadLine();

            // メソッドの呼び出し2
            bool eom2 = du.IsEndOfMonth(2020, 4, 29);
            // 出力(「月末ではありません」が表示される)
            Console.WriteLine(eom2 == true ? "月末です" : "月末ではありません");
            Console.ReadLine();

        }
    }

    /// <summary>
    /// 日付に関するクラス
    /// </summary> 
    class DateUtility
    {
        /// <summary>テスト</summary>
        public string test;

        // IsEndOfMonthメソッドの定義
        public bool IsEndOfMonth(DateTime date)
        {
            // 月末かどうかの判定
            return date.AddDays(1).Day == 1;

            //// 引数の日付+1日
            //DateTime addDate = date.AddDays(1);

            //// 日付部分取得
            //int day = addDate.Day;
            //bool result = day == 1;
            //return result;
        }

        /// <summary>
        /// 月末判定メソッド
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>月末判定結果(true：月末 false：月末以外)</returns>
        public bool IsEndOfMonth(int year, int month, int day)
        {
            // 日付の設定
            DateTime date = new DateTime(year, month, day);
            //オーバーロードされた別メソッドの呼び出し
            return IsEndOfMonth(date);
        }
    }
}
