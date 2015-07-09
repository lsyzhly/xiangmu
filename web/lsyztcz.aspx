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
            <h2> <button onclick="htczf()">合同操作</button></h2>
        </div>
        <div id="header2">
            <h2> <button onclick="clcxf()">车辆查询</button></h2>
        </div>
        <div id="header3">
            <h2><button onclick="grxxf()">个人信息</button></h2>
        </div>
    </div>
    <div id="menu">
         <iframe id="page" height="100%" width="100%" src="null.aspx"></iframe>
    </div>
  </body>
</html>
<script type="text/javascript">
    function htczf()
{

    page.src = "lsy1.aspx";
}
function clcxf() {
    page.src = "lsy2.aspx";
}
function grxxf() {
    page.src = "lsy3.aspx";
}
</script>