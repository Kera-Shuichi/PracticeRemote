﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex22_ScreenTransition
{
    public partial class Transfer1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void trasferButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("Transfer2.aspx?Test=ABC");
        }
    }
}