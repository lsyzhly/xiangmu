<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE html>

<html>
<head>
<style type="text/css">
div#menu {background-color:#ffff99;height:90%;width:10%;float:left;}
div#content {background-color:#EEEEEE;height:90%;width:90%;float:left;}
h2 {margin-bottom:0;font-size:18px;}
h3 {margin-bottom:0;font-size:14px;text-align:center;}
ul {margin:0;}
li {list-style:none;}
</style>
</head>
<body>
<div id="menu">
<h2>Menu</h2>
<h3><button id="aaa" onclick="anowcar()">正在使用车辆</button></h3>
<h3><button id="bbb" onclick="atjxc()">添加新车</button></h3>
<h3><button id="ccc" onclick="asycl()">所有车辆</button></h3>
<h3><button id="ddd" onclick="akycl()">可用车辆</button></h3>
</div>
<div id="content">
    <iframe height="700px" width="100%" id="ly2page" src="null.aspx"></iframe>
   </div>
</body>
</html>
<script type="text/javascript">
    function anowcar() {
        ly2page.src = "nowCar.aspx";
    }
    function atjxc() {
        ly2page.src = "newCar.aspx";
    }
    function asycl() {
        ly2page.src = "aclcx.aspx";
    }
    function akycl() {
        ly2page.src = "aUseclcx.aspx";
    }
</script>