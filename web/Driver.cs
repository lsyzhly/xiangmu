using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data;
public class DriverP : UserControl
{
	protected Label Driverid;
	protected Label Personelid;
	protected Label Sex;
    protected Label name;
    protected TextBox namet;
	protected Label birthday;
    protected TextBox passwordt;
    protected Label password;
    public void OnName(Object sender, EventArgs e)
    {
        Driver dr = (Driver)Session["driver"];
        dr.name = namet.Text;
        ((datacontrol)Session["database"]).updateDriverName(((Driver)Session["driver"]).driverid, dr.name);
	}
    public void OnPassword(Object sender, EventArgs e)
    {
        Driver dr = (Driver)Session["driver"];
        dr.password = passwordt.Text;
        ((datacontrol)Session["database"]).updateDriverPassword(((Driver)Session["driver"]).driverid, dr.password);
    }
    public void Page_Load(Object sender, EventArgs e)
    {
        Driverid.Text = ((Driver)Session["driver"]).driverid;
        Personelid.Text = ((Driver)Session["driver"]).personid;
        Sex.Text = ((Driver)Session["driver"]).sex?"man":"weman";
        name.Text = ((Driver)Session["driver"]).name;
        birthday.Text = ((Driver)Session["driver"]).birthday;
        password.Text = ((Driver)Session["driver"]).password;
    }
}