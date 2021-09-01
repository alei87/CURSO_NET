<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificacion.aspx.cs" Inherits="ASP_con_SQL1.Modificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario:"></asp:Label><asp:TextBox ID="TxtModifica1" runat="server"></asp:TextBox><br />
            <asp:Button ID="BtnBuscaMO" runat="server" Text="Buscar" OnClick="BtnBuscaMO_Click" /><asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Clave"></asp:Label><asp:TextBox ID="TxtClaveMO" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Mail"></asp:Label><asp:TextBox ID="TxtMailMO" runat="server"></asp:TextBox><br />
            <asp:Button ID="BtnModificar" runat="server" Text="Modificar" OnClick="BtnModificar_Click" /><asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
