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
    public partial class Ventas : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;database=ventas;uid=root;pwd=westerJ2");

        public Ventas()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            clienteVentas clientventas = new clienteVentas();

            clientventas.Show();
            
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            //tasa de venta
            textBox13.Text = "0.18";

            //cargar los datos en otro formulario del datascrib
            textBox3.Text = clienteVentas.CodClienteVentaS;
            textBox4.Text = clienteVentas.NombreClienteVentas;

            conexion.Open();
            MySqlCommand cargar = new MySqlCommand("Select* From addstock ", conexion);
                MySqlDataReader aulas = cargar.ExecuteReader();
                while (aulas.Read())
                {
                    this.dataGridView2.Rows.Add(aulas.GetValue(0), aulas.GetValue(1), aulas.GetValue(2), aulas.GetValue(3), aulas.GetValue(4), aulas.GetValue(5), aulas.GetValue(6));
                }
            conexion.Close();
          
           


   
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells["nomb_product1"].Value.ToString();
            txtprecio.Text = dataGridView2.CurrentRow.Cells["prec_product"].Value.ToString();
            txtCantidadDisponible.Text = dataGridView2.CurrentRow.Cells["cantid_product"].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells["stockid_product"].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

            
        }
        private void txtCantidadVender_TextChanged(object sender, EventArgs e)
        {
            try
            { 
            if(Convert.ToDouble(txtCantidadVender.Text)> Convert.ToDouble(txtCantidadDisponible.Text)) 

                MessageBox.Show("Cantidad requeridad es mayor que la existencia");
                else
                
            txtTotalVenta.Text = Convert.ToString(Convert.ToDouble(txtCantidadVender.Text) * Convert.ToDouble(txtprecio.Text));
            }
            catch
                {

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(textBox5.Text, textBox2.Text, txtprecio.Text, txtCantidadVender.Text, txtTotalVenta.Text);
          

            if (Convert.ToDouble(txtCantidadVender.Text) >= Convert.ToDouble(txtCantidadDisponible.Text))
            {

                MessageBox.Show("ERROR, La cantidad a vender no puede ser mayor a la cantidad disponible");

            }
            txtCantidadVender.Clear();
            txtTotalVenta.Clear();
            textBox2.Clear();
            txtprecio.Clear();
            txtCantidadDisponible.Clear();
        }

        private void txtCantidadDisponible_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTotalVenta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double totalfactura = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalfactura += Convert.ToDouble(row.Cells["total_product"].Value);
            }
            textBox14.Text = Convert.ToString(totalfactura);
           

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox14.Text))
            {
                MessageBox.Show("Ningun Producto registrado");
            }
         
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
             }

        private void button1_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;


            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            txtprecio.Enabled = true;
            txtCantidadDisponible.Enabled = true;
            txtnotas.Enabled = true;
            txtprecio.Enabled = true;
            txtTotalVenta.Enabled = true;
            txtCantidadVender.Enabled = true;


            button5.Enabled = true;
            button6.Enabled = true;
            


        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                MySqlCommand buscarVentas = new MySqlCommand(" Select * From addcliente where cod_client='" + textBox1.Text + "' ", conexion);
                MySqlDataReader ventaBus = buscarVentas.ExecuteReader();

                while (ventaBus.Read())
                {
                    dataGridView2.Rows.Clear();
                    this.dataGridView2.Rows.Add(ventaBus.GetValue(0), ventaBus.GetValue(1), ventaBus.GetValue(2), ventaBus.GetValue(3), ventaBus.GetValue(4), ventaBus.GetValue(5));
                        }
            }
            catch
            {

                MessageBox.Show("No se encontro nada");
            }

            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
