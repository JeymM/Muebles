﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro_Usersnew.aspx.cs" Inherits="Muebles.Forms.Administrador.Registro_Usersnew" %>


<asp:Content ID="ContentAdministradorMain" ContentPlaceHolderID="AdministradorId" runat="server">
      <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Registrar Usuario</div>
				    <div class="card-body">

                <div class="form-group">
                <select name="user">
            <option value="">-Seleccione una opción-</option>
            <optgroup label="Tipo Users">
             <option value="Cliente" <%=ingreso == "Cliente" ? "selected" : ""%>>Cliente</option>
          <option value="Proveedor" <%=ingreso == "Proveedor" ? "selected" : ""%>>Proveedor</option>
            </optgroup>

                 
                </select>

                </div>


                <div class="form-group">
                  <label>ID Usuario</label>
                  <input runat="server" name="idCliente" id="idCliente" type="number" class="form-control" placeholder="Ingrese el ID del cliente" required="required">
			    </div>

                <div class="form-group">
                  <label>Nombre</label>
                  <input runat="server" name="nombre" type="text" id="nombre" class="form-control" placeholder="Ingrese el nombre del producto" required="required">
				</div>

                <div class="form-group">
                  <label>Email</label>
                  <input runat="server" name="email" id="email" type="text" class="form-control" placeholder="Ingrese correo" required="required">
				</div>

                <div class="form-group">
                  <label>Clave</label>
                  <input runat="server" name="clave" id="clave" type="number" placeholder="Ingrese una contraseña" class="form-control" required="required">
				</div>       
                <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="Registro" class="btn btn-primary" OnClick="Registrar"></asp:button>


				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    

    


</asp:Content>