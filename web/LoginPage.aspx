<%@ Register TagPrefix="user" TagName="LoginControl" src="LoginControl.ascx" %>
<%@ Page Language="C#" Debug="true" %>

<html>
  <body>
    <h1>Drivers login</h1>
    <hr>
    <form runat="server">
      <user:LoginControl ID="Login" OnLogin="OnLoginUser" BackColor="#ccccff" RunAt="server" />
    </form>
    <hr>
    <h3><asp:Label ID="Output" RunAt="server" /></h3>
  </body>
</html>

<script language="C#" runat="server">
  void OnLoginUser (Object sender, bool e)
  {
      if (e)
      {
          Driver a = (Driver)Session["driver"];
          Output.Text = "Hello, " + a.password;
      }
      else
      {
          Output.Text = "the id or password you input wrong!";
          Login.Name = "";
          Login.Pas = "";
      }
  }
</script>