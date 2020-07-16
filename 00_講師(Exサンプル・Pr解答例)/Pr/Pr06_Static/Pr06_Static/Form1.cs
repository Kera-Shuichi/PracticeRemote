using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr06_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Luggage luggage1 = new Luggage(100);
            Luggage luggage2 = new Luggage(200);
            Luggage luggage3 = new Luggage(300);

            //荷物の合計を表示する処理(lblTotal)
            lblTotal.Text = Luggage.GetTatal().ToString();

        }
    }

    //Luggageクラス
    class Luggage
    {
        private int weight;

        //合計値を格納する静的フィールド
        private static int total = 0;

        //コンストラクタ
        public Luggage(int weight)
        {
            this.weight = weight;
            total += weight;
        }

        public static int GetTatal()
        {
            return total;
        }


    }
}
