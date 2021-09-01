<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="ASP_con_SQL1.Alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label><asp:TextBox ID="TxtClave" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Mail"></asp:Label><asp:TextBox ID="TxtMail" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" Text="Introduzca un mail correcto" ControlToValidate="txtMail" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator> <br />
            <asp:Button ID="BtnAlta" runat="server" Text="Alta" OnClick="BtnAlta_Click" /><asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
