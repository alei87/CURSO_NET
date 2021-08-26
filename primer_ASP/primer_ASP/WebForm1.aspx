<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="primer_ASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styleSheet1.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <asp:Label runat="server" ID="Label1" Text="Ingrese primer valor"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="Label2" Text="Ingrese segundo valor "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>


            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="sumar" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="restar" />
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="multiplicar" />
            <br />
            <asp:RadioButton ID="RadioButton4" runat="server" Text="dividir" />

            <br />
            <asp:Button ID="Button1" runat="server" Text="Resultado" OnClick="Button1_Click1" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label runat="server" ID="Label4" Text="Ingrese primer valor"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="Label5" Text="Ingrese segundo valor "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="sumar" ></asp:ListItem>
                <asp:ListItem Text="restar" ></asp:ListItem>
                <asp:ListItem Text="multiplicar" ></asp:ListItem>
                <asp:ListItem Text="dividir" ></asp:ListItem>
            </asp:DropDownList>
            


        </div>
    </form>
</body>
</html>
