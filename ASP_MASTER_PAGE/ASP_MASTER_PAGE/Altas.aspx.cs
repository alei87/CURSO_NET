using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASP_MASTER_PAGE
{
    public partial class Altas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAniadir_Click(object sender, EventArgs e)
        {
            
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString2"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            if (IsValid)
            {

                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into cliente(Id, Nombre, Apellido1, Apellido2, Ciudad, Categoria) values('" + this.TxtID.Text +
                    "','" + this.TxtNombre.Text + "','" + this.TxtApe1.Text + "','" + this.TxtApe2.Text + "','" + this.TxtCiudad.Text + "','" + this.TxtCategoria.Text + "')", conexion);
                int cantidad=comando.ExecuteNonQuery();
                if(cantidad==1)
                LblError.Text = "Se registró el usuario";
                else
                {
                    LblError.Text = "Ha habido algún error ";
                }
                conexion.Close();
            }
        }
    }
}