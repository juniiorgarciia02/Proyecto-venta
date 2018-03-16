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
    public partial class Usuario : Form
    {
        MySqlConnection conex = new MySqlConnection("server=localhost;database=ventas1;uid=root;pwd=12345678");
        public Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlCommand eliminar = new MySqlCommand("Delete from usuario where cod_usuario= '" + txtid.Text + "'", conex);
            conex.Open();
            try
            {


                eliminar.ExecuteNonQuery();
                //Limpiar textbox
                txtid.Clear();
                txtnombre.Clear();
                txttipo.Clear();
                txtpasw.Clear();

            }
            catch
            {
                MessageBox.Show("Error No se puede borrar, Por Favor intentelo mas tarde", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conex.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conex.Open();
                MySqlCommand insert = new MySqlCommand("insert into  usuario values('"+txtid.Text+"','"+txtnombre.Text+"','"+txttipo.Text+"', md5('"+txtpasw.Text+"'))",conex);
                insert.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            conex.Close();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                conex.Open();
                MySqlCommand cargar = new MySqlCommand("Select *  From usuario", conex);
                MySqlDataReader aulas = cargar.ExecuteReader();
                while (aulas.Read())
                {
                    this.dataGridView1.Rows.Add(aulas.GetValue(0), aulas.GetValue(1), aulas.GetValue(2), aulas.GetValue(3));
                        }
            }
            catch
            {

                MessageBox.Show("Error no se puede conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conex.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
                conex.Open();
            try
            {
               
                //Actualizar datos en la base de datos
                MySqlCommand add = new MySqlCommand("Update login Set nombre='" + txtnombre.Text + "',tipo_usuario='" + txttipo.Text + "',password='" + txtpasw.Text + "' Where cod_login='" + txtid.Text + "'", conex);
                MySqlDataReader guardar = add.ExecuteReader();
                MessageBox.Show("Los Datos Fueron Actualizados", "Guardado");
                Usuario user = new Usuario();
                this.Hide();
                user.Show();

            }
            catch {
                MessageBox.Show("Error no se puede Actualizar intentelo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text= dataGridView1.CurrentRow.Cells["cod_login"].Value.ToString();
            txtnombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            txttipo.Text = dataGridView1.CurrentRow.Cells["tipo_usuario"].Value.ToString();
            txtpasw.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
