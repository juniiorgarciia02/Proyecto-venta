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
    public partial class addStock : Form
    {
        MySqlConnection conex = new MySqlConnection("server=localhost;database=ventas;uid=root;pwd=westerJ2");

        public addStock()
        {
            InitializeComponent();
        }

        private void addStock_Load(object sender, EventArgs e)
        {

            conex.Open();
            
            {
                MySqlCommand cargar = new MySqlCommand(" Select * From addstock  ", conex);
                MySqlDataReader aulas = cargar.ExecuteReader();

                while (aulas.Read())
                {
                   
                    this.dataGridView1.Rows.Add(aulas.GetValue(0), aulas.GetValue(1), aulas.GetValue(2), aulas.GetValue(3), aulas.GetValue(4), aulas.GetValue(5), aulas.GetValue(6));
                }
            }
          

            conex.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text == "" || txtConfId.Text== "" || txtNombre.Text == "" || txtCaracteristica.Text == "" || txtprecio.Text== "" || txtPrecioTotal.Text== "" || txtCantidad.Text=="")
                {
                    MessageBox.Show("Debe Llenar los campos con * ");

                }
                else
                {
                    conex.Open();
                    MySqlCommand insert = new MySqlCommand("insert into addstock values('" + txtid.Text + "','" +txtConfId.Text + "','" + txtNombre.Text + "','" + txtCaracteristica.Text + "','" +txtprecio.Text+ "','" + txtCantidad.Text + "','" + txtPrecioTotal.Text + "','" + txtFecha.Text+ "') ", conex);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Guardado Existoso", "Datos Guardado", MessageBoxButtons.OK);
                    this.Hide();
                    addStock adddd = new addStock();
                    adddd.Show();
                   
                }
            }
            catch
            {
                MessageBox.Show("Error no se pudo guardar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conex.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["cod_stock"].Value.ToString();
            txtConfId.Text = dataGridView1.CurrentRow.Cells["confid"].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells["nombreproducto"].Value.ToString();
            txtCaracteristica.Text = dataGridView1.CurrentRow.Cells["caracteristica"].Value.ToString();
            txtprecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
            txtCantidad.Text = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
            txtPrecioTotal.Text = dataGridView1.CurrentRow.Cells["preciototal"].Value.ToString();
            
        }
    }
}
