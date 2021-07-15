<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Muebles.Forms.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Password1 {
            position: relative;
            top: 17px;
            left: 93px;
        }
        #Text1 {
            position: relative;
            top: 4px;
            left: 69px;
            width: 131px;
        }
        #txtCorreo {
            height: 15px;
            width: 133px;
            position: relative;
            top: 9px;
            left: 69px;
        }
        #txtPassword {
            position: relative;
            top: -17px;
            left: 115px;
            width: 135px;
            height: 19px;
        }
        #Correo {
            position: relative;
            top: 25px;
            left: 116px;
            width: 132px;
        }
        #txt {
            position: relative;
            top: 16px;
            left: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="dropList" runat="server" AutoPostBack="True" Font-Names="Agency FB" Font-Size="Large" style="position: relative; top: 54px; left: 18px; height: 32px">
                <asp:ListItem>Seleccionar</asp:ListItem>
                <asp:ListItem>Administrador</asp:ListItem>
                <asp:ListItem>Cliente</asp:ListItem>
                <asp:ListItem>Proveedor</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" BackColor="#33CCFF" BorderColor="Red" BorderStyle="None" Font-Names="Arial Black" Font-Size="Large" Font-Strikeout="False" Font-Underline="True" ForeColor="#0033CC" style="position: relative; top: -1px; left: 232px" Text="CONFORTMUEBLES"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Correo"></asp:Label>
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
&nbsp;
            <br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnIngresar" runat="server" Font-Names="Arial Black" Font-Size="Small" OnClick="Button1_Click" style="position: relative; top: -65px; left: 114px" Text="Ingresar" />
        </div>
        <asp:Label ID="lblAviso" runat="server"></asp:Label>
    </form>
</body>
</html>
