<%@ Page Language="C#"  Debug="true" CodeBehind="zcym.cs" Inherits="zcym"  %>

<html>
  <body>
    <form runat="server">
      <table>
            <tr>
                <td>驾驶员ID：</td>
                <td><asp:TextBox ID="driverid" RunAt="server" /></td>
            </tr>
            <tr>
                <td>身份证号：</td>
                <td><asp:TextBox ID="personid" RunAt="server" /></td>
            </tr>
            <tr>
                <td>名字：</td>
                <td><asp:TextBox ID="name" RunAt="server" /></td>
            </tr>
           <tr><td>性别：</td>
               <td>
          <asp:DropDownList ID="StateList"  AutoPostBack="True" RunAt="server">
          <asp:ListItem Text="Man" RunAt="server" />
           <asp:ListItem Text="Woman" RunAt="server" />
         </asp:DropDownList></td>
            </tr>
           <tr>
                <td>生日：</td>
                <td><asp:TextBox ID="birthday" RunAt="server" /></td>
            </tr>
          <tr>
                <td>密码：</td>
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
