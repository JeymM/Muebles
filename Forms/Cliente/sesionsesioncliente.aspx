<%@ Page Language="C#" MasterPageFile="~/Forms/Cliente/clienteMain.Master"  AutoEventWireup="true" CodeBehind="sesionsesioncliente.aspx.cs" Inherits="Muebles.Forms.Cliente.sesionsesioncliente" %>


<asp:Content ID="ContentClienteMain" ContentPlaceHolderID="ClienteID" runat="server">
    
    


    <h1>Bienvenid@  <%  Response.Write(Session["nombre"]);%></h1>
    


</asp:Content>
