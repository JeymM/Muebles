<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master" CodeBehind="VerificarAdmin.aspx.cs" Inherits="Muebles.Forms.Administrador.VerificarAdmin" %>

<asp:Content ID="ContentAdministradorVerifyCustomer" ContentPlaceHolderID="AdministradorId" runat="server">
    <div class="container">

		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white" id="tab">Administradores Registrados</div>
					<div class="card-body">

						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">ID </th>
									<th scope="col">Nombre</th>
									<th scope="col">Telefono</th>
									<th scope="col">Correo</th>
									<th scope="col">Clave</th>
									<th scope="col">Estado</th>
								</tr>
							</thead>
							<tbody>
								<% admin(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>
</asp:Content>

