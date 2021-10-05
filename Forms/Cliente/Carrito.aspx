<%@ Page Language="C#" MasterPageFile="~/Forms/Cliente/ClienteMain.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Muebles.Forms.Cliente.Carrito" %>

<asp:Content ID="ContentClienteMain" ContentPlaceHolderID="ClienteID" runat="server">
<!-- aqui comienza el codigo del proyecto,copiar masterpagefile-->
	

	<div class="container">

		<div class="row">
			<div class="col-8">
				<div class="card">
					<div class="card-header bg-info text-white">Carrito Prontomuebles</div>
					<div class="card-body">

						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">ID Producto</th>
									<th scope="col">Precio</th>
									<th scope="col">Nombre</th>
									<th scope="col">Descripción</th>
									<th scope="col">Cantidad en Existencia</th>
								</tr>
							</thead>
							<tbody>
								<% listaCarrito(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
		<div class="col-4">


		  <div class="card ">
            <div class="card-header bg-primary text-white">Registrar Producto</div>
            <div class="card-body">


              <div class="form-group">
                <label>ID Producto a Comprar</label>
                <input runat="server" name="idProducto" id="idProducto" type="number" class="form-control"
                  placeholder="Ingrese el ID del producto" required="required">
              </div>

              <div class="form-group">
                <label>Cantidad a Comprar</label>
                <input runat="server" name="stock" id="stock" type="number" value="0" min="0" class="form-control"
                  placeholder="Ingrese el stock del producto" required="required">
              </div>

            </div>
          </div>
			<asp:button runat="server" Text="Realizar compra" id="buttonp" name="comprar" class="btn btn-warning w-100" OnClick="registrar_com"></asp:button>
		</div>
			</div>
	</div>	 
	<!-- aqui termina -->
	
	</asp:Content>