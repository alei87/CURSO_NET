<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_con_SQL1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/StyleSheet1.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

       
        <div class="alta">
            <asp:HyperLink ID="HyperLinkAlta" runat="server" CssClass="primero" NavigateUrl="~/Alta.aspx">Alta de Usuario</asp:HyperLink>
        </div>
        <div class="baja">
            <asp:HyperLink ID="HyperLinkBaja" runat="server" CssClass="segundo" NavigateUrl="~/Baja.aspx">Baja de Usuario</asp:HyperLink>
        </div>
        <div class="alta">
            <asp:HyperLink ID="HyperLinkCons" runat="server" CssClass="primero" NavigateUrl="~/Consulta.aspx">Consulta un Usuario</asp:HyperLink>
        </div>
        <div class="baja">
            <asp:HyperLink ID="HyperLinkModi" runat="server" CssClass="segundo" NavigateUrl="~/Modificacion.aspx">Modifica un Usuario</asp:HyperLink>
        </div>

        </div>
    </form>
</body>
</html>
