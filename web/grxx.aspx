<%@ Register TagPrefix="user" TagName="DriverControl" src="Driver.ascx"%>
<%@ Page Language="C#" Debug="true" %>

<html>
  <body>
    <h1>Drivers Information</h1>
    <form runat="server">
      <user:DriverControl ID="Login" Onsumit="OnSubmit" RunAt="server" />
    </form>
    <asp:ListBox ID="CarList" RunAt="server" />
  </body>
</html>
