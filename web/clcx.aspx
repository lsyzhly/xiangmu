<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clcx.aspx.cs" Inherits="web.clcx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css"> 
         .word
        {
        text-align: center;
        font-size : 3em;
        }
         .pword
         {
        text-align: center;
        font-size : small;
        color:black;
         }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style="color:#0094ff" class="word">
        <p align="center">查询车辆</p>
           <table width="100%"  cellpadding="1" cellspacing="1">
          
           <tr>
               <td><p class="pword"> <asp:TextBox ID="startYear" RunAt="server"/><br>合同开始时间</p></td>
               <td><p class="pword"><asp:TextBox ID="endYear" RunAt="server"/><br>合同结束时间</p></td>
           </tr>
           <asp:Button  text="查询" OnClick="OnSreach" RunAt="server" />
               </table>
    </div>
        <div>
          
       <asp:GridView  runat= "server" id="carGrid" AutoGenerateSelectButton="True" OnSelectedIndexChanged="OnSelect" AutoGenerateColumns="True">
      </asp:GridView>
    <br>
    <asp:Label ID="Output" RunAt="server"/>
</form>
</body>
</html>
