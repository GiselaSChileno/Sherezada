<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="ejemplo1.Busqueda" %>
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
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="card mb-3" style="max-width: 540px;">
                            <div class="row g-0">
                                <div class="col-md-4">
                                    <img src="utilidades\imgPrincipal\<%#Eval("Titulo") %>1.jpg" class="img-fluid rounded-start" alt="...">
                                </div>
                                <div class="col-md-8">
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("Titulo") %></h5>
                                        <p class="card-text"><%#Eval("Texto") %></p>
                                        <p class="card-text"><small class="text-body-secondary">Capítulos disponibles: <%#Eval("caps") %></small></p>
                                        <p class="card-text"><small class="text-body-secondary">Likes: <%#Eval("Likes") %></small></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
