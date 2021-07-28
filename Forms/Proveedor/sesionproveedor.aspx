<%@ Page Language="C#" MasterPageFile="~/Forms/Proveedor/ProveedorMain.Master"  AutoEventWireup="true" CodeBehind="sesionproveedor.aspx.cs" Inherits="Muebles.Forms.Proveedor.sesionproveedor" %>

<asp:Content ID="ContentProveedorMain" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    


    <h1>Bienvenido Proveedor <%  Response.Write(Session["nombre"]);%></h1>
    


</asp:Content>
