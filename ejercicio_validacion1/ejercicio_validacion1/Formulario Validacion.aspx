<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario Validacion.aspx.cs" Inherits="ejercicio_validacion1.Formulario_Validacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div class="fila">
                <div class="titulo">
                    <asp:Label ID="Label1" runat="server" Text="Nombre de usuario:"></asp:Label>
                </div>
                <div class="area">
                    <asp:TextBox ID="txtNombreUsuario" runat="server" OnTextChanged="txtNombreUsuario_TextChanged"></asp:TextBox>
                </div>
            
            </div>
            
          <div class="fila">
              <div class="titulo">
                  <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
              </div>
              <div class="area">
                  <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Introduzca la misma clave" ControlToCompare="txtClave" ControlToValidate="txtClave2"></asp:CompareValidator> 
              </div>
              
          </div>

            <div class="fila">
                <div class="titulo">
                    <asp:Label ID="Label3" runat="server" Text="Repita la clave:"></asp:Label>
                </div>
                <div class="area">
                    <asp:TextBox ID="txtclave2" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                
            </div>
            <div class="fila">
                <div class="titulo">
                     <asp:Label ID="Label4" runat="server" Text="Correo electrónico:"></asp:Label>
                </div>
                <div class="area">
                    <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" Text="Mail incorrecto" ControlToValidate="txtcorreo"></asp:RegularExpressionValidator> 
                </div>
            </div>
            
            <div class="fila">
                <div class="titulo">
                    <asp:Label ID="Label5" runat="server" Text="Apellido:"></asp:Label>
                </div>
                <div class="area">
                    <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
                </div>
                
            </div>
            <div class="fila">
                <div class="titulo">
                    <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
                </div>
                <div class="area">
                    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                </div>
                
            </div>

            <div class="fila">
                
                <div class="titulo">
                    <asp:Label ID="Label7" runat="server" Text="Pais de origen:"> </asp:Label>
                </div>
                <div class="area">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>España</asp:ListItem>
                <asp:ListItem>Francia</asp:ListItem>
               <asp:ListItem>Portugal</asp:ListItem>                              
                                  </asp:DropDownList>
                </div>

            </div>
            <div class="fila">
                <div class="titulo">
                    <asp:Label ID="Label8" runat="server" Text="Provincia:"></asp:Label>
                </div>
                <div class="area">
                    <asp:TextBox ID="txtprovincia" runat="server"></asp:TextBox>
                </div>
                
            </div>
            <div class="fila">
                <div class="titulo">
                    <asp:Label ID="Label9" runat="server" Text="Código Postal"></asp:Label>
                </div>
                <div class="area">
                     <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox> <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" MaximumValue="34000" MinimumValue="30000" Text="debe introducir codigo postal correcto" Type="Integer" ControlToValidate="txtcodigo"></asp:RangeValidator>
                </div>
                
            </div>
            <div class="fila">
                
                <div class="titulo">
                    <asp:Label ID="Label10" runat="server" Text="Sexo"></asp:Label>
                </div>
                <div class="area">
                    <asp:RadioButton ID="RadioButton1" runat="server" text="Hombre" Checked="true" GroupName="1" OnCheckedChanged="RadioButton1_CheckedChanged"/><asp:RadioButton ID="RadioButton2" runat="server" Text="Mujer" GroupName="1" /><asp:Label ID="Label14" runat="server" Text="Marque una opcion" Visible="False"></asp:Label>
                </div>
            </div>
           <div class="fila">
               <div class="titulo">
                   <asp:Label ID="Label11" runat="server" Text="Fecha de Nacimineto:"></asp:Label>
               </div>
               <div class="area">
                   <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar> 
               </div>
                
           </div>
            <div class="fila">
                <div class="titulo">
                    <asp:Label ID="Label12" runat="server" Text="Comentarios:"></asp:Label>
                </div>
                <div class="area">
                    <asp:TextBox ID="txtcomentario" runat="server" Height="185px" Width="390px"></asp:TextBox>
                </div>
            </div>
           <div class="fila">
               <div class="titulo">
                   <asp:Label ID="Label13" runat="server" Text="Acepto los términos y condiciones"></asp:Label>
               </div>
               <div class="area">
                   <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto" OnCheckedChanged="CheckBox1_CheckedChanged" /><asp:Label ID="Label15" runat="server" Text="Debe aceptar los términos" Visible="False"></asp:Label>
               </div>
           </div>
            <div class="fila">
                 <asp:Button ID="Button1" runat="server" Text="Aceptar" CommandName="btnAceptar" OnClick="Button1_Click" />
            </div>
            
        </div>
    </form>
</body>
</html>
