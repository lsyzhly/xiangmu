<%@ Control Inherits="UserLogin"%>

<table id="LoginTable" cellpadding="4" runat="server">
  <tr>
    <td>id:</td>
    <td><asp:TextBox ID="UserName" RunAt="server" /></td>
  </tr>
  <tr>	
    <td>Password:</td>
    <td><asp:TextBox ID="Password" TextMode="password"
      RunAt="server" /></td>
  </tr>
  <tr>
    <td>
        <asp:DropDownList ID="Chose" AutoPostBack="True" RunAt="server">
        <asp:ListItem Text="˾����¼" RunAt="server" />
        <asp:ListItem Text="����Ա��¼" RunAt="server" />
      </asp:DropDownList>
    </td>
    <td><asp:LinkButton Text="Log In" OnClick="OnLoginButtonClicked"
      RunAt="server" /></td>
  </tr>
</table>