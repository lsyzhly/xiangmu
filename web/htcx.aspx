<%@ Page Language="C#" Inherits="htcx" Debug="true" %>

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
<h2>  <a href="htcx.aspx">��ͬ����</a></h2>
</div>

<div id="header2">
<h2><a href="clcx.aspx">������ѯ</a></h2>
</div>

<div id="header3">
<h2><a href="grxx.aspx">������Ϣ</a></h2>
</div>
<div id="menu">
<h2>Menu</h2>
<h3><a href="htcx.aspx">��ͬ��ѯ</a></h3>
<h3><a href="xzht.aspx">������ͬ</a></h3>
</div>

<div id="content">
    <form runat="server">
      <asp:DropDownList ID="StateList"  OnSelectedIndexChanged="OnChange" AutoPostBack="True" RunAt="server">
        <asp:ListItem Text="��ǰ��ͬ" RunAt="server" />
        <asp:ListItem Text="��Ч��ͬ" RunAt="server" />
        <asp:ListItem Text="���к�ͬ" RunAt="server" />
      </asp:DropDownList>
      <asp:GridView  runat= "server" id="Contractgride" AutoGenerateColumns="True">
      </asp:GridView>
    </form>

</div>


<div id="footer">Copyright @lzl</div>

</div>
  </body>
</html>
