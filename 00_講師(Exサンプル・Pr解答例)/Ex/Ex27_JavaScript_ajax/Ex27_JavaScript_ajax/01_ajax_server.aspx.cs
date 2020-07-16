using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex27_JavaScript_ajax
{
    public partial class _01_ajax_server : System.Web.UI.Page
    {
        /// <summary>
        /// 現在日時のテキスト
        /// </summary>
        protected string NowText { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.NowText = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}