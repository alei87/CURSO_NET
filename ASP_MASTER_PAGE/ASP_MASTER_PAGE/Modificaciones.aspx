<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modificaciones.aspx.cs" Inherits="ASP_MASTER_PAGE.Modificaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        GESTIÓN DE CLIENTES</p>
    <p>
        Modificación de clientes</p>
    <div class="linea">
        <div class="titulo">
            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label><asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ID" DataValueField="ID"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SIMULACROSQLConnectionString %>" SelectCommand="SELECT [ID] FROM [cliente]"></asp:SqlDataSource>
            <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" />
        </div>
    </div>
    <div class="linea">
        <div class="titulo">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        </div>
        <div class="area">
            <asp:TextBox ID="TxtNomMo" runat="server"></asp:TextBox>
        </div>
    </div>
     <div class="linea">
        <div class="titulo">
            <asp:Label ID="Label3" runat="server" Text="Apellido 1"></asp:Label>
        </div>
        <div class="area">
            <asp:TextBox ID="TxtAp1Mo" runat="server"></asp:TextBox>
        </div>
    </div>
      <div class="linea">
        <div class="titulo">
            <asp:Label ID="Label4" runat="server" Text="Apellido 2"></asp:Label>
        </div>
        <div class="area">
            <asp:TextBox ID="TxtAp2Mo" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="linea">
        <div class="titulo">
            <asp:Label ID="Label5" runat="server" Text="Ciudad"></asp:Label>
        </div>
        <div class="area">
            <asp:TextBox ID="TxtCiudadMo" runat="server"></asp:TextBox>
        </div>
    </div>
     <div class="linea">
        <div class="titulo">
            <asp:Label ID="Label6" runat="server" Text="Categoría"></asp:Label>
        </div>
        <div class="area">
            <asp:TextBox ID="TxtCatMo" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="boton">
        <asp:Button ID="BtnModificar" runat="server" Text="Modificar" OnClick="BtnModificar_Click" />
    </div>
    <asp:Label ID="LblError" runat="server" Text=""></asp:Label>

    
        
</asp:Content>
