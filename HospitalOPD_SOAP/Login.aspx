<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
    <div class="container" style="max-width: 400px; margin-top: 100px;">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Login</h4>
            </div>
            <div class="card-body">
                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Visible="false" CssClass="text-center" /><br />
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" Placeholder="Username" /><br /><br />
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" Placeholder="Password" /><br /><br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary btn-block" OnClick="btnLogin_Click" />
            </div>
        </div>
    </div>
</body>
</html>