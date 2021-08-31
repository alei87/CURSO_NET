using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio_validacion1
{
    public partial class Formulario_Validacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                Label15.Visible = true;


            }
            else
            {
                if (IsValid)
                    Response.Redirect("Ya esta registrado.aspx");
            }
            
        }
    }
}