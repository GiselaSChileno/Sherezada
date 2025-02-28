<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ejemplo1._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="background-color: #ebd7ce" >

        <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
            </div>

            <div class="carousel-inner">
                <% for (int x = 0; x < 3; x++)
                    {
                %>
                <div class="carousel-item active">
                    <a href="Categorias.aspx">
                        <img src="utilidades\imgPrincipal\<%:Populares[x].Titulo%>P.jpg" class="d-block w-100" alt="Collage">
                    </a>
                    <div class="carousel-caption d-none d-md-block" style="text-shadow: 1px 1px 1px Black, -1px -1px 1px Black;">
                        <h5><%:Populares[x].Titulo%></h5>
                        <p><%:Populares[x].Texto%></p>
                    </div>
                </div>
                <% } %>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Anterior</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Siguiente</span>
            </button>
        </div>
        
    </div>

    <div style="background: linear-gradient(#ffc4c4, #fff5e4);">
        <br />
        <br />
        <br />
        <br />
        <br />
        <h1>Los más populares</h1>
        <br />
        <br />

        <div class="row row-cols-3 row-cols-sm-3 md-4">

            <asp:Repeater ID="RepPop" runat="server">
                <ItemTemplate>
                    <div class="col">
                        <div class="card" style="width: 20rem; font-size: 1rem">
                            <img src="utilidades\imgPrincipal\<%#Eval("Titulo") %>1.jpg" class="card-img-top" alt="imagen">
                            <div class="card-body" style="font-size: 85%; background: linear-gradient(#d0bcb1, #f8d8de);">
                                <h5 class="card-title"><%#Eval("Titulo") %></h5>
                                <p class="card-text"><%#Eval("Texto") %></p>
                                <asp:Button ID="Button" runat="server" Text="Leer" CssClass="btn btn-outline-secondary" CommandArgument='<%#Eval("Titulo") %>' CommandName="NombreNovela" OnClick="btn1_Click" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        <h1>Novelas</h1>
        <br />
        <br />

        <div class="row row-cols-3 row-cols-sm-3 g-4">

            <asp:Repeater ID="RepN" runat="server">
                <ItemTemplate>
                    <div class="col">
                        <div class="card" style="width: 20rem; font-size: 1rem">
                            <img src="utilidades\imgPrincipal\<%#Eval("Titulo") %>1.jpg" class="card-img-top" alt="imagen">
                            <div class="card-body" style="font-size: 85%; background: linear-gradient(#d0bcb1, #f8d8de);">
                                <h5 class="card-title"><%#Eval("Titulo") %></h5>
                                <p class="card-text"><%#Eval("Texto") %></p>
                                <p class="card-text">Capítulos disponibles: <%#Eval("caps") %></p>
                                <asp:Button ID="Button" runat="server" Text="Leer" CssClass="btn btn-outline-secondary" CommandArgument='<%#Eval("Titulo") %>' CommandName="NombreNovela" OnClick="btn2_Click" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <br />
        <br />
        <br />
        <br />
        <br />
    </div>


</asp:Content>


