using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public class LoginEventArgs
{
    private bool LoginValid;

    public LoginEventArgs (bool IsValid)
    {
        LoginValid = IsValid;
    }

    public bool IsValid
    {
        get { return LoginValid; }
    }
}

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
        LoginEventArgs e);

    public event LoginEventHandler Login;

    public void OnLoginButtonClicked (Object sender, EventArgs e)
    {
        if (Login != null) {
            bool IsValid = (Name.ToLower () == "asd" &&
                Pas == "qwe");
            Login (this, new LoginEventArgs (IsValid));
        }
    }
}