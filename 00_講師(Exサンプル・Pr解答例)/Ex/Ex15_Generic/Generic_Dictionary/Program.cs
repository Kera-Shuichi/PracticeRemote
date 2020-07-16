using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            var dict = new Dictionary<string, string>();

            // 要素の追加
            dict.Add("COW", "ウシ");
            dict.Add("SHEEP", "ヒツジ");
            dict.Add("PIG", "ブタ");

            // Keyの存在チェック
            //if (!dict.ContainsKey("PIG"))
            //{
                dict.Add("PIG2", "ブタ");
            //}

            // Valueの存在チェック
            string value = "ブタ";
            if (dict.ContainsValue(value))
            {
                Console.WriteLine("{0}が格納されています。", value);
            }

            // Valueの取得
            Console.WriteLine(dict["COW"]);
            Console.WriteLine(dict["SHEEP"]);
            Console.WriteLine(dict["PIG"]);

            // すべての要素の取り出し
            foreach(KeyValuePair<string, string> kv in dict)
            {
                Console.WriteLine(kv.Key + "=" + kv.Value);
            }

            // Removeメソッド（指定したキーの削除）
            dict.Remove("COW");

            // Clearメソッド
            dict.Clear();

            Console.ReadLine();
        }
    }
}
