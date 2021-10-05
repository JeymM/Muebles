<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master" CodeBehind="VerificarEmpleado.aspx.cs" Inherits="Muebles.Forms.Administrador.VerificarEmpleado" %>

<asp:Content ID="ContentAdministradorVerifyCustomer" ContentPlaceHolderID="AdministradorId" runat="server">
    <div class="container">

		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white" id="tab">Empleados Registrados</div>
					<div class="card-body">

						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">Nit</th>
									<th scope="col">Contacto</th>
									<th scope="col">Direccion</th>
									<th scope="col">Correo</th>
									<th scope="col">Clave</th>
									<th scope="col">Estado</th>
								</tr>
							</thead>
							<tbody>
								 <% listaTrabajadores(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>
</asp:Content>
