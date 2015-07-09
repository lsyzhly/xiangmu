<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aclcx.aspx.cs" Inherits="web.WebForm2" %>

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
         .pageword
         {
        text-align: center;
        font-size:large;
        color:black;
         }
        </style>
</head>
<body>
    <form id="form1" runat="server">
     <div style="color:#0094ff" class="word">
        <p class="pageword">查询所有车辆</p>
           <asp:Button  text="查询" OnClick="OnSreach" RunAt="server" />      
    </div>
         <asp:GridView  runat= "server" id="acarGrid"  AutoGenerateColumns="True">
         </asp:GridView>
    </form>
</body>
</html>
