<%@ Page Language="C#" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master" AutoEventWireup="true" CodeBehind="ActualizarCliente.aspx.cs" Inherits="Muebles.Forms.Administrador.ActualizarCliente" %>



<asp:Content ID="ContentAdministradorMain" ContentPlaceHolderID="AdministradorID" runat="server">

  
    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Actualizar Cliente</div>
				    <div class="card-body">


                <div class="form-group">
                  <label>ID Cliente</label>
                  <input runat="server" name="idcliente" id="idcliente" type="number" class="form-control" placeholder="Ingrese el ID del cliente" required="required" disabled>
			    </div>

                <div class="form-group">
                  <label>Nombre</label>
                  <input runat="server" name="nombre" type="text" id="nombre" class="form-control" placeholder="Ingrese el nombre del cliente" required="required" >
				</div>

                <div class="form-group">
                  <label>Correo</label>
                  <input runat="server" name="email" id="email" type="text" class="form-control" placeholder="Ingresar Correo" required="required" disabled>
				</div>

               <div class="form-group">
                  <label>Clave</label>
                  <input runat="server" name="clave" id="clave" type="number" class="form-control" placeholder="Ingrese la clave del cliente" required="required" disabled>
			    </div>      
                        
                <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="Actualizar" class="btn btn-primary" OnClick="actualizar_cli"></asp:button>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina -->    
    

</asp:Content>
