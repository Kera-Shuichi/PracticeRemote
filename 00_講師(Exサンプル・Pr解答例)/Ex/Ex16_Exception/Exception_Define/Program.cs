using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Define
{
    class Program
    {
        static Dictionary<int, string> members = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            try
            {
                members.Add(1, "Mike");
                members.Add(2, "Senna");
                if (CheckExistMember(3))
                {

                }
            }
            catch(MemberNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        static bool CheckExistMember(int code)
        {
            if (!members.ContainsKey(code))
            {
                string message = string.Format("コード：{0}のメンバーは未登録です。", code);
                throw new MemberNotFoundException(message);
            }
            return true;
        }
    }

    class MemberNotFoundException: Exception
    {
        public MemberNotFoundException(string message): base(message)
        {
            using(System.IO.StreamWriter sw =
                new System.IO.StreamWriter("MemberNotFoundException.log", true))
            {
                sw.WriteLine("{0}: {1}", DateTime.Now, message);
            }
        }
    }
}
