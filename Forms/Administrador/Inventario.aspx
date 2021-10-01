<%@ Page Language="C#" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="Muebles.Forms.Administrador.Inventario" %>

<asp:Content ID="ContentAdministradorMain" ContentPlaceHolderID="AdministradorId" runat="server">
    <!-- tabla de inventario -->
    <div class="container">

		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white" id="tab">Inventario de productos</div>
					<div class="card-body">

						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">Id producto</th>
									<th scope="col">Cantidad</th>
									<th scope="col">Precio</th>
									<th scope="col">Descripcion</th>
									<th scope="col">Nombre</th>
									<th scope="col">Eliminar producto</th> <%eliminar(); %>
								</tr>
							</thead>
							<tbody>
							   <% listaInventario(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>
    

</asp:Content>