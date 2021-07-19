<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Muebles.Forms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
&nbsp;<div title="Iniciar Sesión ">
            <input id="Txtname" type="text" /><br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label>
            <br />
            <input id="Password1" type="password" /><br />
            <br />
            <input id="btnIngresar" name="Ingresar" type="button" value="Ingreso" />

      </div>
    </form>
</body>
</html>
