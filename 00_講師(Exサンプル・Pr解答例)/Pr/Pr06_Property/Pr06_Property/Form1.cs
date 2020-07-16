using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr06_Property
{
    public partial class Form1 : Form
    {
        // 生徒を保持する配列
        Student[] stList = new Student[10];
        // 登録数を保持するフィールド
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //// Studentのインスタンス化
            //Student s = new Student();

            //s.Grade = int.Parse(tbxGrade.Text);
            //s.Class = int.Parse(tbxKumi.Text);
            //s.Name = tbxName.Text;

            //// 出力
            //Console.WriteLine(s.Text);
            ////Console.WriteLine("{0}年{1}組{2}", s.Grade, s.Class, s.Name);

            //配列のｎ番目に生徒を保持※最大10人まで
            //st2を生徒を保持する配列 stList に入れる
            if (count < 10)
            {
                Student s2 = new Student();
                //年、組、名前を指定
                s2.Grade = int.Parse(tbxGrade.Text);
                s2.Class = int.Parse(tbxKumi.Text);
                s2.Name = tbxName.Text;

                stList[count] = s2;
                count++;
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //リストボックスの内容をクリア
            lbxOutput.Items.Clear();

            //登録されている生徒(stListに保持)をリストボックスに表示（lbxOutput）
            for (int i = 0; i < count; i++)
            {
                lbxOutput.Items.Add(stList[i].Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // リストボックスの表示内容を消す
            lbxOutput.Items.Clear();

            // 保持に利用していた配列 stList をきれいにする
            for (int i = 0; i < count; i++)
            {
                stList[i] = null;
            }

            // 登録数 count を初期化する
            count = 0;
        }
    }

    public class Student
    {
        // 学年プロパティ
        //public int Grade { get; set; }
        private int _grade;
        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if(0 < value && value <= 6)
                {
                    _grade = value;
                }
            }
        }

        // クラスプロパティ
        //public int Class { get; set; }
        private int _class;
        public int Class
        {
            get
            {
                return _class;
            }
            set
            {
                if (0 < value)
                {
                    _class = value;
                }
            }
        }

        // 名前プロパティ
        public string Name { get; set; }

        // 体裁を整えて出力するプロパティ
        public string Text
        {
            get
            {
                //return Grade + "年" + Class + "組" + Name;
                return string.Format("{0}年{1}組{2}", Grade, Class, Name);
            }
        }
    }
}
