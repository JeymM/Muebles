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
                  <label>ID </label>
                  <input runat="server" name="id_cl" id="id_cl" type="number" class="form-control" placeholder="Ingrese el ID " required="required" disabled>
			    </div>

                <div class="form-group">
                  <label>Nombre</label>
                  <input runat="server" name="nombre_cl" type="text" id="nombre_cl" class="form-control" placeholder="Ingrese el nombre" required="required" disabled>
				</div>

                <div class="form-group">
                  <label>Correo</label>
                  <input runat="server" name="correo" id="correo" type="text" class="form-control" placeholder="Ingrese el correo" required="required" disabled>
				</div>

                <div class="form-group">
                 <select name="selectedState" class="form-select">
                    <option value="">-Seleccione una opción-</option>
                    <optgroup label="Tipo Users">
                       <option value="Activo" <%=estado == 1 ? "selected" : ""%>>Activo</option>
                       <option value="Desactivado" <%=estado == 0 ? "selected" : ""%>>Desactivado</option>
                    </optgroup>                 
                 </select>
                </div>                        
                <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="Actualizar" class="btn btn-primary" OnClick="actualizar_cli"></asp:button>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina -->    
    

</asp:Content>