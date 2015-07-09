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
div#container{width:100%;height:650px;}
div#welcom {width:100%;text-align:right;height:10%;}
div#header1 {width:33%;float:left;text-align:center;height:50px;}
div#header2 {width:33%;float:left;text-align:center;height:50px;}
div#header3 {width:34%;float:left;text-align:center;height:50px;}
div#menu {background-color:#ffff99;height:600px;width:20%;float:left;}
div#content {background-color:#EEEEEE;height:600px;width:80%;float:left;}
div#footer {background-color:#99bbbb;clear:both;text-align:center;}
h1 {margin-bottom:0;}
h2 {margin-bottom:0;font-size:18px;}
h3 {margin-bottom:0;font-size:14px;text-align:center;}
ul {margin:0;}
li {list-style:none;}     </style>
</head>
<body>
    <form id="form1" runat="server">

           <table width="100%"  cellpadding="1" cellspacing="1">
          
           <tr>
               <td><p class="pword"> <asp:TextBox ID="startYear" RunAt="server"/><br>合同开始时间</p></td>
               <td><p class="pword"><asp:TextBox ID="endYear" RunAt="server"/><br>合同结束时间</p></td>
           </tr>
           <tr><td></td><td><asp:Button  text="查询" OnClick="OnSreach" RunAt="server" /></td></tr>
               </table>
          
       <asp:GridView  runat= "server" id="carGrid" AutoGenerateSelectButton="True" OnSelectedIndexChanged="OnSelect" AutoGenerateColumns="True">
      </asp:GridView>
    <br>
    <asp:Label ID="Output" RunAt="server"/>
    </form>
</body>
</html>
