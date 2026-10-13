using Entidades;
using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string strUsuario = txtUsuario.Text;
            string strPassword = txtPassword.Text;
            E_Usuario usuario = N_Usuario.Login(strUsuario, strPassword);

            if (usuario != null && usuario.id > 0)
            {
                MessageBox.Show("Bienvenido, " + usuario.dsUsuario + "!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
