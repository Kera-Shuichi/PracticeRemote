using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr13_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // コンボボックスに列挙型の値を指定
            cbxMonth.DataSource = Enum.GetValues(typeof(Month));
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // 入力値の取得
            int targetMonth = cbxMonth.SelectedIndex + 1;

            // DateTime型変数の宣言
            DateTime targetDate = new DateTime
                (2020, targetMonth, 1);

            // カレンダーへセット
            monthCalendar.SetDate(targetDate);

            // 別解
            int m = (int)cbxMonth.SelectedValue;
            monthCalendar.SetDate(DateTime.Parse(string.Format("2019/{0}/1", m + 1)));

            // 別解2
            monthCalendar.SetDate(DateTime.Parse("2019" + cbxMonth.Text + "1"));
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            // 入力値を受け取る
            string inputMonth = tbxMonth.Text;

            // 入力値がMonth中にあるか判定
            if(Enum.IsDefined(typeof(Month), inputMonth))
            {
                // string → Month変換
                Month enumMonth = (Month)Enum.Parse(typeof(Month), inputMonth);

                // インデックスずれの修正
                int targetMonth = (int)enumMonth + 1;

                // DateTime型変数の宣言
                DateTime targetDate = new DateTime(DateTime.Now.Year, targetMonth, 1);

                // カレンダーへセット
                monthCalendar.SetDate(targetDate);
            }

            // 別解
            int count = 0;
            foreach (string s in Enum.GetNames(typeof(Month)))
            {
                count++;
                if (tbxMonth.Text == s)
                {
                    monthCalendar.SetDate(new DateTime(2019, count, 1));
                    
                    return;
                }
            }
        }
    }

    enum Month
    {
        /// <summary>1月</summary>
        Jan,
        /// <summary>2月</summary>
        Feb,
        /// <summary>3月</summary>
        Mar,
        /// <summary>4月</summary>
        Apr,
        /// <summary>5月</summary>
        May,
        /// <summary>6月</summary>
        Jun,
        /// <summary>7月</summary>
        Jul,
        /// <summary>8月</summary>
        Aug,
        /// <summary>9月</summary>
        Sep,
        /// <summary>10月</summary>
        Oct,
        /// <summary>11月</summary>
        Nov,
        /// <summary>12月</summary>
        Dec
    }
}
