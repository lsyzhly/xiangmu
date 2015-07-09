<%@ Register TagPrefix="user" TagName="DriverControl" src="Driver.ascx"%>
<%@ Page Language="C#" Inherits="grxx" Debug="true" %>

<html>
  <body>
    <form runat="server">
      <table>
        <tr>
            <td>peronal information</td>
            <td>car infomation</td>
        </tr>
        <tr>
          <td>
            <user:DriverControl ID="Login" Onsumit="OnSubmit" RunAt="server" />
          </td>
          <td>
            <asp:DataGrid runat= "server" id="Datagride" AutoGenerateColumns="True">
            </asp:DataGrid>
          </td>
        </tr>
      </table>
    </form>
  </body>
</html>