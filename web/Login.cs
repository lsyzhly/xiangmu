using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public class UserLogin : UserControl
{
    protected HtmlTable LoginTable;
    protected TextBox UserName;
    protected TextBox Password;
    protected DropDownList Chose;
    public string BackColor
    {
        get { return LoginTable.BgColor; }
        set { LoginTable.BgColor = value; }
    }
 
    public string Name
    {
        get { return UserName.Text; }
        set { UserName.Text = value; }
    }
 
    public string Pas
    {
        get { return Password.Text; }
        set { Password.Text = value; }
    }

    public delegate void LoginEventHandler (Object sender);

    public event LoginEventHandler Login;

    public void OnLoginButtonClicked (Object sender, EventArgs e)
    {
        if (Chose.SelectedIndex == 0) { 
            Driver a;
            if (Login != null)
            {
                if (Session["database"] == null)
                {
                    Session["database"] = new datacontrol("D:\\asd.data");
                }
                a = ((datacontrol)Session["database"]).getDriver(Name);
                if (a != null && a.password == Pas)
                {
                    Session["driver"] = a;

                    Response.Write("<script>alert('sucessful');location.href='lsyztcz.aspx';</script>");

                }
                else Login(this);
            }
        }
        else if (Chose.SelectedIndex == 1)
        {
            String password;
            if (Session["database"] == null)
            {
                Session["database"] = new datacontrol("D:\\asd.data");
            }
            String a;
            a = ((datacontrol)Session["database"]).getAdminPassword(Name);
            if(a!=null && a==Pas){
                Response.Write("<script>alert('sucessful');location.href='ahtcx.aspx';</script>");
            }
            else
            {
                Login(this);
            }
        }
    }
}