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
<h3><button id="syjsy" onclick="asyjsy()">ËùÓÐ¼ÝÊ»Ô±</button></h3>
</div>
<div id="content">
    <iframe height="700px" width="100%" id="ly3page" src="null.aspx"></iframe>
   </div>
</body>
</html>
<script type="text/javascript">
    function asyjsy() {
        ly3page.src = "ajsygl";
    }
</script>