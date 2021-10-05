<%@ Page Language="C#" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Muebles.Forms.Administrador.Ventas" %>


<asp:Content ID="ContentAdministradorMain" ContentPlaceHolderID="AdministradorId" runat="server">
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
									<th scope="col">Fecha</th>
									<th scope="col">Nombre Producto</th>
									<th scope="col">Cantidad</th>
									<th scope="col">Precio</th>
									<th scope="col">Total Compra</th>
								</tr>
							</thead>
							<tbody>
								 <% listaHistorial(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>

	<!-- aqui termina -->
    

</asp:Content>