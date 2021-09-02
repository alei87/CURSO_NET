<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Altas.aspx.cs" Inherits="ASP_MASTER_PAGE.Altas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        GESTIÓN DE CLIENTES</p>
    <p>
        &nbsp;Altas de Clientes</p>
  
        <div class="linea">
            <div class="titulo">
                <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            </div>
            <div class="area">
                <asp:TextBox ID="TxtID" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtID" ErrorMessage="Debe ingresar un ID"></asp:RequiredFieldValidator>
            </div>
            
        </div>
        <div class="linea">
            <div class="titulo">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </div>
            <div class="area">
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe introducir un nombre" ControlToValidate="TxtNombre"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="linea">
            <div class="titulo">
                <asp:Label ID="Label3" runat="server" Text="Apellido 1"></asp:Label>
            </div>
             <div class="area">
                <asp:TextBox ID="TxtApe1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe introducir apellido" ControlToValidate="TxtApe1"></asp:RequiredFieldValidator>
            </div>
        </div>
            <div class="linea" controltovalidate="TxtApe1">
            <div class="titulo">
                <asp:Label ID="Label4" runat="server" Text="Apellido 2"></asp:Label>
            </div>
             <div class="area">
                <asp:TextBox ID="TxtApe2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe introducir un apellido" ControlToValidate="TxtApe2"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="linea">
            <div class="titulo">
                <asp:Label ID="Label5" runat="server" Text="Ciudad"></asp:Label>
            </div>
             <div class="area">
                <asp:TextBox ID="TxtCiudad" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Debe introducir una ciudad" ControlToValidate="TxtCiudad"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="linea">
            <div class="titulo">
                <asp:Label ID="Label6" runat="server" Text="Categoría"></asp:Label>
            </div>
             <div class="area">
                <asp:TextBox ID="TxtCategoria" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Debe introducir una categoría" ControlToValidate="TxtCategoria"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="boton">
            <asp:Button ID="BtnAniadir" runat="server" Text="Añadir" OnClick="BtnAniadir_Click" />
        </div>
    <asp:Label ID="LblError" runat="server" Text=""></asp:Label>





        
        <br />
    
    <p>
    </p>
</asp:Content>
