using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr05_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面起動時メソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Carクラスオブジェクト生成
            Car car = new Car();

            // carのフィールドデータを代入
            car.maker = "トヨタ";
            car.model = "プリウス";
            car.fuel = 40.0;
            car.consumption = 30.5;

            string outputData = string.Format("メーカー：{0}、車種：{1}、ガソリン量{2}、燃費{3}",
                car.maker, car.model, car.fuel, car.consumption);
            this.outPutLabel.Text = outputData;

            // メソッドの呼び出し
            car.ShowCarData();

            // 走行可能距離数取得
            double fuelRequired = car.GetFuelRequired();
            MessageBox.Show(fuelRequired.ToString());

            // 必要なガソリン量取得
            double distance = car.GetDistance(150.5);
            MessageBox.Show(distance.ToString());

            // 現在の走行可能距離数取得
            double nowFuelRequired = car.GetFuelRequired(20.5);
            MessageBox.Show(nowFuelRequired.ToString());
        }
    }

    /// <summary>
    /// 車クラス
    /// </summary>
    public class Car
    {
        /// <summary>メーカー</summary>
        public string maker;
        /// <summary>車種</summary>
        public string model;
        /// <summary>ガソリン量</summary>
        public double fuel;
        /// <summary>燃費</summary>
        public double consumption;

        // メソッドを作成するコツ　
        // ①引数の有無・引数の内容　
        // ②どんな処理をするか　
        // ③戻り値の有無
        /// <summary>
        /// メーカーと車種をメッセージボックスで表示する
        /// </summary>
        public void ShowCarData()
        {
            string message = "メーカー：" + this.maker + ",車種：" + this.model;
            MessageBox.Show(message);
        }

        /// <summary>
        /// 走行可能距離数算出(ガソリン量＊燃費)
        /// </summary>
        /// <returns>走行可能距離数</returns>
        public double GetFuelRequired()
        {
            // 走行可能距離数計算
            double result = this.fuel * this.consumption;
            return result;
        }

        /// <summary>
        /// 現在の走行可能距離数算出
        /// </summary>
        /// <param name="nowCons">現時点の燃費</param>
        /// <returns>現時点の燃費を基にした走行可能距離数</returns>
        public double GetFuelRequired(double nowCons)
        {
            // 現在の走行可能距離数計算
            double result = this.fuel * nowCons;
            return result;
        }

        /// <summary>
        /// 必要ガソリン量算出
        /// </summary>
        /// <param name="distance">走行したい距離数</param>
        /// <returns>必要なガソリン量</returns>
        public double GetDistance(double distance)
        {
            // 計算
            double result = distance / this.consumption;
            return result;
        }
    }
}
