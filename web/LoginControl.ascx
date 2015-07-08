<%@ Control Inherits="UserLogin"%>

<table id="LoginTable" cellpadding="4" runat="server">
  <tr>
    <td>User Name:</td>
    <td><asp:TextBox ID="UserName" RunAt="server" /></td>
  </tr>
  <tr>	
    <td>Password:</td>
    <td><asp:TextBox ID="Password" TextMode="password"
      RunAt="server" /></td>
  </tr>
  <tr>
    <td></td>
    <td><asp:LinkButton Text="Log In" OnClick="OnLoginButtonClicked"
      RunAt="server" /></td>
  </tr>
</table>