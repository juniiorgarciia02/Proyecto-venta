using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_ventas
{
    public partial class EditarCliente : Form
    {
        MySqlConnection conex = new MySqlConnection("server=localhost;database=ventas;uid=root;pwd=westerJ2");

        public EditarCliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conex.Open();
                try
                {
                    //Guardar datos en la base de datos
                    MySqlCommand add = new MySqlCommand("Update addcliente Set nomb_client='" + txtnombre.Text + "',direc_client='" + txtdireccion.Text + "',apodo_client='" + txtapodo.Text + "',ciudad_client='" + txtciudad.Text + "',provincia_client='" + txtprovincia.Text + "',codpost_client='" + txtprovincia.Text + "',tell_client='" + txttelefono.Text + "',email_client='" + txtemail.Text + "',faxn_client='" + txtfax.Text + "',notas_client='" + txtnotas.Text + "' Where cod_client='" + txtid.Text + "'", conex);
                    MySqlDataReader guardar = add.ExecuteReader();
                    MessageBox.Show("Los Datos Fueron Actualizados", "Guardado");


                }
                catch
                {
                    MessageBox.Show("Error no se puede guardar intentelo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conex.Close();
            }
            catch
            {
                MessageBox.Show("Error con la conexion de la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button5.Enabled = true;
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txtciudad.Enabled = true;
            txtapodo.Enabled = true;
            txtcodigopostal.Enabled = true;
            txtemail.Enabled = true;
            txtfax.Enabled = true;
            txttelefono.Enabled = true;
            txtnotas.Enabled = true;
            txtprovincia.Enabled = true;


            //cargar los datos en otro formulario del datascrib
            txtid.Text = ClientesRegistrado.dataScribViewID;
            txtnombre.Text = ClientesRegistrado.dataScribViewNombre;
            txtdireccion.Text = ClientesRegistrado.dataScribViewDireccion;
            txtapodo.Text = ClientesRegistrado.dataScribViewApodo;
            txtciudad.Text = ClientesRegistrado.dataScribViewCiudad;
            txtprovincia.Text = ClientesRegistrado.dataScribViewProvincia;
            txtcodigopostal.Text = ClientesRegistrado.dataScribViewCodigoPostal;
            txttelefono.Text = ClientesRegistrado.dataScribViewTelefono;
            txtemail.Text = ClientesRegistrado.dataScribViewEmail;
            txtfax.Text = ClientesRegistrado.dataScribViewFax;
            txtnotas.Text = ClientesRegistrado.dataScribViewNota;
        }
        Double valor;
        String suma;
        private void button5_Click(object sender, EventArgs e)
        {
            ClientesRegistrado h = new ClientesRegistrado();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Habilitar funciones en los botones

          
         
            button2.Enabled = true;
            button5.Visible = true;

            button3.Enabled = false;
            button4.Enabled = false;

            txtnombre.Enabled = true;
            txtapodo.Enabled = true;
            txtciudad.Enabled = true;
            txtcodigopostal.Enabled = true;
            txtdireccion.Enabled = true;
            txtemail.Enabled = true;
            txtnotas.Enabled = true;
            txttelefono.Enabled = true;
            txtprovincia.Enabled = true;
            txtfax.Enabled = true;


            //Borrar Todos en los TxBox


            txtnombre.Clear();
            txtdireccion.Clear();
            txtapodo.Clear();
            txtciudad.Clear();
            txtcodigopostal.Clear();
            txtfax.Clear();
            txtnotas.Clear();
            txttelefono.Clear();
            txtprovincia.Text = "";
            txtemail.Clear();

            conex.Open();
            MySqlCommand id = new MySqlCommand("SELECT cod_client FROM addcliente ORDER BY cod_client DESC LIMIT 1", conex);
            MySqlDataReader sumaid = id.ExecuteReader();
            if (sumaid.Read())
            {

                valor = Convert.ToDouble(sumaid["cod_client"]);
                suma = Convert.ToString(valor + 1);
                txtid.Text = suma;



            }
            else
            {
                MessageBox.Show("Fatal Error no se puede Mostrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conex.Close();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapodo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
