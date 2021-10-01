<%@ Page Language="C#" MasterPageFile="~/Forms/Administrador/AdministradorMain.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Muebles.Forms.Administrador.Ventas" %>


<asp:Content ID="ContentAdministradorMain" ContentPlaceHolderID="AdministradorId" runat="server">
    <!-- Tabla para visualización de ventas realizadas -->
    <div class="container">

		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white" id="tab">Ventas realizadas</div>
					<div class="card-body">

						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">Id producto</th>
									<th scope="col">Nombre</th>
									<th scope="col">Descripcion</th>
									<th scope="col">Precio</th>
								</tr>
							</thead>
							<tbody>
								
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>
    

</asp:Content>