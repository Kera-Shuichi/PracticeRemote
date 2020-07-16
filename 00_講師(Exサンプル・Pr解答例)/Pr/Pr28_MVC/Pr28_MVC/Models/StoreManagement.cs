using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Text;

namespace Pr28_MVC.Models
{
    public class StoreManagement
    {
        /// <summary>DBAccessクラス変数</summary>
        DBAccess dba;

        public StoreManagement()
        {
            // DB接続文字列の取得
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            // DBAccessクラスのインスタンス化
            dba = new DBAccess(conStr);
        }

        /// <summary>
        /// INSERT処理
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="customerName">会社名</param>
        /// <param name="contactName">担当者名</param>
        /// <param name="phoneNumber">電話番号</param>
        /// <returns></returns>
        public string InsertCustomer(string id, string customerName, string contactName, string phoneNumber)
        {
            // INSERT実行
            string resultMessage = ExcuteInsert(id, customerName, contactName, phoneNumber);

            // 実行結果確認（resultMessageが空なら成功）
            if (resultMessage != string.Empty)
            {
                return resultMessage;
            }

            // 登録顧客数取得
            DataTable dt = GetCustomersCount();

            // 文字列に変換
            string customerCount = dt.Rows[0].ItemArray[0].ToString();

            // 返却文字列を成型
            resultMessage = "ID: " + id;
            resultMessage += "<br>CustomerName: " + customerName;
            resultMessage += "<br>ContactName: " + contactName;
            resultMessage += "<br>PhoneNumber: " + phoneNumber;
            resultMessage += "<br>登録成功";
            resultMessage += "<br><br>これで登録顧客数は" + customerCount + "人になりました。";

            return resultMessage;
        }

        /// <summary>
        /// INSERT実行処理
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="customerName">会社名</param>
        /// <param name="contactName">担当者名</param>
        /// <param name="phoneNumber">電話番号</param>
        /// <returns></returns>
        private string ExcuteInsert(string id, string customerName, string contactName, string phoneNumber)
        {
            // DB接続
            dba.Connect();

            // SQL文作成
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INSERT INTO");
            sb.AppendLine("    Customers");
            sb.AppendLine("Values(");
            sb.AppendFormat("    {0}", id).AppendLine();
            sb.AppendFormat("   ,N'{0}'", customerName).AppendLine();
            sb.AppendFormat("   ,N'{0}'", contactName).AppendLine();
            sb.AppendFormat("   ,'{0}')", phoneNumber).AppendLine();

            // DB操作
            try
            {
                dba.BeginTransaction();    // トランザクション
                dba.Execute(sb.ToString());　　　　　// SQL実行
                dba.CommitTransaction();   // コミット                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                // DB接続切断
                dba.Disconnect();
            }

            return string.Empty;
        }

        /// <summary>
        /// 登録顧客数取得処理
        /// </summary>
        /// <returns></returns>
        private DataTable GetCustomersCount()
        {
            // DB接続
            dba.Connect();

            // SQL文作成
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT ");
            sql.AppendLine("COUNT(*) ");
            sql.AppendLine("FROM ");
            sql.AppendLine("Customers ");

            // データ取得
            DataTable result = dba.SelectData(sql.ToString());

            // DB接続解除
            dba.Disconnect();

            return result;
        }
    }
}