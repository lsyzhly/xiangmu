<%@ Page Language="C#"  Debug="true" CodeBehind="zcym.cs" Inherits="zcym"  %>

<html>
  <body>
    <form runat="server">
      <table>
            <tr>
                <td>��ʻԱID��</td>
                <td><asp:TextBox ID="driverid" RunAt="server" /></td>
            </tr>
            <tr>
                <td>���֤�ţ�</td>
                <td><asp:TextBox ID="personid" RunAt="server" /></td>
            </tr>
            <tr>
                <td>���֣�</td>
                <td><asp:TextBox ID="name" RunAt="server" /></td>
            </tr>
           <tr><td>�Ա�</td>
               <td>
          <asp:DropDownList ID="StateList"  AutoPostBack="True" RunAt="server">
          <asp:ListItem Text="Man" RunAt="server" />
           <asp:ListItem Text="Woman" RunAt="server" />
         </asp:DropDownList></td>
            </tr>
           <tr>
                <td>���գ�</td>
                <td><asp:TextBox ID="birthday" RunAt="server" /></td>
            </tr>
          <tr>
                <td>���룺</td>
                <td><asp:TextBox ID="password" RunAt="server" /></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:LinkButton Text="Submit" OnClick="OnAddDriver" RunAt="server" />
                </td>
            </tr>
        </table>
    </form>
  </body>
</html>
