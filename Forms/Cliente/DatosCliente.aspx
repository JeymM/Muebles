<%@ Page Language="C#" MasterPageFile="~/Forms/Cliente/ClienteMain.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="Muebles.Forms.Cliente.DatosCliente" %>

<asp:Content ID="ContentClienteMain" ContentPlaceHolderID="clienteID" runat="server">

	<div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Actualizar Datos</div>
				    <div class="card-body">


                <div class="form-group">
                  <label>ID Cliente</label>
                  <input runat="server" name="idProducto" id="idCliente" type="number" class="form-control" placeholder="Ingrese el ID del producto" required="required" disabled>
			    </div>

                <div class="form-group">
                  <label>Nombre</label>
                  <input runat="server" name="nombre" type="text" id="nombre" class="form-control" placeholder="Ingrese el nombre del producto" required="required">
				</div>

                <div class="form-group">
                  <label>Correo</label>
                  <input runat="server" name="correo" id="correo" type="text" class="form-control" placeholder="Ingrese una descripción" required="required" disabled>
				</div>

                <div class="form-group">
                  <label>Clave</label>
                  <input runat="server" name="inputClave" id="clave" type="text" placeholder="Clave usuario" class="form-control" required="required" disabled>
				</div>

                <div class="form-group">
                  <label>Estado</label>
                  <input runat="server" name="inputEstado" id="inputEstado" type="text" placeholder="Estado Producto" class="form-control" required="required" disabled>
				</div>
          
                        
                <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="Actualizar" class="btn btn-primary" OnClick="actualizar_Dat"></asp:button>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina -->    
    
  
</asp:Content>