using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr06_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            //////// ①西暦を入力して計算ボタンをクリックすると、干支が表示されるプログラムを作成してください。
            ////// テキストボックスから入力されたデータを取得し変数に代入
            ////string inputYear = tbxYear.Text;

            ////// 入力されるデータは西暦(int)なので、int型に変換
            ////int year = int.Parse(tbxYear.Text);

            ////// 西暦を割った余りを求める
            ////int etoNumber = year % 12;

            ////// 余りを利用して干支を取得
            ////string zodiac = "";
            ////switch (year % 12)
            ////{
            ////    case 0:
            ////        zodiac = "申";
            ////        break;
            ////    case 1:
            ////        zodiac = "酉";
            ////        break;
            ////        // 以下省略
            ////}

            ////// ラベルに代入
            ////lblZodiac.Text = zodiac;






            //// ②計算用クラスを作成し、そこから計算結果を取得するようにしてください。
            // テキストボックスに入力されたデータを取得し、int型に変換してから変数に代入
            int year = int.Parse(tbxYear.Text);

            // 計算用クラスのインスタンス化(オブジェクト生成)
            ZodiacLogic zl = new ZodiacLogic();

            // 計算用クラスのオブジェクト(変数)である「zl」内のメソッドを呼び出す
            string zodiac = zl.getZodiac(year);

            // 取得した文字をラベルに表示
            lblZodiac.Text = zodiac;
        }

        // 「デザイン画面」でラベルをダブルクリックすると下記のような「ラベルをクリックしたとき」に動作するメソッドを作成できる
        private void LblZodiac_Click(object sender, EventArgs e)
        {

        }

        // 「デザイン画面」でテキストボックスをダブルクリックすると下記のような「テキストボックスの入力値が変更されたとき」に動作するメソッドを作成できる
        private void TbxYear_TextChanged(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// 干支計算クラス
    /// </summary>
    public class ZodiacLogic
    {
        // 引数：干支を求めるためには西暦が必要なため、int型の引数を設定
        // 戻り値：「丑」等の「文字」を戻す必要があるため、string型で戻り値を指定
        /// <summary>
        /// 干支の取得
        /// </summary>
        /// <param name="year">西暦</param>
        /// <returns>干支</returns>
        public string getZodiac(int year)
        {
            // 戻り値格納用の変数準備
            string result = "";

            // 割った余りでswitch分岐
            switch (year % 12)
            {
                case 0:
                    result = "申";
                    break;
                case 1:
                    result = "酉";
                    break;
                    // 以下省略
            }

            //　分岐結果を呼び出し元に戻す
            return result;
        }

        //別解(配列を使用する方法)
        private string[] arrayZodiac =
            { "申", "酉", "戌", "亥", "子", "丑",
              "寅", "卯", "辰", "巳", "午", "未" };

        public string getZodiac2(int year)
        {
            //干支を求める
            return arrayZodiac[year % 12];

            /* ※配列は添字(インデックス)が「0」から振られている。
             * 　計算結果は「0」だと「申」
             * 　上記のように計算結果と配列の添字が一致しているため、配列で簡単に求めることが可能。
             * 
             */
        }
    }
}
