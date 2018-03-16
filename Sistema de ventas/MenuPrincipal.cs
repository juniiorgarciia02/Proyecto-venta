using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCliente addcliente = new AgregarCliente();
            addcliente.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuario irusuario = new Usuario();
            irusuario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", " Aviso ", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //Cerrar Formulario
                Application.Exit();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addStock stock = new addStock();
            stock.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", " Aviso ", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //Cerrar Formulario
                Login loginnn = new Login();
                loginnn.Show();
                this.Hide();

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Minimax Formulario
            WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventas showVentas = new Ventas();
            showVentas.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
           
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Login.tipo_usu == "Administrador" || Login.tipo_usu =="Administrador")
            {
                button7.Visible = true;
                label3.Text = Login.nombre_usu;
                label4.Text = Login.nombre_usu;
                label5.Text = Login.tipo_usu;

            } 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reporteU add = new reporteU();
            add.Show();
        }
    }
}
