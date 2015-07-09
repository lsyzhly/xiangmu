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
   
    public partial class clcx : System.Web.UI.Page
    {
        int myStrat;
        int useYear;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void   OnSreach (Object sender, EventArgs e)
  {
      DataAdapter c;
      String Year;
      myStrat=int.Parse(this.startYear.Text);
      Year=this.endYear.Text;
      useYear=int.Parse(Year);
           //数据库绑定 


      DataSet b = new DataSet();
      datacontrol a = (datacontrol)Session["database"];
      c = a.avaliableCar(myStrat, useYear);
      try 
      {
          c.Fill(b);
          this.carGrid.DataSource = b;
          this.carGrid.DataBind();
      }
     catch(System.Data.SQLite.SQLiteException)
      {
          Response.Write("<script>alert('没有合适车辆');</script>");
      }
        }

        public void OnSelect(object sender, EventArgs e)
        {
            String Year;
            myStrat = int.Parse(this.startYear.Text);
            Year = this.endYear.Text;
            useYear = int.Parse(Year);
          datacontrol a=(datacontrol)Session["database"];
          GridViewRow row = carGrid.SelectedRow;
          String driverid = ((Driver)Session["driver"]).driverid;
          a.insert(row.Cells[1].Text,driverid,myStrat,useYear,false,true);
      }
    }
}
