using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data;
public partial class grxx : Page
{
    protected GridView Datagride;
    public void Page_Load(Object sender, EventArgs e)
    {
        datacontrol a = (datacontrol)Session["database"];
        Driver b = (Driver)Session["driver"];
        System.Data.Common.DataAdapter d = a.getUseCar(b.driverid);
        System.Data.DataSet c = new System.Data.DataSet();
        d.Fill(c);
        Datagride.DataSource = c;
        Datagride.DataBind();
    }
}
