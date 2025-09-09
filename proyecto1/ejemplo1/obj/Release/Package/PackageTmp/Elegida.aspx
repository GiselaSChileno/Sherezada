<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Elegida.aspx.cs" Inherits="ejemplo1.Novela" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="background: linear-gradient(#ffc4c4, #fff5e4);">
        <br />
        <br />
        <h1><%:Elegida[0].Titulo %></h1>
        <br />
        <br />
    </div>
    <div class="min-vh-100"; style="background: linear-gradient(#ffc4c4, #fff5e4)">
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

       <div>
           <div class="row justify-content-center">
               <div class="col-8">
                   <asp:GridView ID="GridView1" runat="server" DataKeyNames="id" CssClass ="table table-secondary"
                       AutoGenerateColumns="false" OnSelectedIndexChanged="dgvListNov" OnPageIndexChanging="dgvNovPage" AllowPaging="true" PageSize="10">
                       <Columns>
                           <asp:BoundField HeaderText="Novela" DataField="Titulo"/>
                           <asp:BoundField HeaderText="Capítulo" DataField="Episodio"/>
                           <asp:BoundField HeaderText="Categoría" DataField="Categoria"/>
                           <asp:BoundField HeaderText="Likes" DataField="Likes"/>
                           <asp:CommandField HeaderText="Leer" ShowSelectButton="true" SelectText="🎙️" />
                       </Columns>
                   </asp:GridView>
                </div>
           </div>
       </div>
       <br />
       <br />
       <br />
    </div>      

</asp:Content>
