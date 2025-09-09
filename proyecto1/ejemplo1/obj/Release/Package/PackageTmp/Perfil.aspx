<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="ejemplo1.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background: linear-gradient(#ffc4c4, #fff5e4);" class="min-vh-100">
        <br />
        <br />
        <br />
        <h1>¡Bienvenid@ <%:Session["userN"] %>!</h1>
        <p class="fst-italic">Aquí puedes adquirir una suscripción y cambiar tus datos de acceso.</p>
        <br />
        <br />
        <br />
        <div class="row">
            <div class="col-6">
                
                <div class="mb-3">
                    <label for="txtNombre" class="form-label">Nombre:</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtContrasena" class="form-label">Contraseña:</label>
                    <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtCorreo" class="form-label">Correo:</label>
                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" type="email"></asp:TextBox>
                    <p class="fst-italic">Por favor ten en cuenta que no usamos correo de verificación o publicidad. Sólo te notificaremos en caso de adquirir/cancelar suscripción o de requerir contraseña extraviada.</p>
                </div>

                <br />
                <br />
                <br />
                <asp:Button ID="Aceptar" runat="server" Text="Aceptar" OnClick="BtnAcptClick" CssClass="btn btn-outline-secondary" />
            </div>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
