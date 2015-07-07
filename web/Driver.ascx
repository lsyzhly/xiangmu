<%@ Control Inherits="DriverP" src="Login.cs" %>

<table id="DriverP" cellpadding="4" runat="server">
  <tr>
    <td>Driverid</td>
    <td><asp:Label ID="Driverid" RunAt="server" /></td>
  </tr>
  <tr>	
    <td>Personelid</td>
    <td><asp:Label ID="Personelid" RunAt="server" /></td>
  </tr>
  <tr>
    <td>Sex</td>
    <td><asp:TextBox ID="Sex" RunAt="server" /></td>
  </tr>
  <tr>
    <td>name</td>
    <td><asp:TextBox ID="name" RunAt="server" /></td>
  </tr>
  <tr>
    <td>birthday</td>
    <td><asp:Label ID="birthday" RunAt="server" /></td>
  </tr><tr>
    <td>password</td>
    <td><asp:TextBox ID="password" RunAt="server" TextMode="password"/></td>
  </tr>
  <tr>
    <td></td>
    <td><asp:LinkButton Text="save" OnClick="OnSaveDriver"
      RunAt="server" /></td>
  </tr>
</table>