<%@ Page Language="C#" MasterPageFile="~/Forms/Cliente/ClienteMain.Master"  AutoEventWireup="true" CodeBehind="InicioCliente.aspx.cs" Inherits="Muebles.Forms.Cliente.InicioCliente" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Nombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Correo"></asp:Label>
&nbsp;<asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Clave"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TxtClave" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar"/>
        </div>
    </form>
</body>
</html>
