﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TextBox name;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.name.Text = ((Driver)Session["driver"]).password;   
        }
    }
}