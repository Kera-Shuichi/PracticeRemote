using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneNumber phone1 = new PhoneNumber();
            Console.WriteLine("{0}:{1}", phone1.getOwner(), phone1.getNumber());
            
            PhoneNumber phone2 = new PhoneNumber("111-1111-111");
            Console.WriteLine("{0}:{1}", phone2.getOwner(), phone2.getNumber());

            PhoneNumber phone3 = new PhoneNumber("222","3333","4444");
            Console.WriteLine("{0}:{1}", phone3.getOwner(), phone3.getNumber());
            Console.ReadLine();
        }
    }

    /// <summary>
    /// 電話番号クラス
    /// </summary>
    class PhoneNumber
    {
        /// <summary>電話番号</summary>
        private string number;
        /// <summary>所有者名</summary>
        private string owner;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PhoneNumber()
        {
            this.number = "000-0000-000";
            this.owner = "所有者は引数なし";
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="number">電話番号</param>
        public PhoneNumber(string number)
        {
            this.number = number;
            this.owner = "所有者は引数1つ";
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="number1">電話番号1</param>
        /// <param name="number2">電話番号2</param>
        /// <param name="number3">電話番号3</param>
        public PhoneNumber(string number1, string number2, string number3)
        {
            this.number = number1 + "-" + number2 + "-" + number3;
            this.owner = "所有者は引数3つ";
        }


        /// <summary>
        /// 電話番号取得
        /// </summary>
        /// <returns>電話番号</returns>
        public string getNumber()
        {
            return this.number;
        }

        /// <summary>
        /// 所有者名取得
        /// </summary>
        /// <returns>所有者名</returns>
        public string getOwner()
        {
            return this.owner;
        }
    }
}
