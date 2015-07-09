<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xzht.cs" Inherits="xzht" %>

<!DOCTYPE html>

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
<h2><a href="clcx.aspx">车辆查询</a></h2>
</div>

<div id="header3">
<h2><a href="grxx.aspx">个人信息</a></h2>
</div>
<div id="menu">
<h2>Menu</h2>
<h3><a href="htcx.aspx">合同查询</a></h3>
<h3><a href="xzht.aspx">新增合同</a></h3>
</div>


<div id="content">
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
</div>


<div id="footer">Copyright @lzl</div>

</div>

</body>
</html>