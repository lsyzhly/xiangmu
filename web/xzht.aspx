<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xzht.cs" Inherits="xzht" %>

<!DOCTYPE html>

<html>
<body>
    <form runat="server">
        <table>
            <tr>
                <td>车辆id</td>
                <td><asp:TextBox ID="carid" RunAt="server" /></td>
            </tr>
            <tr>
                <td>开始时间</td>
                <td><asp:TextBox ID="startText" RunAt="server" /></td>
            </tr>
            <tr>
                <td>结束时间</td>
                <td><asp:TextBox ID="endText" RunAt="server" /></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:LinkButton Text="Log In" OnClick="OnAddContract" RunAt="server" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>