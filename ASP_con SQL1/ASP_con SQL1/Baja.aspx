<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Baja.aspx.cs" Inherits="ASP_con_SQL1.Baja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre de Usuario:"></asp:Label><asp:TextBox ID="TxtBajaNombre" runat="server"></asp:TextBox><br />
            <asp:Button ID="BtnBorrar" runat="server" Text="Borrar" OnClick="BtnBorrar_Click" /><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
