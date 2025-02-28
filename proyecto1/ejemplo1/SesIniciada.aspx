<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="SesIniciada.aspx.cs" Inherits="ejemplo1.SesIniciada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="background-color: #ebd7ce" class="min-vh-100">

         <br />
         <br />
         <br />

        <h2><%: Session["mensaje"]%> </h2>
        <h2><%: Session["userN"] %></h2>

         <br />
         <br />
         <br />
           <div class="mb-3">
             <label for="Lblsubs" class="form-label">¿Te gustaría apoyar el proyecto con una suscripción?</label>

           </div>
         <br />
         <br />
         <% if((string)Session["mensaje"] == "¡Bienvenid@!")
            {%>
               <asp:Button ID="ButMod" runat="server" Text="Modificar" Onclick="ModClik" CssClass="btn btn-outline-secondary"/>
   
          <%} %>

        <asp:Button ID="ButLog" runat="server" Text="Aceptar" Onclick="BLog" CssClass="btn btn-outline-secondary"/>
         <br />
         <label for="Lblsubs" class="form-label">No olvides que estoy disponible en Telegram si tienes algun problema.</label>
         <div>
             <a href="https://t.me/+hqX0iofBfVg2Yjlh">
                 <i class="fa-brands fa-telegram" style="color: #664242;"></i>
             </a>
         </div>
    </div>
</asp:Content>
