<%@ Page Language="C#" Inherits="htcx" Debug="true" %>

<html>
<head>
<style type="text/css">
div#container{width:100%;height:10%;}
div#header1 {width:33%;float:left;text-align:center;height:50px;}
div#header2 {width:33%;float:left;text-align:center;height:50px;}
div#header3 {width:34%;float:left;text-align:center;height:50px;}
div#menu {background-color:#ffff99;height:90%;width:100%;float:left;}
div#footer {background-color:#99bbbb;clear:both;text-align:center;}
</style>
</head>
<body>
    <div id="container">
        <div id="header1">
            <h2> <button onclick="ahtgl()">合同管理</button></h2>
        </div>
        <div id="header2">
            <h2> <button onclick="aclgl()">车辆管理</button></h2>
        </div>
        <div id="header3">
            <h2><button onclick="ajsygl()">驾驶员管理</button></h2>
        </div>
    </div>
    <div id="menu">
         <iframe id="page" height="100%" width="100%" src="null.aspx"></iframe>
    </div>
  </body>
</html>
<script type="text/javascript">
    function ahtgl() {

        page.src = "ly1.aspx";
    }
    function aclgl() {
        page.src = "ly2.aspx";
    }
    function ajsygl() {
        page.src = "ly3.aspx";
    }
</script>