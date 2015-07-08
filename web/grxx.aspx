<%@ Register TagPrefix="user" TagName="DriverControl" src="Driver.ascx"%>
<%@ Page Language="C#" Debug="true" %>

<html>
  <body>
    <h1>Drivers login</h1>
    <hr>
    <form runat="server">
      <user:DriverControl ID="Login" Onsumit="OnSubmit" RunAt="server" />
    </form>
    <hr>
    <h3><asp:Label ID="Output" RunAt="server" /></h3>
  </body>
</html>
