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
    public partial class Baja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBorrar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from usuarios where Nombre='" + this.TxtBajaNombre.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1) this.Label2.Text = "Se borró el usuario";
            else
            {
                this.Label2.Text = "No existe un usuario con dicho nombre";
            }
            conexion.Close();
        }
    }
}