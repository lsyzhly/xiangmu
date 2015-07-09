<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xzht.aspx.cs" Inherits="web.xzht" %>

<!DOCTYPE html>

<html>
<head>
<style type="text/css">
div#container{width:600px;}
div#welcom {width:600px;text-align:right;}
div#header1 {width:200px;float:left;text-align:center;}
div#header2 {width:200px;float:left;text-align:center;}
div#header3 {width:200px;float:left;text-align:center;}
div#menu {background-color:#ffff99;height:200px;width:150px;float:left;}
div#content {background-color:#EEEEEE;height:200px;width:450px;float:left;}
div#footer {background-color:#99bbbb;clear:both;text-align:center;}
h1 {margin-bottom:0;}
h2 {margin-bottom:0;font-size:18px;}
h3 {margin-bottom:0;font-size:10px;}
ul {margin:0;}
li {list-style:none;}
</style>
</head>

<body>

<div id="container">
<div id="welcom">
<h3>欢迎!</h3>
</div>

<div id="header1">
<h2>  <a href="htcz.aspx">合同操作</a></h2>
</div>

<div id="header2">
<h2><a href="cxcl.aspx"">查询车辆</a></h2>
</div>

<div id="header3">
<h2><a href="grxx.aspx">个人信息</a></h2>
</div>
<div id="menu">
<h2>Menu</h2>

    <u1>
        <li><h3>合同查询</h3></li>
        <li><h3>新增合同</h3></li>
    </u1>


</div>

<div id="content">
    <table id="LoginTable"  runat="server">
  <tr>
    <td>ID：</td>
    <td><asp:TextBox ID="driverid" RunAt="server" /></td>
  </tr>
  <tr>	
    <td>车牌号：</td>
    <td><asp:TextBox ID="carid"  RunAt="server" /></td>
  </tr>
   <tr>	
    <td>合同起始时间：</td>
    <td><asp:TextBox ID="startdate"  RunAt="server" /></td>
    <td>(如1999年1月1日输入1990101)</td>
  </tr>
  <tr>	
    <td>合同结束时间：</td>
    <td><asp:TextBox ID="enddate"  RunAt="server" /></td>
    <td>(如1999年1月1日输入1990101)</td>
  </tr>
  <tr>	
    <td><asp：CheckBox ID="isagree" Text="我已阅读合同，并同意" RunAt="server" />
  </tr>
  <tr>
    <td></td>
    <td><asp:LinkButton Text="Log In" OnClick="OnLoginButtonClicked"
      RunAt="server" /></td>
  </tr>
</table>
</div>


<div id="footer">Copyright @lzl</div>

</div>

</body>
</html>