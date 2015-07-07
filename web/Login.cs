using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public class UserLogin : UserControl
{
    protected HtmlTable LoginTable;
    protected TextBox UserName;
    protected TextBox Password;

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

    public delegate void LoginEventHandler (Object sender,
        String e);

    public event LoginEventHandler Login;

    public void OnLoginButtonClicked (Object sender, EventArgs e)
    {
        if (Login != null) {
			Driver a=new datacontrol("asd.data").getDriver(Name);
            if(a!=null && a.password==Pas) Login (this,a,password);
            else Login (this, null);
        }
    }
}