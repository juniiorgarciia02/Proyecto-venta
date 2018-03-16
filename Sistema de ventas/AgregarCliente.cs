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
    public partial class AgregarCliente : Form
    {
        MySqlConnection conex = new MySqlConnection("server=localhost;database=ventas;uid=root;pwd=westerJ2");
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClientesRegistrado h = new ClientesRegistrado();
            h.Show();
            this.Hide();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtnombre.Text == "" || txtdireccion.Text == "" || txtciudad.Text == "" || txtprovincia.Text == "" || txtcodigopostal.Text == "" || txttelefono.Text == "" )
                {
                    MessageBox.Show( "Debe Llenar los campos con * ");
                   
                }
                else
                {
                    conex.Open();
                    MySqlCommand insert = new MySqlCommand("insert into addcliente values('" + txtid.Text + "','" + txtnombre.Text + "','" + txtdireccion.Text + "','" + txtapodo.Text + "','" + txtciudad.Text + "','" + txtprovincia.Text + "','" + txtcodigopostal.Text + "','" + txttelefono.Text + "','" + txtemail.Text + "','" + txtfax.Text + "','" + txtnotas.Text + "') ", conex);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Guardado Existoso", "Datos Guardado", MessageBoxButtons.OK);
                    this.Hide();
                    AgregarCliente adds = new AgregarCliente();
                    adds.Show();

                }
            }
            catch
            {
                MessageBox.Show("Error no se pudo guardar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conex.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conex.Open();
                try
                {
                    //Guardar datos en la base de datos
                    MySqlCommand add = new MySqlCommand("Update addcliente Set nomb_client='" + txtnombre.Text + "',direc_client='" +txtdireccion.Text + "',apodo_client='"+txtapodo.Text+"',ciudad_client='"+txtciudad.Text+"',provincia_client='"+txtprovincia.Text+"',codpost_client='"+txtprovincia.Text+"',tell_client='"+txttelefono.Text+"',email_client='"+txtemail.Text+"',faxn_client='"+txtfax.Text+"',notas_client='"+txtnotas.Text+"' Where cod_client='" + txtid.Text + "'", conex);
                    MySqlDataReader guardar = add.ExecuteReader();
                    MessageBox.Show("Los Datos Fueron Actualizados", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  

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
        Double valor;
        String suma;
        private void AgregarCliente_Load(object sender, EventArgs e)
        {

            //Incrementar cod

          


            
          
            }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text);
            txtnombre.SelectionStart = txtnombre.Text.Length;

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            txtdireccion.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtdireccion.Text);
            txtdireccion.SelectionStart = txtdireccion.Text.Length;

        }

        private void txtapodo_TextChanged(object sender, EventArgs e)
        {
            txtapodo.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtapodo.Text);
            txtapodo.SelectionStart = txtapodo.Text.Length;

        }

        private void txtciudad_TextChanged(object sender, EventArgs e)
        {
            txtciudad.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtciudad.Text);
            txtciudad.SelectionStart = txtciudad.Text.Length;

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

            txtemail.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtemail.Text);
            txtemail.SelectionStart = txtemail.Text.Length;

        }

      
        private void txtnotas_TextChanged(object sender, EventArgs e)
        {
            txtnotas.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnotas.Text);
            txtnotas.SelectionStart = txtnotas.Text.Length;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


          
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
       
        private void button1_Click(object sender, EventArgs e)

        {
           //Habilitar funciones en los botones

            button3.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = true;
            button5.Visible = true;

           
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

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand eliminar = new MySqlCommand("Delete from addcliente where cod_client= '" + txtid.Text + "'", conex);
            conex.Open();
            try
            {
                

                eliminar.ExecuteNonQuery();
                //Limpiar textbox
                txtid.Clear();
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
            }
            catch
            {
                MessageBox.Show("Error No se puede borrar, Por Favor intentelo mas tarde", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conex.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
