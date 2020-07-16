using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicGenreEnum musicGenre1 = MusicGenreEnum.Jazz;
            if(musicGenre1 == MusicGenreEnum.Rock)
            {
                Console.WriteLine("ロックである");
            }
            else
            {
                Console.WriteLine("ロックでない");
            }
            Console.ReadLine();

            // 列挙型に数値の代入は不可
            //MusicGenreEnum musicGenre2 = 3;
            MusicGenreEnum musicGenre3 = (MusicGenreEnum)3;
            MusicGenreEnum musicGenre4 = MusicGenreEnum.Rock;

            // 列挙型からint型へ
            int n = (int)MusicGenreEnum.Rock;
            // int型から列挙型へ（範囲外でもエラーとならない）
            MusicGenreEnum musicGenre5 = (MusicGenreEnum)7;
        }
    }

    /// <summary>
    /// 音楽ジャンル
    /// </summary>
    public enum MusicGenreEnum
    {
        /// <summary>不明</summary>
        Unknown,
        /// <summary>クラシック</summary>
        Classic,
        /// <summary>ジャズ</summary>
        Jazz,
        /// <summary>ロック</summary>
        Rock,
        /// <summary>ポップス</summary>
        Pops
    }
}
