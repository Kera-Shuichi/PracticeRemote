using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr14_Delegate
{
    public partial class Form1 : Form
    {
        // 食品保持用
        private FoodDataList fd = new FoodDataList();

        // 表示対象食品数
        private int targetCount = 0;

        // 表示対象食品の合計価格
        private decimal targetTotalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // 画面起動時
        private void Form1_Load(object sender, EventArgs e)
        {
            //食品分類コンボボックスに下記の値を設定
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox combo = (ComboBox)ctrl;
                    combo.Items.Add("加工食品");
                    combo.Items.Add("生鮮食品");
                    combo.Items.Add("菓子");
                    combo.Items.Add("飲料");
                    combo.Items.Add("その他");
                    combo.SelectedIndex = 0;
                }
            }

            string[] value = new string[] { "加工食品", "生鮮食品", "菓子" };
            typeCombo.Items.AddRange(value);
            dispTypeCombo.Items.AddRange(value);

        }

        // 登録ボタン押下時
        private void registButton_Click(object sender, EventArgs e)
        {
            //入力した食品情報（食品名、値段、食品分類）を保持
            fd.Add(nameText.Text,
                   decimal.Parse(priceText.Text),
                   (FoodType)typeCombo.SelectedIndex);

            //入力した内容を初期化（初期表示と同じ状態）
            nameText.Text = "";
            priceText.Text = "";
            typeCombo.SelectedIndex = 0;
        }

        // クリアボタン押下時
        private void clearButton_Click(object sender, EventArgs e)
        {
            //保持している食品情報をクリアする
            fd.Clear();
            targetCount = 0;
            targetTotalPrice = 0;

            //入力した内容を初期化（初期表示と同じ状態）
            nameText.Text = "";
            priceText.Text = "";
            typeCombo.SelectedIndex = 0;

        }

        // 一覧ボタン押下時
        private void listButton_Click(object sender, EventArgs e)
        {
            // 保持している食品情報を出力（表示対象の食品分類のみ）
            OutputData(string.Format("==={0}===", dispTypeCombo.Text));
            fd.FoodAction(PrintTitle, (FoodType)dispTypeCombo.SelectedIndex);
        }

        // 平均ボタン押下時
        private void averageButton_Click(object sender, EventArgs e)
        {
            // 保持している食品の平均の値段を出力（表示対象の食品分類のみ）
            OutputData(string.Format("==={0}===", dispTypeCombo.Text));

            fd.FoodAction(AddToTargetValue, (FoodType)dispTypeCombo.SelectedIndex);

            if (fd.Count > 0)
            {
                OutputData(String.Format("値段の平均:{0:#,##0}円",
                                         targetTotalPrice / targetCount));
            }

            targetCount = 0;
            targetTotalPrice = 0;
        }

        // 食品名を表示する
        private void PrintTitle(Food f)
        {
            OutputData(String.Format("{0}:{1}", f.Name, f.Price));
        }

        // 表示対象食品情報の追加
        private void AddToTargetValue(Food f)
        {
            targetCount += 1;
            targetTotalPrice += f.Price;
        }

        // ファイルへの書込処理
        private void OutputData(string text)
        {
            using (System.IO.StreamWriter tw =
                        new System.IO.StreamWriter("Food.log", true))
            {
                tw.WriteLine(text);
            }
        }
    }

    // 食品分類
    public enum FoodType
    {
        Processed,        // 加工食品
        Fresh,            // 生鮮食品
        Confection,       // 菓子
        Drink,            // 飲料
        Else              // その他
    }

    // 食品クラス
    public class Food
    {
        public string Name { get; set; }    // 食品名
        public decimal Price { get; set; }  // 値段
        public FoodType Type { get; set; }  // 食品分類

        // コンストラクタ
        public Food(string name, decimal price, FoodType type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
    }

    // 食品データクラス
    public class FoodDataList
    {
        // 食品リスト
        private ArrayList foodList = new ArrayList();

        // 登録食品数取得プロパティ
        public int Count
        {
            get
            {
                return foodList.Count;
            }
        }

        //食品リストへの追加メソッド
        public void Add(string name, decimal price, FoodType type)
        {
            foodList.Add(new Food(name, price, type));
        }

        //食品リストのクリアメソッド
        public void Clear()
        {
            foodList.Clear();
        }

        //食品ごとにデリゲートメソッドを呼び出して処理する
        public void FoodAction(Action<Food> foodDataDisp, FoodType foodType)
        {
            foreach (Food food in foodList)
            {
                if (food.Type == foodType)
                {
                    foodDataDisp(food);
                }
            }
        }
    }
}
