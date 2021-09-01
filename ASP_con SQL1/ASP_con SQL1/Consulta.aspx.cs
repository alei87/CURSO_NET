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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Nombre, Clave, Mail from usuarios " +
                "where Nombre='" + this.TxtNombreCon.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.Label2.Text = "Clave:" + registro["Clave"] + "<br>" + "Mail:" + registro["Mail"];

            }
            else
            {
                this.Label2.Text = "No existe un usuario con dicho nombre";
            }
            conexion.Close();
        }
    }
}