using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_CONECTADO
{
    public partial class Form1 : Form
    {
        //explorador de servidores -> desktop local -> propiedades -> cadena de conexion
        private string conexion = @"Data Source=.;Initial Catalog=PersonaBD;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_alta_Click(object sender, EventArgs e)
        {
            //abrimos conexion con sqlconnetion y por el constructor pasamos el string
            using (SqlConnection sqlConnection = new SqlConnection(conexion))
            {
                //abrimos conexion
                sqlConnection.Open();
                //creamos el comando
                using (SqlCommand command = new SqlCommand())
                {
                    //explorador de servidores -> desktop local -> nueva consulta -> se abre tab de consultas
                    //insert into Persona values (1,'franco','fazzito');
                    command.Connection = sqlConnection;
                    command.CommandText = "insert into persona values (@codigo , @nombre , @apellido )"; /*referencia al nombre de la columna*/

                    //valores de los textbox
                    int codigo = int.Parse(txt_codigo.Text);
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;

                    //añadimos los parametros con el valor de los textbox
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);

                    //ejecutamos la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //añadimos la persona
            List<Persona> personas = new List<Persona>();

            //abrimos conexion con sqlconnetion y por el constructor pasamos el string
            using (SqlConnection sqlConnection = new SqlConnection(conexion))
            {
                //abrimos conexion
                sqlConnection.Open();
                //creamos el comando
                using (SqlCommand command = new SqlCommand())
                {
                    //definimos el select y la conexion
                    command.Connection = sqlConnection;
                    command.CommandText = "select * from persona";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //mientras haya para leer con read
                        while (reader.Read())
                        {
                            //tomamos los datos a leer con los metodos de get seguido del tipo
                            int codigo = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string apellido = reader.GetString(2);
                            //creamos una nueva persona con lo leido
                            Persona mostrar = new Persona(codigo, nombre, apellido);
                            //añadimos a la lista
                            personas.Add(mostrar);
                        }
                    }
                }
            }
            mostrar(personas);
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            //abrimos conexion con sqlconnetion y por el constructor pasamos el string
            using (SqlConnection sqlConnection = new SqlConnection(conexion))
            {
                //abrimos conexion
                sqlConnection.Open();
                //creamos el comando
                using (SqlCommand command = new SqlCommand())
                {
                    //ponemos la conexion
                    command.Connection = sqlConnection;
                    //ponemos el comando
                    command.CommandText = "delete from persona where codigo = @codigo";
                    //tomamos el codigo
                    int codigo = int.Parse(txt_codigo.Text);
                    //añadimos los parametros el codigo
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void mostrar(List<Persona> personas)
        {
            DGV_persona.DataSource = null;
            DGV_persona.DataSource = personas;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conexion))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    //ponemos la conexion
                    command.Connection = sqlConnection;
                    //ponemos la consulta
                    command.CommandText = "update persona set nombre = @nombre , apellido = @apellido where codigo = @codigo";

                    //valores de los textbox
                    int codigo = int.Parse(txt_codigo.Text);
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;

                    //añadimos los parametros con el valor de los textbox
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);

                    //ejecutamos la consulta
                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
