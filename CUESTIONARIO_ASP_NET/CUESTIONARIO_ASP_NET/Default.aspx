<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CUESTIONARIO_ASP_NET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/estilos.css"/>
    <link rel="img" href="img/descarga.jpg" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>PREGUNTA 1:¿Cómo se abre una ventana nueva? </h2>
          
            <asp:RadioButton ID="RadioButton1" runat="server"  Text="a. open(www.terra.com);" GroupName="1"/><br />
            <asp:RadioButton ID="RadioButton2" runat="server"  Text="b. nueva = window.new(www.terra.com);" GroupName="1"/><br />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="c. nueva = window.open(www.terra.com);" GroupName="1"/><br />
            </div>
         <div>
             <h2>PREGUNTA 2: La instrucción document.getElementById('logo') hacer referencia al elemento. </h2>
            
            <asp:RadioButton ID="RadioButton4" runat="server" Text="a. Que tenga asignada la clase logo" GroupName="2" /><br />
            <asp:RadioButton ID="RadioButton5" runat="server"  Text="b. Que tenga asociado el id logo" GroupName="2"/><br />
            <asp:RadioButton ID="RadioButton6" runat="server" Text ="c. Que tenga el nombre logo" GroupName="2"/>
        </div>
        <div>
            <h2> PREGUNTA 3: Si queremos cambiar el estado de un elemento al pasar el cursor por encima, y recuperarlo al quitarlo, ¿qué eventos usaremos?</h2>
            
                
            <asp:RadioButton ID="RadioButton7" runat="server" Text="a. onmouseup para cambiar el estado y onmouseout para recuperarlo" GroupName="3"/><br />
            <asp:RadioButton ID="RadioButton8" runat="server" Text="b. onmouseup para cambiar el estado y onmouseleave para recuperarlo." GroupName="3"/><br />
            <asp:RadioButton ID="RadioButton9" runat="server" Text="c. onmouseover para cambiar el estado y onmouseout para recuperarlo " GroupName="3" /><br />
            <asp:RadioButton ID="RadioButton10" runat="server" GroupName="3" /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="te da cuen?????">Deberias introducir la cancion sexual</asp:RequiredFieldValidator><br />
            introduce el rango adecuado entre 10 y 20 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="error de rango" Text="el valor no esta en el rango permitido" ControlToValidate="TextBox2" MaximumValue="20" MinimumValue="10" Type="Integer"></asp:RangeValidator><br />
            contraseña<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox><br />
            comprueba contraseña<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" Text="las contraseñas no coinciden" ValueToCompare="textbox" ControlToCompare="TextBox3" ControlToValidate="TextBox4"></asp:CompareValidator>

        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="VER RESPUETAS" CommandName="boton" OnClick="Button1_Click1" />
             <asp:Label ID="Label4" runat="server" Text="0"  Font-Names="lblAciertos"></asp:Label>
            <asp:image src="img/descarga.jpg" style="width: 284px" id="rick" visible="false" runat="server"/>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
           introduce un correo electronico <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="introduce un mail valido" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ControlToValidate="TextBox5"></asp:RegularExpressionValidator>

        </div>

       
    </form>
</body>
</html>
