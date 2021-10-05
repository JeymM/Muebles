<%@ Page Language="C#" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Muebles.Forms.Administrador.Update" %>

<asp:Content ID="ContentAdministradorMain" ContentPlaceHolderID="AdministradorID" runat="server">
    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Actualizar Administrador</div>
				    <div class="card-body">


                <div class="form-group">
                  <label>Id </label>
                  <input runat="server" name="ida" id="ida" type="number" class="form-control" placeholder="Ingrese el id " required="required" disabled>
			    </div>
                    
                 <div class="form-group">
                  <label>Nombre</label>
                  <input runat="server" name="name" type="text" id="name" class="form-control" placeholder="Ingrese nombre" required="required" disabled >
				</div>

                 <div class="form-group">
                  <label>Telefono</label>
                  <input runat="server" name="tel" type="text" id="tel" class="form-control" placeholder="Ingrese telefono" required="required" >
				</div>

                <div class="form-group">
                  <label>Correo</label>
                  <input runat="server" name="correo" type="text" id="correo" class="form-control" placeholder="Ingrese el correo" required="required" disabled>
				</div>


                <div class="form-group">
                  <label>Clave</label>
                  <input runat="server" name="clave_a" id="clave_a" type="text" class="form-control" placeholder="Ingrese clave" required="required" >
				</div>

                
                                      
                <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="Actualizar" class="btn btn-primary" OnClick="actualizar_adm"></asp:button>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina --> 






    </asp:Content>