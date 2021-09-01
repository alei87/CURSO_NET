using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASP_con_SQL1
{
    public partial class Alta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAlta_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into usuarios(Nombre, Clave, Mail) values('" + this.TxtNombre.Text +
                "','" + TxtClave.Text + "','" + TxtMail.Text + "')", conexion);
            comando.ExecuteNonQuery();
            Label4.Text = "Se registró el usuario";
            conexion.Close();
            

        }
    }
}