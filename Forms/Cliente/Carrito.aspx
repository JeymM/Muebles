<%@ Page Language="C#" MasterPageFile="~/Forms/Cliente/ClienteMain.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Muebles.Forms.Cliente.Carrito" %>

<asp:Content ID="ContentClienteMain" ContentPlaceHolderID="ClienteID" runat="server">
<!-- aqui comienza el codigo del proyecto,copiar masterpagefile-->
	

	<div class="container">

		<div class="row">
			<div class="col-12">
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
									<th scope="col">Descripción</th>
									<th scope="col">Nombre</th>
									<th scope="col">Cantidad requerida</th>
								</tr>
							</thead>
							<tbody>
								<% listaCarrito(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>
	 <asp:button runat="server" Text="Realizar compra" id="botonCom" type="submit" name="comprar" class="btn btn-primary" OnClick="registrar_com"></asp:button>
	<!-- aqui termina -->
	
	</asp:Content>