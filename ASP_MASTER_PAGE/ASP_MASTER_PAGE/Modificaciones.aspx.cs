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
    public partial class Modificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString2"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Id, Nombre, Apellido1, Apellido2, Ciudad, Categoria from cliente " +
                "where Id='" + DropDownList1.SelectedValue + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.TxtNomMo.Text =  registro["Nombre"].ToString();
                this.TxtAp1Mo.Text =  registro["Apellido1"].ToString();
                this.TxtAp2Mo.Text =  registro["Apellido2"].ToString();
                this.TxtCiudadMo.Text = registro["Ciudad"].ToString();
                this.TxtCatMo.Text =  registro["Categoria"].ToString();
            }
            else
            {
                this.LblError.Text = "Seleccione un ID";
            }
            conexion.Close();
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString2"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update cliente set " + "Nombre='" + this.TxtNomMo.Text + "',Apellido1='" + this.TxtAp1Mo.Text + "',Apellido2='" + this.TxtAp2Mo.Text + "',Ciudad='" +
                this.TxtCiudadMo.Text + "',Categoria='" + this.TxtCatMo.Text + "'where Id='" + DropDownList1.SelectedValue + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
            {
                this.LblError.Text = "Datos modificados";
            }
            else
            {
                this.LblError.Text = "No existe el usuario";
            }
            conexion.Close();
        }
    }
}