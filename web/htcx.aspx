<%@ Control Inherits="htcx"%>

<html>
  <body>
    <h1>Search Contract</h1>
    <hr>
    <form runat="server">
      <user:LoginControl ID="Login" OnLogin="OnLoginUser" BackColor="#ccccff" RunAt="server" />
    </form>
    <hr>
    <h3><asp:Label ID="Output" RunAt="server" /></h3>
  </body>
</html>