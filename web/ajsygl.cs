using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;

public partial class ajsygl : System.Web.UI.Page
{
    protected GridView jsygride;
    public void Page_Load(Object sender, EventArgs e)
    {
        DataSet a = new DataSet();
        DataAdapter c;
        datacontrol b = (datacontrol)Session["database"];
        c = b.getAllDriver();
        try
        {
            c.Fill(a);
            jsygride.DataSource = a;
            jsygride.DataBind();
        }
        catch (System.Data.SQLite.SQLiteException)
        {
            Response.Write("<script>alert('û�м�ʻԱ');</script>");
        }
    }
}