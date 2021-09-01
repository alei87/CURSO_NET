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
    public partial class Modificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscaMO_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Nombre, Clave, Mail from usuarios " +
                "where Nombre='" + this.TxtModifica1.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.TxtClaveMO.Text = registro["Clave"].ToString();
                this.TxtMailMO.Text = registro["Mail"].ToString();
            }
            else
            {
                this.Label2.Text = "No existe un usuario con dicho nombre";
            }
            conexion.Close();
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update usuarios set " + "Clave ='" + this.TxtClaveMO.Text + "',Mail='" +
                this.TxtMailMO.Text + "'where Nombre='" + this.TxtModifica1.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
            {
                this.Label5.Text = "Datos Modificados";
            }
            else
            {
                this.Label5.Text = "No existe el usuario";
            }

            conexion.Close();
        }
    }
}