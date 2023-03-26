using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
   
    public partial class LoginForm : Form
    {

    
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CodigoUsuarioTextBox.Focus();
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aceptarbutton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuarioTextBox, "ingrese un usuario ");
                return;
            }
            errorProvider1.Clear();
            if (ContraseñaTextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñaTextBox, "ingrese una contraseña ");
                return;
            }
            errorProvider1.Clear();
            // validar usuario en la base de datos

            Login login = new Login(CodigoUsuarioTextBox.Text, ContraseñaTextBox.Text);

            TicketDB usuarioDB = new TicketDB();
            Usuario usuario = new Usuario();

            usuario = usuarioDB.Autenticar(login);
            if (usuario != null)
            {
  
               
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContraseñaTextBox.PasswordChar = '*';
            }
        }
    }
}