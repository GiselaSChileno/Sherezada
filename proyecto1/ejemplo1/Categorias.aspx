<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="ejemplo1.Episodios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background: linear-gradient(#ffc4c4, #fff5e4);">
        <br />
        <br />
        <h1>Categorías</h1>
        <br />
        <br />
    </div>
    <div class="min-vh-100"; style="background: linear-gradient(#ffc4c4, #fff5e4);">
        <img src="utilidades\imgPrincipal\categoriasP.jpg" class="d-block w-100" alt="...">
        <br />
        <br />
        <br />

        <div class="row row-cols-1 row-cols-md-1 g-2">

            <% foreach (Dominio.Novelas cate in Cats)
                { %>
            <div class="col">
                <div class="card mb-3 offset-md-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="utilidades\imgPrincipal\<%: cate.Categoria %>.jpg" class="img-fluid rounded-start" alt="...">
                        </div>
                        <div class="col-md-8" style="background: linear-gradient(#d0bcb1, #f8d8de);">
                            <div class="card-body">
                                <h5><%: cate.Categoria %> </h5>
                                 <% foreach (Dominio.Novelas Obra in Obras)
                                     {
                                         if (cate.Categoria == Obra.Categoria)
                                         { %>
                                         <ol class="list-group list-group-numbered">
                                             <li class="list-group-item d-flex justify-content-between align-items-start">
                                                 <div class="ms-2 me-auto">
                                                     <div class="fw-bold"><%:Obra.Titulo %></div>
                                                     <a href="Elegida.aspx?id=<%: Obra.Titulo %>">🎙️</a>
                                                 </div>
                                             </li>
                                         </ol>
                                        <%}
                                     } %>
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />

              <% }%>
        </div>
    </div>
</asp:Content>