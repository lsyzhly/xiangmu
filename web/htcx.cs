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
        if (StateList.SelectedItem.Text == "��ǰ��ͬ")
        {
            c=b.getContract(d.driverid);
        }
        else if (StateList.SelectedItem.Text == "��Ч��ͬ")
        {
            c=b.getOkContract(d.driverid);
        }
        else if (StateList.SelectedItem.Text == "���к�ͬ")
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
            Response.Write("<script>alert('û�е�ǰ��ͬ');</script>");
        }
    }
}
