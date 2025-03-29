<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="ejemplo1.Sesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background: linear-gradient(#ffc4c4, #fff5e4);" class="min-vh-100">
        <br />
        <br />
        <br />
    <h1>¿Te gustaría registrarte?</h1>
        <br />
        <br />
        <br />
    <div class="row">
        <div class="col-6">
            <%if((string)Session["Usuario"] != "Progreso")
            { %>
                <div class="mb-3">
                    <label for="txtNombre" class="form-label">Nombre:</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            
            <%} %>
            <div class="mb-3">
                <label for="txtContrasena" class="form-label">Contraseña:</label>
                <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCorreo" class="form-label">Correo:</label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" type="email" ></asp:TextBox>
                <p class="fst-italic">Por favor ten en cuenta que no usamos correo de verificación o publicidad. Sólo te notificaremos en caso de adquirir/cancelar suscripción o de requerir contraseña extraviada.</p>
                <p class="fst-italic">Si olvidaste tu contraseña por favor escribe desde tu correo registrado a sherezadapodcast@hotmail.com</p>
            </div>
            
            <br />
            <br />
            <br />
            <asp:Button ID="Aceptar" runat="server" Text="Aceptar" onClick="BtnAcptClick" CssClass="btn btn-outline-secondary"/>
        </div>
    </div>
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
