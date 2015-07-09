<%@ Page Language="C#" Inherits="htcx" Debug="true" %>

<html>
<head>
    <form runat="server">
      <asp:DropDownList ID="StateList"  OnSelectedIndexChanged="OnChange" AutoPostBack="True" RunAt="server">
        <asp:ListItem Text="当前合同" RunAt="server" />
        <asp:ListItem Text="有效合同" RunAt="server" />
        <asp:ListItem Text="所有合同" RunAt="server" />
      </asp:DropDownList>
      <asp:GridView  runat= "server" id="Contractgride" AutoGenerateColumns="True">
      </asp:GridView>
    </form>
  </body>
</html>
