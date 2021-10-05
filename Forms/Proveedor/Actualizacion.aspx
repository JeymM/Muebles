<%@ Page Language="C#" MasterPageFile="~/Forms/Proveedor/ProveedorMain.Master" AutoEventWireup="true" CodeBehind="Actualizacion.aspx.cs" Inherits="Muebles.Forms.Proveedor.Actualizacion" %>


<asp:Content ID="ContentProveedorMain" ContentPlaceHolderID="proveedorID" runat="server">

      <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Actualizar Proveedor</div>
				    <div class="card-body">


                <div class="form-group">
                  <label>Nit </label>
                  <input runat="server" name="id_p" id="id_p" type="number" class="form-control" placeholder="Ingrese el nit " required="required" disabled>
			    </div>
                    
                 <div class="form-group">
                  <label>Contacto</label>
                  <input runat="server" name="contact" type="text" id="contact" class="form-control" placeholder="Ingrese contacto" required="required" >
				</div>

                 <div class="form-group">
                  <label>Direccion</label>
                  <input runat="server" name="dir_p" type="text" id="dir_p" class="form-control" placeholder="Ingrese direccion" required="required" >
				</div>

                <div class="form-group">
                  <label>Nombre</label>
                  <input runat="server" name="nombre_p" type="text" id="nombre_p" class="form-control" placeholder="Ingrese el nombre" required="required" disabled>
				</div>

                <div class="form-group">
                  <label>Correo</label>
                  <input runat="server" name="correo" id="correo" type="text" class="form-control" placeholder="Ingrese el correo" required="required" disabled>
				</div>

                <div class="form-group">
                  <label>Clave</label>
                  <input runat="server" name="clave_p" id="clave_p" type="text" class="form-control" placeholder="Ingrese clave" required="required" >
				</div>

                
                                      
                <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="Actualizar" class="btn btn-primary" OnClick="actualizar_pro"></asp:button>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina --> 


</asp:Content>
