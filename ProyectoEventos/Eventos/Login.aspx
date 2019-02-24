<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Eventos.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Recursos/bootstrap-4.3.1-dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <style>
        @import "bourbon";

        body {
            background: #eee !important;
        }

        .wrapper {
            margin-top: 80px;
            margin-bottom: 80px;
        }

        .form-signin {
            max-width: 380px;
            padding: 15px 35px 45px;
            margin: 0 auto;
            background-color: #fff;
            border: 1px solid rgba(0,0,0,0.1);
            .form-signin-heading, .checkbox;

        {
            margin-bottom: 30px;
        }

        .checkbox {
            font-weight: normal;
        }

        .form-control {
            position: relative;
            font-size: 16px;
            height: auto;
            padding: 10px;
            @include box-sizing(border-box);
            &:focus;

        {
            z-index: 2;
        }

        }

        input[type="text"] {
            margin-bottom: -1px;
            border-bottom-left-radius: 0;
            border-bottom-right-radius: 0;
        }

        input[type="password"] {
            margin-bottom: 20px;
            border-top-left-radius: 0;
            border-top-right-radius: 0;
        }

        }
    </style>
    <div class="wrapper">
        <form class="form-signin" runat="server">
            <h2 class="form-signin-heading">Please login</h2>
            <div class="row">
                <asp:TextBox CssClass="form-control" ID="TxtCedula" placeholder="Cédula" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <asp:TextBox CssClass="form-control" ID="TxtContrasenna" placeholder="Contraseña" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <asp:Button OnClick="btnLogin_Click" CssClass="btn btn-lg btn-primary btn-block" ID="btnLogin" runat="server" Text="Login" />
        </form>
    </div>
    <script src="Recursos/bootstrap-4.3.1-dist/js/bootstrap.min.js"></script>
</body>

</html>
