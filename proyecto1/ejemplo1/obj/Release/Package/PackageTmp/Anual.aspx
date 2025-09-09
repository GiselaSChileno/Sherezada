<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Anual.aspx.cs" Inherits="ejemplo1.Anual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="min-vh-100"; style="background: linear-gradient(#ffc4c4, #fff5e4)">
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="container text-center">
            <div class="col">
                <div class="row">
                    <h1>Estoy muy agradecida por tu apoyo!</h1>
                </div>
                <br />
                <br />
                <br />
                <br />
                <br />
                <div class="row">
                    <img src="utilidades\imgPrincipal\gracias.jpg" class="d-block w-100" alt="...">
                </div>
                <br />
                <br />
                <br />
                <br />
                <br />
                <div>
                    <h4 style="font-family: 'Lucida Sans'; font-style: italic;"><%: Session["userN"] %>, tu pago ha sido aprovado, con tu apoyo sostenemos este proyecto 😊</h4>
                </div>
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
