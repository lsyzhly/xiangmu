<%@ Register TagPrefix="user" TagName="DriverControl" src="Driver.ascx"%>
<%@ Page Language="C#" Inherits="grxx" Debug="true" %>

<html>
<head>
    <form runat="server">
      <table>
        <tr>
            <td>peronal information</td>
            <td>car infomation</td>
        </tr>
        <tr>
          <td>
            <user:DriverControl ID="Login"  RunAt="server" />
          </td>
          <td>
            <asp:GridView  runat= "server" id="Datagride" AutoGenerateColumns="True">
            </asp:GridView>
          </td>
        </tr>
      </table>
    </form>
  </body>
</html>
