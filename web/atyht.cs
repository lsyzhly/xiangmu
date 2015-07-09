using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class atyht : System.Web.UI.Page
{
    protected GridView AlGride;
    public void Page_Load(Object sender, EventArgs e)
    {
        datacontrol a = (datacontrol)Session["database"];
        System.Data.Common.DataAdapter d = a.getAContract();
        System.Data.DataSet c = new System.Data.DataSet();
        d.Fill(c);
        AlGride.DataSource = c;
        AlGride.DataBind();
    }
    public void OnSelect(object sender, EventArgs e)
    {
        GridViewRow row = AlGride.SelectedRow;
        int start = int.Parse(row.Cells[3].Text);
        int end = int.Parse(row.Cells[4].Text);
        String driverid = row.Cells[2].Text;
        String carid = row.Cells[1].Text;
        datacontrol b = (datacontrol)Session["database"];
        if (b.isCarContract(carid, start, end))
        {
            Response.Write("<script>alert('car not free£¡');</script>");
            return;
        }
        if (b.isDriverContract(driverid, start, end))
        {
            Response.Write("<script>alert('driver not free£¡');</script>");
            return;
        }
        b.updateContractIsagree(carid,driverid,start,true);
    }
}