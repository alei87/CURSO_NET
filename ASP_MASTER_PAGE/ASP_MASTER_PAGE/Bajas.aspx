<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bajas.aspx.cs" Inherits="ASP_MASTER_PAGE.Bajas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    GESTIÓN DE CLIENTES</p>
<p>
    Bajas de Clientes</p>
<p>
    Introduce el id a eliminar<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ID" DataValueField="ID"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SIMULACROSQLConnectionString %>" SelectCommand="SELECT [ID] FROM [cliente]"></asp:SqlDataSource>
    <asp:Button ID="BtnBorrar" runat="server" Text="Borrar" OnClick="BtnBorrar_Click" />
    <br />
</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
            <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
            <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
            <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SIMULACROSQLConnectionString %>" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
