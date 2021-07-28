<%@ Page Language="C#" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master"  AutoEventWireup="true" CodeBehind="sesionsesionadministrador.aspx.cs" Inherits="Muebles.Forms.Administrador.sesionsesionadministrador" %>

<asp:Content ID="ContentProveedorMain" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    


    <h1>Bienvenido Administrador <%  Response.Write(Session["nombre"]);%></h1>
    


</asp:Content>
