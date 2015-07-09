<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newCar.aspx.cs" Inherits="web.newCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>   
        <td>thecarid  <asp:TextBox ID="carid" runat="server"/></td>  
        <td>CarYear      <asp:TextBox ID="carYear" runat="server"/></td>
         </tr>
        <tr>
        <td>avaliable<asp:TextBox ID="avaliable" runat="server"/>true可用，false不可用</td>
        <td>insurance<asp:TextBox ID="insurance" runat="server"/>true可用，false不可用</td>
            </tr>
        <tr>
       <td>yearcheck<asp:TextBox ID="yearcheck" runat="server"/>true可用，false不可用</td>>
            </tr>
    </table>
        <asp:Button  text="新增" OnClick="OnAdd" RunAt="server" />
    </div>
    </form>
</body>
</html>
