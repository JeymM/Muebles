<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioProveedor.aspx.cs" Inherits="Muebles.Forms.Proveedor.InicioProveedor" %>

<asp:Content ID="ContentProveedorMain" ContentPlaceHolderID="proveedorID" runat="server">
    
    


    <h1>Bienvenido Proveedor <%  Response.Write(Session["nombre"]);%></h1>
    


</asp:Content>

