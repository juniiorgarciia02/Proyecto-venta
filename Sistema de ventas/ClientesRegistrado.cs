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
    public partial class ClientesRegistrado : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;database=ventas;uid=root;pwd=westerJ2");

        public ClientesRegistrado()
        {
            InitializeComponent();
        }
        public static string dataScribViewID;
        public static string dataScribViewNombre;
        public static string dataScribViewDireccion;
        public static string dataScribViewApodo;
        public static string dataScribViewCiudad;
        public static string dataScribViewProvincia;
        public static string dataScribViewCodigoPostal;
        public static string dataScribViewTelefono;
        public static string dataScribViewEmail;
        public static string dataScribViewFax;
        public static string dataScribViewNota;
        private void ClientesRegistrado_Load(object sender, EventArgs e)
        {
            try
            { 
            conexion.Open();
            MySqlCommand cargar = new MySqlCommand("Select*From addcliente ", conexion);
            MySqlDataReader aulas = cargar.ExecuteReader();
            while (aulas.Read())
            {
                    this.dataGridView1.Rows.Add(aulas.GetValue(0), aulas.GetValue(1), aulas.GetValue(2),aulas.GetValue(3),aulas.GetValue(4),aulas.GetValue(5),aulas.GetValue(6),aulas.GetValue(7),aulas.GetValue(8),aulas.GetValue(9),aulas.GetValue(10));
                }
            }
            catch
                {

                MessageBox.Show("Error no se puede conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conexion.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //se halan los datos del datascri para ponerlo en el otro formulario
            dataScribViewID = dataGridView1.CurrentRow.Cells["cod_client"].Value.ToString();
            dataScribViewNombre = dataGridView1.CurrentRow.Cells["nomb_client"].Value.ToString();
            dataScribViewDireccion = dataGridView1.CurrentRow.Cells["direc_client"].Value.ToString();
            dataScribViewApodo= dataGridView1.CurrentRow.Cells["apodo_client"].Value.ToString();
            dataScribViewCiudad= dataGridView1.CurrentRow.Cells["ciudad_client"].Value.ToString();
            dataScribViewProvincia = dataGridView1.CurrentRow.Cells["provincia_client"].Value.ToString();
            dataScribViewCodigoPostal = dataGridView1.CurrentRow.Cells["codpost_client"].Value.ToString();
            dataScribViewTelefono = dataGridView1.CurrentRow.Cells["tell_client"].Value.ToString();
            dataScribViewEmail = dataGridView1.CurrentRow.Cells["email_client"].Value.ToString();
            
            dataScribViewFax = dataGridView1.CurrentRow.Cells["faxn_client"].Value.ToString();
            dataScribViewNota = dataGridView1.CurrentRow.Cells["notas_client"].Value.ToString();



            EditarCliente fadd = new EditarCliente();
            fadd.Show();
            this.Close();
            
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           conexion.Open();
            try
            {
                MySqlCommand cargar = new MySqlCommand(" Select * From addcliente where cod_client='" + txtBuscar.Text + "' ", conexion);
                MySqlDataReader aulas = cargar.ExecuteReader();

                while (aulas.Read())
                {
                    dataGridView1.Rows.Clear();
                    this.dataGridView1.Rows.Add(aulas.GetValue(0), aulas.GetValue(1), aulas.GetValue(2), aulas.GetValue(3), aulas.GetValue(4), aulas.GetValue(5), aulas.GetValue(6), aulas.GetValue(7), aulas.GetValue(8), aulas.GetValue(9), aulas.GetValue(10));
                }
            }
            catch {

                MessageBox.Show("No se encontro nada");
            }

            conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            reporteU adddd = new reporteU();
            
            adddd.Show();
            adddd.textBox1.Text = txtBuscar.Text;
        }
    }
    }

