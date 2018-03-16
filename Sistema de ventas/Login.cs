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
    public partial class Login : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;database=ventas1;uid=root;pwd=12345678");
        public Login()
        {
            InitializeComponent();
        }
        public static string nombre_usu;
        public static string tipo_usu;
        public static int id_usu;

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE tipo_usuario='" + textBox1.Text + "'AND password=md5('" +textBox2.Text + "') ", conexion);
            MySqlDataReader leer;
            leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                nombre_usu = Convert.ToString(leer.GetValue(1));
                tipo_usu = Convert.ToString(leer.GetValue(7));
                id_usu = Convert.ToInt16(leer.GetValue(0));

                this.Hide();
                MenuPrincipal menuprincipal = new MenuPrincipal();
                menuprincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectas", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            conexion.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", " Aviso ", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //Cerrar Formulario
                Application.Exit();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Minimax Formulario
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);
            textBox1.SelectionStart = textBox1.Text.Length;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
