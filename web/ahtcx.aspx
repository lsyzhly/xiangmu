<%@ Page Language="C#" Inherits="htcx" Debug="true" %>

<html>
  <body>
    <form runat="server">
      <asp:DropDownList ID="StateList"  OnSelectedIndexChanged="OnAChange" AutoPostBack="True" RunAt="server">
        <asp:ListItem Text="��ǰ��ͬ" RunAt="server" />
        <asp:ListItem Text="��Ч��ͬ" RunAt="server" />
        <asp:ListItem Text="���к�ͬ" RunAt="server" />
      </asp:DropDownList>
      <asp:GridView  runat= "server" id="Contractgride" AutoGenerateColumns="True">
      </asp:GridView>
    </form>
  </body>
</html>
