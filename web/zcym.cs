using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class zcym : System.Web.UI.Page
{
    protected TextBox driverid;
    protected TextBox personid;
    protected TextBox name;
    protected TextBox sex;
    protected TextBox password;
    protected TextBox birthday;
    protected DropDownList StateList;
    protected void OnAddDriver(object sender, EventArgs e)
    {
        datacontrol b = (datacontrol)Session["database"];
        String did = driverid.Text;
        String pid = personid.Text;
        String n = name.Text;
        String bir = birthday.Text;
        String p = password.Text;
        bool s;
        if (StateList.Text == "Man")
            s = true;
        else
            s = false;
        try
        {
            b.insert(did, pid, s, n, bir, p);
        }
        catch (System.Data.SQLite.SQLiteException)
        {
            Response.Write("<script>alert('注册失败');location.href='zcym.aspx';</script>");
            return;


        }
        Response.Write("<script>alert('注册成功');location.href='LoginPage.aspx';</script>");
        return;

    }        
}