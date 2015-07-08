<%@ Control Inherits="DriverP"%>

<table id="Drivertable" cellpadding="4" runat="server">
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
    <td><asp:Label ID="Sex" RunAt="server" /></td>
  </tr>
  <tr>
    <td>name</td>
    <td><asp:Label ID="name" RunAt="server" /></td>
    <td><asp:TextBox ID="namet" RunAt="server" /></td>
    <td><asp:Button Text="change"  OnClick="OnName" RunAt="server" /></td>
  </tr>
  <tr>
    <td>birthday</td>
    <td><asp:Label ID="birthday" RunAt="server" /></td>
  </tr><tr>
    <td>password</td>
    <td><asp:Label ID="password" RunAt="server"/></td>
    <td><asp:TextBox ID="passwordt" RunAt="server" /></td>
    <td><asp:Button Text="change"  OnClick="OnPassword" RunAt="server" /></td>
  </tr>
</table>