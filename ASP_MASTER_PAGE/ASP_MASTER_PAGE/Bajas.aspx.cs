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
    public partial class Bajas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBorrar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["SIMULACROSQLConnectionString2"].ConnectionString.ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from cliente where Id='" + DropDownList1.SelectedValue + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1) this.Label1.Text = "Se borró el usuario";
            GridView1.DataBind();
            conexion.Close();

        }
    }
}