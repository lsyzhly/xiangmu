<%@ Page Language="C#" Inherits="atyht" Debug="true" %>

<html>
  <body>
    <form runat="server">
      <asp:GridView  runat= "server" id="AlGride" AutoGenerateSelectButton="True" OnSelectedIndexChanged="OnSelect" AutoGenerateColumns="True">
      </asp:GridView>
    </form>
  </body>
</html>
