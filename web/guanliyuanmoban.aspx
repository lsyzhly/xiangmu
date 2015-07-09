<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guanliyuanmoban.aspx.cs" Inherits="web.guanliyuanmoban" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
<h2>  <button onclick="htgl()">合同管理</button></h2>
</div>

<div id="header2">
<h2><button onclick="clgl()">车辆管理</button></h2>
</div>

<div id="header3">
<h2><button onclick="jsygl()">驾驶员管理</button></h2>
</div>
<div id="menu">
<h2>Menu</h2>
<iframe id="nn" style="width:100%;height:100%;" src="null.aspx"></iframe>
</div>


<div id="content">

<iframe id="mm" style="width:100%;height:100%;" src="null.aspx"></iframe>












</div>


<div id="footer">Copyright @lzl</div>

</div>

</body>
</html>
<script type="text/javascript">
function htgl()
{
    nn.src = "htgl.aspx";
    mm.src = "null.aspx";
}
</script>