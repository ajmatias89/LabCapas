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
using MetroFramework.Forms;
using MetroFramework;
using FontAwesome.Sharp;
using Presentacion.MVP;

namespace Presentacion
{
    public partial class frmLogin : MetroForm, ILoginView
    {

        private readonly LoginPresenter presenter;

        public string Usuario
        {
            get { return txtUsuario.Text.Trim(); }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        public void MostrarError(string mensaje)
        {
            MetroMessageBox.Show(this, mensaje, "Error de Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarLoginExitoso(E_Usuario usuario)
        {
            if (usuario == null || usuario.id <= 0)
            {
                MostrarError("Usuario o contraseña incorrectos.");
                return;
            }

            this.Hide();

            frmPrincipal frm = new frmPrincipal();
            frm.SESION_USUARIO = usuario;
            frm.Show();
        }

        public frmLogin()
        {
            InitializeComponent();
            CargarIconos();
            presenter = new LoginPresenter(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            presenter.IniciarSesion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void CargarIconos()
        {
            var imgUsuario = IconChar.User.ToBitmap(Color.DodgerBlue, 28);
            var imgPassword = IconChar.Lock.ToBitmap(Color.DodgerBlue, 28);
            
            txtUsuario.Icon = imgUsuario;
            txtPassword.Icon = imgPassword;
        
        }

        private bool ValidarUsuario()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim())) 
            {
                MetroMessageBox.Show(this, "Ingrese Usuario", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false; 
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Ingrese Password", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            return true;
        }
    }
}
