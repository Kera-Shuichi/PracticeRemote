using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr15_Dictionary
{
    public partial class Form1 : Form
    {
        Dictionary<string, Score> dict = new Dictionary<string, Score>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 入力された名前の取得する tbxName
            string name = tbxName.Text;

            //5教科の点数を取得する
            int japanese = int.Parse(tbxJapanese.Text);
            int math = int.Parse(tbxMath.Text);
            int science = int.Parse(tbxScience.Text);
            int social = int.Parse(tbxSocial.Text);
            int english = int.Parse(tbxEnglish.Text);

            if (dict.ContainsKey(name))
            {
                //追加済みの場合はエラーメッセージを表示
                MessageBox.Show("{0}さんは既に登録～", name);
            }
            else
            {
                // ディクショナリーに追加
                dict.Add(name, new Score(japanese, math, science, social, english));

                // スペース区切りの場合
                // lblName.Text += name + " ";

                // カンマ区切りの場合
                if (lblName.Text != string.Empty)
                {
                    lblName.Text += "," + name;
                }
                else
                {
                    lblName.Text += name;
                }
            }
        }

        private void btnDisp_Click(object sender, EventArgs e)
        {
            // 入力された名前の取得  tbxRequest
            string name = tbxRequest.Text;

            if (dict.ContainsKey(name))
            {
                Score sc = dict[name];

                //キーを指定して要素を取り出す
                string scores =  "国語：" + sc.Japanese.ToString() + "\n" +
                                  "数学：" + sc.Math.ToString() + "\n" +
                                  "理科：" + sc.Science.ToString() + "\n" +
                                  "社会：" + sc.Social.ToString() + "\n" +
                                  "英語：" + sc.English.ToString();

                string total = "合計 ： " + sc.SumScore().ToString();
                string average = "平均 ： " + sc.AverageScore().ToString();

                // ラベルに表示する
                lblScore.Text = scores + "\n" + total + "\n" + average;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //テキストボックス、ラベルのクリア
            tbxName.Text = "";
            tbxJapanese.Text = "";
            tbxMath.Text = "";
            tbxScience.Text = "";
            tbxSocial.Text = "";
            tbxEnglish.Text = "";
            lblName.Text = "";
            tbxRequest.Text = "";
            lblScore.Text = "";

            //フォーム内のテキストボックスの入力値をクリア
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl.Name == "lblName")
                {
                    ctl.Text = string.Empty;
                }

            }

            //lblName.Text = "";
            lblScore.Text = "";

            // ディクショナリーのクリア
            dict.Clear();
        }
    }

    // 点数を保持するクラス
    class Score
    {
        //5教科の値を保持するフィールド、プロパティを追加
        // フィールド
        private int japanese;      // 国語
        private int math;          // 数学
        private int science;       // 理科
        private int social;        // 社会
        private int english;       // 英語

        // プロパティ
        public int Japanese
        {
            get { return japanese; }
        }

        public int Math
        {
            get { return math; }
        }

        public int Science
        {
            get { return science; }
        }

        public int Social
        {
            get { return social; }
        }

        public int English
        {
            get { return english; }
        }


        //コンストラクタの引数は5教科の各点数
        public Score(int japanese, int math,
                     int science, int social, int english)
        {
            this.japanese = japanese;
            this.math = math;
            this.science = science;
            this.social = social;
            this.english = english;
        }

        //5教科の合計点を戻り値として返してくれるメソッドの追加 
        public int SumScore()
        {
            return japanese + math + science + social + english;
        }

        //5教科の平均点を戻り値として返してくれるメソッドの追加 
        public int AverageScore()
        {
            int total = japanese + math + science + social + english;
            int average = total / 5;
            return average;
        }

    }
}
