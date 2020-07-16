using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr16_Exception_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.ErrorMakerクラスのmakeErrorメソッドの呼び出し
            ErrorMaker em = new ErrorMaker();
            try
            {
                em.makeError();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            //throw ex;の確認
            var em2 = new Test();
            try
            {
                em2.TestMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
        }
    }

    //throw ex;の確認
    class Test
    {
        public void TestMethod()
        {
            try
            {
                var em = new ErrorMaker();
                em.makeError();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    class ErrorMaker
    {
        //IndexOutOfRangeExceptionの例外が発生
        public void makeError()
        {
            int[] arr = new int[5];
            try
            {
                arr[10] = 1;
            }
            catch (IndexOutOfRangeException ex)
            {
                //1.例外をスローするように変更
                //Console.WriteLine(ex);

                //別のエラーオブジェクトとなる
                //throw new IndexOutOfRangeException();

                //例外が発生した箇所ではなく、
                //例外をキャッチした箇所で例外が発生したかのように伝わる
                //throw ex;

                throw;
            }
        }
    }

}
