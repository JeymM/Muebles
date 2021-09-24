<%@ Page Language="C#" MasterPageFile="~/Forms/Proveedor/ProveedorMain.Master" AutoEventWireup="true" CodeBehind="articuloIngresarStock.aspx.cs" Inherits="Muebles.Forms.Proveedor.articuloIngresarStock" %>

<asp:Content ID="ContentProveedorMain" ContentPlaceHolderID="proveedorID" runat="server">

	<!-- aqui comienza el codigo del proyecto,copiar masterpagefile-->
	

	<div class="container">

		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">Productos</div>
					<div class="card-body">

						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">ID Producto</th>
									<th scope="col">Cantidad</th>
									<th scope="col">Precio</th>
									<th scope="col">Descripción</th>
									<th scope="col">Nombre</th>
								</tr>
							</thead>
							<tbody>
								 <% listArticulos(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>

	<!-- aqui termina -->
  
</asp:Content>