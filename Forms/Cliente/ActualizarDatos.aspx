<%@ Page Language="C#" MasterPageFile="~/Forms/Cliente/ClienteMain.Master" AutoEventWireup="true" CodeBehind="ActualizarDatos.aspx.cs" Inherits="Muebles.Forms.Cliente.ActualizarDatos" %>

<asp:Content ID="ContentClienteMain" ContentPlaceHolderID="ClienteID" runat="server">

    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Actualizar Proveedor</div>
				    <div class="card-body">


                <div class="form-group">
                  <label>Id </label>
                  <input runat="server" name="id_cl" id="id_cl" type="number" class="form-control" placeholder="Ingrese el id " required="required" disabled>
			    </div>

                <div class="form-group">
                  <label>Nombre</label>
                  <input runat="server" name="nombre_c" type="text" id="nombre_c" class="form-control" placeholder="Ingrese el nombre" required="required" >
				</div>

                <div class="form-group">
                  <label>Correo</label>
                  <input runat="server" name="correo" id="correo" type="text" class="form-control" placeholder="Ingrese el correo" required="required" disabled>
				</div>

                <div class="form-group">
                  <label>Clave</label>
                  <input runat="server" name="clave_c" id="clave_c" type="text" class="form-control" placeholder="Ingrese clave" required="required" >
				</div>

                
                                      
                <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="Actualizar" class="btn btn-primary" OnClick="actualizar_c"></asp:button>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina --> 


    </asp:Content>
