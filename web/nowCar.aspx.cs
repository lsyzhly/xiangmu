using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;

namespace web
{
    public partial class nowCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void OnSreach(object sender, EventArgs e)
        {
            DataAdapter c;
            //数据库绑定 


            DataSet b = new DataSet();
            datacontrol a = (datacontrol)Session["database"];
            c = a.getContract();
            try
            {
                c.Fill(b);
                this.acarGrid.DataSource = b;
                this.acarGrid.DataBind();
            }
            catch (System.Data.SQLite.SQLiteException)
            {
                Response.Write("<script>alert('没有执行合同的车辆');</script>");
            }
        }
    }
}