using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;
public partial class htcx : Page
{
    protected DropDownList StateList;
    protected DataGrid Contractgride;
    public void OnChange(Object sender, EventArgs e)
    {
        DataSet a=new DataSet();
        DataAdapter c;
        datacontrol b = (datacontrol)Session["database"];
        Driver d=(Driver)Session["driver"];
        if (StateList.SelectedItem.Text == "当前合同")
        {
            c=b.getContract(d.driverid);
        }
        else if (StateList.SelectedItem.Text == "有效合同")
        {
            c=b.getOkContract(d.driverid);
        }
        else if (StateList.SelectedItem.Text == "所有合同")
        {
            c=b.getAllContract(d.driverid);
        }else{
            c=null;
        }
        try
        {
            c.Fill(a);
            Contractgride.DataSource = a;
            Contractgride.DataBind();
        }
        catch (System.Data.SQLite.SQLiteException)
        {
            Response.Write("<script>alert('没有当前合同');</script>");
        }
    }
}
