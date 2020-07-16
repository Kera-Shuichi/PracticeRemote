using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Book>();

            // 要素の追加
            Book b = new Book("ジャンプ");
            list.Add(b);
            list.Add(new Book("マガジン"));
            list.Add(new Book("サンデー"));

            // 要素の取り出し
            Console.WriteLine(list[0].Name);

            // すべての要素の取り出し
            for(int i = 0; i < list.Count; i++)
            {
                Book book = list[i];
                Console.WriteLine(book.Name);
            }

            foreach(Book book in list)
            {
                Console.WriteLine(book.Name);
            }

            // Insertメソッド
            list.Insert(2, new Book("チャンピオン"));

            // IndexOfメソッド
            int index = list.IndexOf(b);
            Console.WriteLine(index);

            // Removeメソッド
            list.Remove(b);

            // RemoveAtメソッド
            list.RemoveAt(2);

            // Clearメソッド
            list.Clear();
        }
    }

    class Book
    {
        public string Name { get; }
        public Book(string name)
        {
            this.Name = name;
        }
    }
}
