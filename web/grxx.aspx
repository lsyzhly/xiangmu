<%@ Register TagPrefix="user" TagName="DriverControl" src="Driver.ascx"%>
<%@ Page Language="C#" Inherits="grxx" Debug="true" %>

<html>
<head>
<style type="text/css">
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
li {list-style:none;}  
</style>
</head>

  <body>
   <div id="container">

<div id="header1">
<h2>  <a href="htcx.aspx">合同操作</a></h2>
</div>

<div id="header2">
<h2><a href="clcx.aspx" >车辆查询</a></h2>
</div>

<div id="header3">
<h2><a href="grxx.aspx">个人信息</a></h2>
</div>
<div id="menu">
<h2>Menu</h2>
<h3 >查询车辆</h3>
</div>
<div id="content">
    <form runat="server">
      <table>
        <tr>
            <td>peronal information</td>
            <td>car infomation</td>
        </tr>
        <tr>
          <td>
            <user:DriverControl ID="Login"  RunAt="server" />
          </td>
          <td>
            <asp:DataGrid runat= "server" id="Datagride" AutoGenerateColumns="True">
            </asp:DataGrid>
          </td>
        </tr>
      </table>
    </form>
</div>
 <div id="footer">Copyright @lzl</div>

</div>

  </body>
</html>
