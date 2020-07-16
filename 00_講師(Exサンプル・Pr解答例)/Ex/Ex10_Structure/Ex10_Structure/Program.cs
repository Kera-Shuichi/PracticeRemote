using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            // 構造体は値型
            StructBook sbk1 = new StructBook("レタスクラブ", "222");
            Console.WriteLine(sbk1.DispBookData());
            Console.ReadLine();

            StructBook sbk2 = sbk1;
            sbk1.Title = "サラダクラブ";

            Console.WriteLine("sbk1: {0} sbk2: {1}", sbk1.Title, sbk2.Title);
            Console.ReadLine();

            // クラスは参照型
            ClassBook bk1 = new ClassBook("オレンジページ", "111");
            Console.WriteLine(bk1.DispBookData());
            Console.ReadLine();

            ClassBook bk2 = bk1;
            bk1.Title = "タウンページ";

            Console.WriteLine("bk1: {0} bk2: {1}", bk1.Title, bk2.Title);
            Console.ReadLine();
        }
    }

    // 構造体の定義
    public struct StructBook
    {
        public string Title { get; set; }
        public string ISBN { get; set; }

        public StructBook(string title, string isbn)
        {
            Title = title;
            ISBN = isbn;
        }

        public string DispBookData()
        {
            return string.Format("{0} {1}", Title, ISBN);
        }
    }

    // クラスの定義
    public class ClassBook
    {
        public string Title { get; set; }
        public string ISBN { get; set; }

        public ClassBook(string title, string isbn)
        {
            Title = title;
            ISBN = isbn;
        }

        public string DispBookData()
        {
            return string.Format("{0} {1}", Title, ISBN);
        }
    }
}
