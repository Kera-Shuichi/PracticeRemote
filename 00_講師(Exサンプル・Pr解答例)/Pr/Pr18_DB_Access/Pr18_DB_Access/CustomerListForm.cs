using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr18_DB_Access
{
    public partial class CustomerListForm : Form
    {
        private DBAccess _dbAccess; //DB接続オブジェクト

        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            // DB接続
            string strConnet = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                @"AttachDbFilename='|DataDirectory|\StoreManagement.mdf';Integrated Security=True;";
            _dbAccess = new DBAccess(strConnet);
            _dbAccess.Connect();

            // 再表示
            Redisp();
        }

        private void ReDispButton_Click(object sender, EventArgs e)
        {
            // 再表示
            Redisp();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            // 新規追加画面を起動する
            using(UpdateForm subForm =new UpdateForm(MyEnum.UpdateType.Insert, _dbAccess))
            {
                subForm.ShowDialog();
            }

            // 再表示
            Redisp();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // 顧客IDの取得
            string cutomerId = CustomerGrid.SelectedRows[0].Cells["Id"].Value.ToString();

            // 更新画面を起動する
            using (UpdateForm subForm = new UpdateForm(MyEnum.UpdateType.Update, _dbAccess, cutomerId))
            {
                subForm.ShowDialog();
            }

            // 再表示
            Redisp();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // 顧客IDの取得
            string cutomerId = CustomerGrid.SelectedRows[0].Cells["Id"].Value.ToString();

            // 削除画面を起動する
            using (UpdateForm subForm = new UpdateForm(MyEnum.UpdateType.Delete, _dbAccess, cutomerId))
            {
                subForm.ShowDialog();
            }

            // 再表示
            Redisp();
        }

        private void CustomerListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // DB切断
            _dbAccess.Disconnect();
        }

        /// <summary>
        /// Customerテーブルデータを再表示する
        /// </summary>
        private void Redisp()
        {
            string sql = "SELECT * FROM Customers ORDER BY Id";
            DataTable customers = _dbAccess.SelectData(sql);
            CustomerGrid.DataSource = customers;
        }

    }
}
