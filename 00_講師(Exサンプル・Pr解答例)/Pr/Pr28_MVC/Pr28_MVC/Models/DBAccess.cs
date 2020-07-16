using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Pr28_MVC.Models
{
    public class DBAccess
    {
        /// <summary>
        /// 接続文字列
        /// </summary>
        private string _strConnection = string.Empty;

        /// <summary>
        /// SQLコネクション
        /// </summary>
        private SqlConnection _con = null;

        /// <summary>
        /// トランザクション・オブジェクト
        /// </summary>
        /// <remarks></remarks>
        private SqlTransaction _trn = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="strConnection">DB接続文字列</param>
        /// <remarks></remarks>
        public DBAccess(string strConnection)
        {
            _strConnection = strConnection;
        }

        /// <summary>
        /// DB接続を行う
        /// </summary>
        /// <remarks></remarks>
        public void Connect()
        {
            try
            {
                if (_con == null)
                {
                    _con = new SqlConnection();
                }

                _con.ConnectionString = _strConnection;

                _con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// DB切断を行う
        /// </summary>
        public void Disconnect()
        {
            try
            {
                _con.Close();
                _con.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SQL(SELECT)の実行
        /// </summary>
        /// <param name="sql">SQL(SELECT)文</param>
        /// <returns>SQL取得結果</returns>
        /// <remarks></remarks>
        public DataTable SelectData(String sql)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, _con, _trn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dt);
                adapter.Dispose();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        /// <summary>
        /// SQL(INSERT,UPDATE,DELETE)の実行
        /// </summary>
        /// <param name="sql">SQL(INSERT,UPDATE,DELETE)文</param>
        /// <returns>処理件数</returns>
        /// <remarks></remarks>
        public int Execute(String sql)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = null;

            try
            {
                sqlCommand = new SqlCommand(sql, _con, _trn);
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// トランザクションを開始する
        /// </summary>
        /// <remarks></remarks>
        public void BeginTransaction()
        {
            try
            {
                _trn = _con.BeginTransaction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// コミットを行う
        /// </summary>
        /// <remarks></remarks>
        public void CommitTransaction()
        {
            try
            {
                if (_trn != null)
                {
                    _trn.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _trn = null;
            }
        }

        /// <summary>
        /// ロールバックを行う
        /// </summary>
        /// <remarks></remarks>
        public void RollbackTransaction()
        {
            try
            {
                if (_trn != null)
                {
                    _trn.Rollback();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _trn = null;
            }
        }
    }
}