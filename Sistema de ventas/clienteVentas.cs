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
    public partial class clienteVentas : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;database=ventas;uid=root;pwd=westerJ2");


        public clienteVentas()
        {
            InitializeComponent();
        }
        public static string CodClienteVentaS;
        public static string NombreClienteVentas;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CodClienteVentaS = dataGridView1.CurrentRow.Cells["cod_client"].Value.ToString();
            NombreClienteVentas = dataGridView1.CurrentRow.Cells["nomb_client"].Value.ToString();
            Ventas fadd = new Ventas();
            fadd.Show();
            this.Close();
        }

        private void clienteVentas_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MySqlCommand cargar = new MySqlCommand("Select*From addcliente ", conexion);
                MySqlDataReader aulas = cargar.ExecuteReader();
                while (aulas.Read())
                {
                    this.dataGridView1.Rows.Add(aulas.GetValue(0), aulas.GetValue(1), aulas.GetValue(2), aulas.GetValue(3), aulas.GetValue(4), aulas.GetValue(5), aulas.GetValue(6), aulas.GetValue(7), aulas.GetValue(8), aulas.GetValue(9), aulas.GetValue(10));
                }
            }
            catch
            {

                MessageBox.Show("Error no se puede conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conexion.Close();

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
            catch
            {

                MessageBox.Show("No se encontro nada");
            }

            conexion.Close();
        }
    }
}
