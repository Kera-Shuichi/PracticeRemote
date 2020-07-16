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

namespace Pr11_Structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //　結果のstring格納用変数
            string result = "";

            //　表の内容を構造体化　+　構造体の配列に格納
            PracticeMember[] mem_array = {new PracticeMember{No=11,Name="久保　裕也",Birthday="1980.05.23",Height=177,Weight=80,Tou="右",Da="右"},
                                  new PracticeMember{No=13,Name="香月　良太",Birthday="1982.07.27",Height=180,Weight=85,Tou="右",Da="右"},
                                  new PracticeMember{No=15,Name="澤村　拓一",Birthday="1988.04.03",Height=184,Weight=99,Tou="右",Da="右"},
                                  new PracticeMember{No=18,Name="杉内　俊哉",Birthday="1980.10.30",Height=175,Weight=82,Tou="左",Da="左"},
                                  new PracticeMember{No=19,Name="菅野　智之",Birthday="1989.10.11",Height=185,Weight=90,Tou="右",Da="右"}
                                 };

            // ヘッダーの作成（ブランクで体裁調整）　※ \nは改行
            result += "No　氏名　　　　　生年月日　身長　体重　投　打\r\n";

            // 結果の文字をmember[]配列から取り出して
            // result変数に格納
            foreach (PracticeMember mem in mem_array)
            {
                result += mem.No;
                result += "　" + mem.Name.PadLeft(5);
                result += "　" + mem.Birthday.PadLeft(10);
                result += String.Format("　{0}", mem.Height);
                result += String.Format("　{0}", mem.Weight);
                result += "　　 " + mem.Tou.PadLeft(1);
                result += "　" + mem.Da.PadLeft(1);
                result += "\r\n";
            }

            ArrayList mem2 = new ArrayList();
            mem2.Add(new PracticeMember { No = 11, Name = "久保　裕也", Birthday = "1980.05.23", Height = 177, Weight = 80, Tou = "右", Da = "右" });


            //　結果の表示
            lblMember.Text = result;
        }
    }

    //　表のデータ格納用メンバー構造体
    public struct PracticeMember
    {
        //　各構造体用プロパティ
        public int No { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Tou { get; set; }
        public string Da { get; set; }

        public PracticeMember(int no, string name, string birthday, int height, int weight, string tou, string da)
        {
            No = no;
            Name = name;
            Birthday = birthday;
            Height = height;
            Weight = weight;
            Tou = tou;
            Da = da;
        }

    }
}
