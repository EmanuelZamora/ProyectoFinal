using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Autor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s =
    System.Configuration.ConfigurationManager.ConnectionStrings["Cadenaconexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into Autor(ID_autor, DPI_autor) values ('" +
                TextBox1.Text + "', '" + this.TextBox2.Text + "')", conexion);
            comando.ExecuteNonQuery();
            Label1.Visible = true;
            Label1.Text = "Registro agregado";
            conexion.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s =
   System.Configuration.ConfigurationManager.ConnectionStrings["Cadenaconexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from Autor Where DPI_autor = ('" + TextBox2.Text + "')", conexion);
            comando.ExecuteNonQuery();
            Label2.Visible = true;
            Label2.Text = "Registro eliminado";
            conexion.Close();
        }
    }
}