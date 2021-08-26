using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace primer_ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Label1.Text);
            x++;
            Label1.Text = x.ToString();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                int resultado;
                int x1 = int.Parse(TextBox1.Text);
                int x2 = int.Parse(TextBox2.Text);
                resultado = x1 + x2;
                Label3.Text = "La suma de los dos valores es:" + resultado;
            }
            else
            {



                if (RadioButton2.Checked)
                {
                    int resultado;
                    int x1 = int.Parse(TextBox1.Text);
                    int x2 = int.Parse(TextBox2.Text);
                    resultado = x1 - x2;
                    Label3.Text = "La resta de los dos valores es:" + resultado;
                }
                else
                {

                    if (RadioButton3.Checked)
                    {
                        int resultado;
                        int x1 = int.Parse(TextBox1.Text);
                        int x2 = int.Parse(TextBox2.Text);
                        resultado = x1 * x2;
                        Label3.Text = "La multiplicacion de los dos valores es:" + resultado;
                    }
                    else
                    {



                        if (RadioButton4.Checked)
                        {
                            int resultado;
                            int x1 = int.Parse(TextBox1.Text);
                            int x2 = int.Parse(TextBox2.Text);
                            resultado = x1 / x2;
                            Label3.Text = "La division de los dos valores es:" + resultado;
                        }
                    }
                }
            }
        }
    }
}