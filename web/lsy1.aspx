<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xzht.cs" Inherits="xzht" %>

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
<h3><button id="htcx" onclick="htcxf()">合同查询</button></h3>
<h3><button id="xzht" onclick="xzhtf()">新增合同</button></h3>
</div>
<div id="content">
    <iframe height="700px" width="100%" id="lsy1page" src="null.aspx"></iframe>
   </div>
</body>
</html>
<script type="text/javascript">
    function htcxf()
    {
        lsy1page.src = "htcx.aspx";
    }
    function xzhtf() {
        lsy1page.src = "xzht.aspx";
    }
</script>