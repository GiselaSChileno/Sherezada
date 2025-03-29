<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ejemplo1._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div  style="background-color: #ebd7ce">
        <% if ((int)Session["band"] == 1)
            { %>
        <div class="container px-4 text-center">
            <div class="alert alert-dark alert-dismissible fade show" role="alert" style="position:fixed; min-height: 500px; max-width:900px; z-index: 1;">
                <br />
                <strong>❗Alerta de cookies</strong>
                <br />
                 Este sitio web utiliza cookies propias y de terceros para su correcto funcionamiento, 
                 para fines analiticos y para mostrarle publicidad relacionada con sus preferencias en base a un perfil elaborado 
                 a partir de tus habitos de navegación. Al hacer click en aceptar o seguir navegando por el sitio, acepta el uso de estas tecnologías y el procesamiento 
                 de tus datos para estos propósitos. 
                <br />
                        <a href="Cookies.aspx" style="text-decoration: none">Más información</a>.
                 <br />
                  <button type="button" class="btn btn-danger" data-bs-dismiss="alert" href="default.aspx">Aceptar</button>
                 <br />
            </div>
         </div>
        <%} %>
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

    <div class="container-fluid" style="background: linear-gradient(#ffc4c4, #fff5e4);">
               
        <br />
        <br />
        <br />
        <br />
        <br />
        <h1>Los más populares</h1>
        <br />
        <br />
        <div class="container text-center">
            <div class="row row-cols-3 row-g3">

                <asp:Repeater ID="RepPop" runat="server">
                    <ItemTemplate>
                        <div class="col-4 ">
                            <div class="card" style="font-size: 1rem">
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
       </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <h1>Novelas</h1>
        <br />
        <br />

        <div class="container text-center">
            <div class="row row-cols-3 row-g3">

                <asp:Repeater ID="RepN" runat="server">
                    <ItemTemplate>
                        <div class="col-4">
                            <div class="card" style="font-size: 1rem">
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
         </div>

        <br />
        <br />
        <br />
        <br />
        <br />
    </div>




</asp:Content>


