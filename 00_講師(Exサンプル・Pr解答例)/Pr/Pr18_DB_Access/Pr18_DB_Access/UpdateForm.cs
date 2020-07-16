using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr18_DB_Access
{
    public partial class UpdateForm : Form
    {
        private MyEnum.UpdateType _type;    //更新タイプ
        private DBAccess _dbAccess;         //DB接続オブジェクト
        private string _customerId;         //顧客ID

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dbAccess"></param>
        /// <param name="customerId"></param>
        public UpdateForm(MyEnum.UpdateType type, DBAccess dbAccess, string customerId = "")
        {
            InitializeComponent();

            //引数を各フィールドに設定
            _type = type;
            _dbAccess = dbAccess;
            _customerId = customerId;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // 更新タイプに応じて画面表示
            switch (_type)
            {
                case MyEnum.UpdateType.Insert:
                    this.Text = "新規登録画面";
                    ExecButton.Text = "登録";
                    break;
                case MyEnum.UpdateType.Update:
                    this.Text = "更新画面";
                    ExecButton.Text = "更新";
                    IDInput.Enabled = false;

                    // 顧客情報を表示
                    SetData();

                    break;
                case MyEnum.UpdateType.Delete:
                    this.Text = "削除画面";
                    ExecButton.Text = "削除";
                    IDInput.Enabled = false;
                    CustomerNameInput.Enabled = false;
                    ContactNameInput.Enabled = false;
                    PhoneNumberInput.Enabled = false;

                    // 顧客情報を表示
                    SetData();

                    break;
            }

        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            // 入力値チェック
            if(_type == MyEnum.UpdateType.Insert ||
                _type == MyEnum.UpdateType.Update)
            {
                // 必須項目に未入力箇所があれば処理を中断する
                if(IDInput.Text == string.Empty ||
                    CustomerNameInput.Text == string.Empty)
                {
                    MessageBox.Show("未入力項目が存在します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            string sql = string.Empty;
            switch (_type)
            {
                case MyEnum.UpdateType.Insert:
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("INSERT INTO ");
                    sb.AppendLine(" Customers ");
                    sb.AppendLine("VALUES( ");
                    sb.AppendLine(" " + IDInput.Text + ", ");
                    sb.AppendLine(" N'" + CustomerNameInput.Text + "', ");
                    sb.AppendLine(" N'" + ContactNameInput.Text + "', ");
                    sb.AppendLine(" N'" + PhoneNumberInput.Text + "')");

                    sql = sb.ToString();
                    break;
                case MyEnum.UpdateType.Update:
                    sql = "UPDATE Customers SET CustomerName = N'" +
                           CustomerNameInput.Text + "', ContactName = N'" +
                           ContactNameInput.Text + "', PhoneNumber = '" +
                           PhoneNumberInput.Text + "' WHERE Id = '" +
                           _customerId + "'";
                    break;
                case MyEnum.UpdateType.Delete:
                    sql = "DELETE FROM Customers  WHERE Id = '" + _customerId + "'";
                    break;
            }

            try
            {
                _dbAccess.BeginTransaction();   // トランザクションの開始
                _dbAccess.Execute(sql);    // SQL実行
                _dbAccess.CommitTransaction();  // コミット
            }
            catch(SqlException ex)
            {
                string errorMessage = string.Empty;
                _dbAccess.RollbackTransaction();    // ロールバック

                if(ex.Number == 2627)
                {
                    errorMessage = "IDが既に登録されています。";
                }
                else
                {
                    errorMessage = "SQL実行時にエラーが発生しました。";

                    MessageBox.Show(errorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 画面を閉じる
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // 画面を閉じる
            this.Close();
        }

        /// <summary>
        /// 顧客情報表示処理
        /// </summary>
        private void SetData()
        {
            string sql = "SELECT * FROM Customers " +
                " WHERE Id = " + _customerId;

            DataTable customer = _dbAccess.SelectData(sql);

            IDInput.Text = _customerId;
            CustomerNameInput.Text = customer.Rows[0].Field<string>("CustomerName");
            ContactNameInput.Text = customer.Rows[0].Field<string>("ContactName");
            PhoneNumberInput.Text = customer.Rows[0].Field<string>("PhoneNumber");
        }

        
    }
}
