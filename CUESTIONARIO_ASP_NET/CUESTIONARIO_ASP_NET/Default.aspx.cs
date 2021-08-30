using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CUESTIONARIO_ASP_NET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            
               
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int lab = 0;
            if (RadioButton3.Checked == true) lab = lab + 1;
            if (RadioButton5.Checked == true) lab = lab + 1;
            if (RadioButton9.Checked == true) lab = lab + 1;

            Label4.Text = "Has acertado " + lab;
            if (lab > 0)
            {
                rick.Visible = true;
            }

            if (IsValid)
                Response.Redirect("acceso permitido.aspx");
        }
    }
}