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
    public partial class newCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void OnAdd(object sender, EventArgs e)
        {
            string theCarid=this.carid.Text;
            int theCarYear=int.Parse(this.carYear.Text);
            bool theAvaliable = Convert.ToBoolean(this.avaliable.Text); 
            bool theInsurance =Convert.ToBoolean(this.avaliable.Text);
            bool theYearCheck=Convert.ToBoolean(this.avaliable.Text);
            datacontrol a = (datacontrol)Session["database"];
            a.insert(theCarid,theCarYear,theAvaliable,theInsurance,theYearCheck);
            Response.Write("<script>alert('添加完成');</script>");
        }
    }
}