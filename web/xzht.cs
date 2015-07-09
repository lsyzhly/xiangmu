using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class xzht : System.Web.UI.Page
{
    protected TextBox carid;
    protected TextBox startText;
    protected TextBox endText;
    protected void OnAddContract(object sender, EventArgs e)
    {
        Driver a=(Driver)Session["driver"];
        datacontrol b = (datacontrol)Session["database"];
        String id = carid.Text;
        int start=int.Parse(startText.Text);
        int end=int.Parse(endText.Text);
        if (!b.isCarContract(id,start,end))
        {
            System.Windows.Forms.MessageBox.Show("car not free");
            return;
        }
        if (!b.isDriverContract(a.driverid, start, end))
        {
            System.Windows.Forms.MessageBox.Show("driver not free");
            return;
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("success");
        }
        b.insert(carid.Text,a.driverid,start,end,false,true);
    }
}