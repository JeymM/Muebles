<%@ Page Language="C#" MasterPageFile="~/Forms/Cliente/ClienteMain.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Muebles.Forms.Cliente.Registro" %>
<asp:Content ID="ContentClienteMain" ContentPlaceHolderID="ClienteID" runat="server">

 <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Registro</div>
				    <div class="card-body">

                


                <div class="form-group">
                  <label>ID </label>
                  <input runat="server" name="idc" id="idc" type="number" class="form-control" placeholder="Ingrese su id" required="required">
			    </div>

                <div class="form-group">
                <label>Nombre</label>
                <input runat="server" name="namec" type="text" id="namec" class="form-control" placeholder="Ingrese su nombre " required="required">
				</div>


                <div class="form-group">
                  <label>Email</label>
                  <input runat="server" name="emailc" id="emailc" type="text" class="form-control" placeholder="Ingrese correo" required="required">
				</div>

                <div class="form-group">
                  <label>Clave</label>
                  <input runat="server" name="clavec" id="clavec" type="number" placeholder="Ingrese una contraseña" class="form-control" required="required">
				</div>       
                <asp:button runat="server" Text="Registrar" id="botonCli1" type="submit" name="Registro" class="btn btn-primary" OnClick="Registrarse"></asp:button>


				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    

    


</asp:Content>
