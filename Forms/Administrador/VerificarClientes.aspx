<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master" CodeBehind="VerificarClientes.aspx.cs" Inherits="Muebles.Forms.Administrador.VerificarClientes" %>

<asp:Content ID="ContentAdministradorVerifyCustomer" ContentPlaceHolderID="AdministradorId" runat="server">
    <div class="container">

		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white" id="tab">Clientes Registrados</div>
					<div class="card-body">

						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">ID Cliente</th>
									<th scope="col">Nombre</th>
									<th scope="col">Correo</th>
									<th scope="col">Actualizar Datos</th>
								</tr>
							</thead>
							<tbody>
								 <% listarCliente(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>
</asp:Content>

