using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr17_Exception_Define
{
    class Program
    {
        static void Main(string[] args)
        {
            ErrorMaker em = new ErrorMaker();
            try
            {
                em.makeError(); // エラー発生
            }
            catch (OriginalException ex)
            {
                Console.WriteLine("catch(OriginalException ex)：エラーがスローされました。 ");
                Console.WriteLine("catch(OriginalException ex)：{0} ", ex.Message);
                Console.ReadLine();
            }
        }
    }

    class ErrorMaker
    {
        // エラーが発生するメソッド
        public void makeError()
        {
            int[] arr = new int[5];
            try
            {
                arr[10] = 1;
            }
            catch (IndexOutOfRangeException ex)
            {
                // 独自例外に置き換える
                throw new OriginalException("makeErrorメソッドでエラーが発生しました。", ex);
            }
        }
    }

    // 独自例外
    class OriginalException : Exception
    {
        // キャッチした例外情報を受け取るコンストラクタ
        // baseキーワードで基底クラス（Exceptionクラス）のコンストラクタを呼び出す
        public OriginalException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
