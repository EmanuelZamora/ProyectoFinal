using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Disco : System.Web.UI.Page
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
            SqlCommand comando = new SqlCommand("insert into Disco(UPC, nombre_disco, ID_formato_disco, annio_produccion, duracion_del_disco, portada_, cantidad_de_canciones, ID_creador) values ('" +
                TextBox6.Text + "', '" + this.TextBox1.Text + "','" + TextBox2.Text + "','" + this.TextBox3.Text + "','" + TextBox4.Text + "','" + this.TextBox5.Text + "','" + TextBox7.Text + "','" + this.TextBox8 + "')", conexion);
            comando.ExecuteNonQuery();
            Label1.Visible = true;
            Label1.Text = "Registro agregado";
            conexion.Close();
        }
    }
}