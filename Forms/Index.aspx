<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs"
Inherits="Muebles.Forms.Index" %>

<!DOCTYPE html>
<script runat="server">

  protected void Button1_Click(object sender, EventArgs e)
  {

  }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Muebles</title>
    <link
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css"
      rel="stylesheet"
      integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU"
      crossorigin="anonymous"
    />
  </head>
  <body>
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-3 bg-dark h-100" style="height: 100vh">
          <form class="h-100" runat="server">
            <p class="center fs-3 text-center text-light py-3">
              Iniciar sesión
            </p>
            <div class="mb-2 px-3">
              <label for="dropList" class="form-label text-light"
                >Seleccione el tipo de usuario</label
              >
              <select id="dropList" name="dropList" class="form-select">
                <option>Cliente</option>
                <option>Proveedor</option>
                <option>Administrador</option>
              </select>
            </div>
            <div class="mb-2 px-3">
              <input
                name="correo"
                type="text"
                class="form-control"
                id="correo"
                runat="server"
                placeholder="Ingresa su email"
              />
            </div>
            <div class="mb-2 px-3">
              <input
                id="password"
                runat="server"
                type="password"
                name="password"
                placeholder="Contraseña"
                class="form-control"
              />
            </div>
            <asp:Button
              ID="BtnIngresar"
              runat="server"
              OnClick="BtnIngresar_Click"
              class="btn btn-primary w-75 p-2 mx-5 align-center text-center"
              Text="Ingresar"
            />
          </form>
          <p class="fs-5 my-4 text-light text-center texet-muted py-2">
            ¿No tienes una cuenta?, ¡Crea una en el siguiente formulario!
          </p>

              <label class="fs-5 text-light text-center">!Unetea una comunidad con grandes descuentos!</label>
          <div class="p-3 d-flex">
              <a class="center my-3 mx-3 fs-3 text-center text-light btn-primary btn" href=<% Response.Write(Session["url"] + "/Cliente/Registro.aspx");%>>Registrarse</a>
          </div>
        </div>
        <div class="col-md-9 gray-900 p-0">
          <div
            class="w-100"
            style="
              background-image: url(../assets/img/backgroundindex.jpg);
              background-size: cover;
              background-repeat: no-repeat;
              width: 100%;
              height: 100%;
            "
          >
            <div class="d-inline" style="width: 600px; height: 400px">
              <div class="text-center align-center">
                <!--
                <h1 class="display-5 fw-bold text-center text-Dark" >ConfortMuebles</h1>
              --></div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <script
      src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js"
      integrity="sha384-/bQdsTh/da6pkI1MST/rWKFNjaCP5gBSY4sEBT38Q/9RBh9AH40zEOg7Hlq2THRZ"
      crossorigin="anonymous"
    ></script>
  </body>
</html>
