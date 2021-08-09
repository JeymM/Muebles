<%@ Page Language="C#" MasterPageFile="~/Forms/Proveedor/ProveedorMain.Master" AutoEventWireup="true" CodeBehind="articulo.aspx.cs" Inherits="Muebles.Forms.Proveedor.articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="ContentProveedorMain" ContentPlaceHolderID="proveedorID" runat="server">
    
    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Registrar Producto</div>
				    <div class="card-body">


                <div class="form-group">
                  <label>ID Producto</label>
                  <input runat="server" name="idProducto" id="idProducto" type="number" class="form-control" placeholder="Ingrese el ID del producto" required="required">
			    </div>

                <div class="form-group">
                  <label>Nombre</label>
                  <input runat="server" name="nombre" type="text" id="nombre" class="form-control" placeholder="Ingrese el nombre del producto" required="required">
				</div>

                <div class="form-group">
                  <label>Descripción</label>
                  <input runat="server" name="descripcion" id="descripcion" type="text" class="form-control" placeholder="Ingrese una descripción" required="required">
				</div>

                <div class="form-group">
                  <label>Precio</label>
                  <input runat="server" name="precio" id="precio" type="number" placeholder="Ingrese el precio del producto" class="form-control" required="required">
				</div>

                <div class="form-group">
                  <label>Stock</label>
                  <input runat="server" name="stock" id="stock" type="number" class="form-control" placeholder="Ingrese el stock del producto" required="required">
				</div>
                        
                <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="registrar" class="btn btn-primary" OnClick="botonCli_Click"></asp:button>


				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina -->    


</asp:Content>
