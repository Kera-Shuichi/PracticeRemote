using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Text;
//ページャー付けたもの
namespace Pr25_DataBind
{
    public partial class Practice2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //Makerテーブルのデータ取得
                DataTable dtMaker = GetMasterData("Maker");

                //ListBoxにバインド
                ListBox1.DataSource = dtMaker;
                ListBox1.DataTextField = "Name";
                ListBox1.DataValueField = "Id";
                ListBox1.DataBind();

                //Categoryテーブルのデータ取得
                DataTable dtCategory = GetMasterData("Category");

                //DropDownListにバインド
                DropDownList1.DataSource = dtCategory;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();

                //先頭にブランク追加
                ListBox1.Items.Insert(0, new ListItem("", ""));
                DropDownList1.Items.Insert(0, new ListItem("", ""));

                //Productテーブルのデータ取得
                DataTable dtProduct = GetProductData();
                // ページインデックスで使用するため、セッションにて保持
                Session["ProductData"] = dtProduct;
                GridView1.DataSource = Session["ProductData"];
                GridView1.DataBind();
            }

        }

        //メーカー、カテゴリー選択変更時
        protected void SelectedIndexChanged(object sender, EventArgs e)
        {
            //メーカの選択値を取得
            string strMaker = ListBox1.SelectedValue;
            //カテゴリーの選択値を取得
            string strCategory = DropDownList1.SelectedValue;

            //Productテーブルのデータ取得
            DataTable dtProduct = GetProductData(strMaker, strCategory);
            Session["ProductData"] = dtProduct;

            //最初のページを表示
            GridView1.PageIndex = 0;

            //GridViewにバインド
            GridView1.DataSource = Session["ProductData"];
            GridView1.DataBind();

        }

        private DataTable GetProductData(string MakerId = "",
                                         string CategoryId = "")
        {
            DBAccess dba;
            DataTable dtProduct;

            //接続文字列取得
            string connection =
                 ConfigurationManager.ConnectionStrings["conStr"]
                                                    .ToString();
            //DB接続
            dba = new DBAccess(connection);
            dba.Connect();

            //SQL文作成
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("  Product.*");
            sb.AppendLine(" ,Maker.Name AS MakerName");
            sb.AppendLine(" ,Category.Name AS CategoryName");
            sb.AppendLine("FROM");
            sb.AppendLine("  Product");
            sb.AppendLine("    LEFT OUTER JOIN Maker ");
            sb.AppendLine("     ON Product.Maker = Maker.Id ");
            sb.AppendLine("    LEFT OUTER JOIN Category ");
            sb.AppendLine("     ON Product.Category = Category.Id ");
            sb.AppendLine("WHERE ");
            sb.AppendLine("     DelFlg = 0");
            //Maker条件追加
            if (MakerId != "")
            {
                sb.AppendLine(" AND Maker = '" + MakerId + "'");
            }
            //Category条件追加
            if (CategoryId != "")
            {
                sb.AppendLine(" AND Category = '" + CategoryId + "'");
            }

            //Customersテーブルのデータ取得
            dtProduct = dba.SelectData(sb.ToString());

            //DB切断
            dba.Disconnect();

            //取得データを返す
            return dtProduct;
        }

        private DataTable GetMasterData(string tblName)
        {
            DBAccess dba;
            DataTable dtMaster;

            //接続文字列取得
            string connection = ConfigurationManager.
                     ConnectionStrings["conStr"].ToString();

            //DB接続
            dba = new DBAccess(connection);
            dba.Connect();

            //SQL文作成
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT * FROM {0}", tblName);

            //マスタテーブルのデータ取得
            dtMaster = dba.SelectData(sb.ToString());

            //DB切断
            dba.Disconnect();

            //取得データを返す
            return dtMaster;
        }

        // グリッドビューのページが選択された時
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // 新しいページインデックスをGridViewに設定
            GridView1.PageIndex = e.NewPageIndex;

            // セッションに入れていたプロダクトデータを使用
            GridView1.DataSource = Session["ProductData"];
            GridView1.DataBind();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "NextPage")
            {
                //選択行のインデックス取得
                int index = int.Parse(e.CommandArgument.ToString());

                Session["ProductInfo"]
                    = string.Format("{0}:{1}",
                            GridView1.Rows[index].Cells[0].Text,
                            GridView1.Rows[index].Cells[1].Text);

                Response.Redirect("Practice3.aspx");
            }
        }
    }
}