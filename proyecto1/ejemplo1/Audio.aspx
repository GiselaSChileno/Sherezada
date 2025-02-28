<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Audio.aspx.cs" Inherits="ejemplo1.Audio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="min-vh-100">
    <div style="background: linear-gradient(#ffc4c4, #fff5e4);">
        <br />
        <br />
        <h1><%:Elegida[0].Titulo %></h1>
        <br />
        <br />
    </div>
    <div style="background: linear-gradient(#ffc4c4, #fff5e4)">
        <img src="utilidades\imgPrincipal\<%:Elegida[0].Titulo %>P.jpg" class="d-block w-100" alt="...">
        <br />
        <br />
        <br />
        <h1><%:Elegida[0].Titulo %></h1>
        <br />
        <br />
        <h5><%:Elegida[0].Texto %></h5>
        <br />
        <br />
        <br />
        <br />
        <br />


        <div class="row row-cols-1 row-cols-md-1 g-2">

            <div class="col">
                <div class="card mb-3 offset-md-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="utilidades\imgPrincipal\<%:Elegida[0].Titulo %>1.jpg" class="img-fluid rounded-start" alt="...">
                        </div>
                        <div class="col-md-8" style="background: linear-gradient(#d0bcb1, #f8d8de);">
                            <div class="card-body">
                                <br />
                                <h5><%: Elegida[0].Titulo %> </h5>
                                <br />
                                <audio controls controlslist="nodownload">
                                    <source src="<%: Elegida[0].Audio %>">
                                </audio>
                                <p class="card-text">Fecha de Publicación: <%: Elegida[0].Fecha.ToShortDateString() %>.</p>
                                <small>Cap: <%: Elegida[0].Episodio %>.  </small>
                                <br />
                                <small>Categoría: <%: Elegida[0].Categoria %>.</small>
                                <br />
                                <small>Likes: <%:Elegida[0].Likes %></small>
                                <br />
                                <%if (Session["userI"] != null)
                                    { %>
                                <asp:RadioButton ID="RaBu1" runat="server" CssClass="btn btn-outline-danger" Text="Me gusta ❤️" OnCheckedChanged ="RadioButton1" AutoPostBack="True" />
                                <%} %>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
</div>
</asp:Content>
