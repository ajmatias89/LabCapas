using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Entidades;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public class frmPrincipal: MetroForm
    {
        public E_Usuario SESION_USUARIO {  get; set; }
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroPanel pnlVertical;
        private MetroFramework.Controls.MetroPanel pnlArriba;
        private PictureBox btnSlide;
        private MetroFramework.Controls.MetroPanel pnlContenedor;
        private PictureBox pbLogo;
        private PictureBox pbMinimize;
        private PictureBox pbMaximize;
        private PictureBox pbClose;
        private PictureBox pbWindow;
        private Button btnProductos;
        private Button btnMiscelaneos;
        private Button btnCompras;
        private Button btnProveedores;
        private Button btnClientes;
        private Button btnVentas;
        private Label lblHora;
        private Timer timerHora;
        private System.ComponentModel.IContainer components;
        private Label lblSesionUsuario;
        private MetroFramework.Controls.MetroLabel lblBienvenido;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = SESION_USUARIO.dsUsuario;
            lblSesionUsuario.Text = "Logged in: " + SESION_USUARIO.dsUsuario;
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblBienvenido = new MetroFramework.Controls.MetroLabel();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.pnlVertical = new MetroFramework.Controls.MetroPanel();
            this.btnMiscelaneos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlArriba = new MetroFramework.Controls.MetroPanel();
            this.pbWindow = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new MetroFramework.Controls.MetroPanel();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lblSesionUsuario = new System.Windows.Forms.Label();
            this.pnlVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBienvenido.Location = new System.Drawing.Point(715, 34);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(87, 20);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsuario.Location = new System.Drawing.Point(831, 34);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // pnlVertical
            // 
            this.pnlVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlVertical.Controls.Add(this.lblSesionUsuario);
            this.pnlVertical.Controls.Add(this.btnMiscelaneos);
            this.pnlVertical.Controls.Add(this.btnCompras);
            this.pnlVertical.Controls.Add(this.btnProveedores);
            this.pnlVertical.Controls.Add(this.btnClientes);
            this.pnlVertical.Controls.Add(this.btnVentas);
            this.pnlVertical.Controls.Add(this.btnProductos);
            this.pnlVertical.Controls.Add(this.pbLogo);
            this.pnlVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVertical.HorizontalScrollbarBarColor = true;
            this.pnlVertical.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlVertical.HorizontalScrollbarSize = 10;
            this.pnlVertical.Location = new System.Drawing.Point(20, 60);
            this.pnlVertical.Name = "pnlVertical";
            this.pnlVertical.Size = new System.Drawing.Size(250, 420);
            this.pnlVertical.TabIndex = 2;
            this.pnlVertical.UseCustomBackColor = true;
            this.pnlVertical.VerticalScrollbarBarColor = true;
            this.pnlVertical.VerticalScrollbarHighlightOnWheel = false;
            this.pnlVertical.VerticalScrollbarSize = 10;
            // 
            // btnMiscelaneos
            // 
            this.btnMiscelaneos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMiscelaneos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMiscelaneos.FlatAppearance.BorderSize = 0;
            this.btnMiscelaneos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMiscelaneos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiscelaneos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiscelaneos.ForeColor = System.Drawing.Color.White;
            this.btnMiscelaneos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiscelaneos.Location = new System.Drawing.Point(0, 316);
            this.btnMiscelaneos.Name = "btnMiscelaneos";
            this.btnMiscelaneos.Size = new System.Drawing.Size(250, 40);
            this.btnMiscelaneos.TabIndex = 7;
            this.btnMiscelaneos.Text = "Misceláneos";
            this.btnMiscelaneos.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 270);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(250, 40);
            this.btnCompras.TabIndex = 6;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 224);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(250, 40);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 178);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(250, 40);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(3, 132);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(250, 40);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 86);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(250, 40);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(224, 64);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlArriba.Controls.Add(this.pbWindow);
            this.pnlArriba.Controls.Add(this.pbMinimize);
            this.pnlArriba.Controls.Add(this.pbMaximize);
            this.pnlArriba.Controls.Add(this.pbClose);
            this.pnlArriba.Controls.Add(this.btnSlide);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.HorizontalScrollbarBarColor = true;
            this.pnlArriba.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlArriba.HorizontalScrollbarSize = 10;
            this.pnlArriba.Location = new System.Drawing.Point(270, 60);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(710, 50);
            this.pnlArriba.TabIndex = 3;
            this.pnlArriba.UseCustomBackColor = true;
            this.pnlArriba.VerticalScrollbarBarColor = true;
            this.pnlArriba.VerticalScrollbarHighlightOnWheel = false;
            this.pnlArriba.VerticalScrollbarSize = 10;
            this.pnlArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlArriba_MouseDown);
            // 
            // pbWindow
            // 
            this.pbWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbWindow.Image = ((System.Drawing.Image)(resources.GetObject("pbWindow.Image")));
            this.pbWindow.Location = new System.Drawing.Point(632, 14);
            this.pbWindow.Name = "pbWindow";
            this.pbWindow.Size = new System.Drawing.Size(30, 30);
            this.pbWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWindow.TabIndex = 6;
            this.pbWindow.TabStop = false;
            this.pbWindow.Click += new System.EventHandler(this.pbWindow_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(596, 14);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(30, 30);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 5;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbMaximize
            // 
            this.pbMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximize.Image")));
            this.pbMaximize.Location = new System.Drawing.Point(632, 14);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(30, 30);
            this.pbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximize.TabIndex = 4;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Visible = false;
            this.pbMaximize.Click += new System.EventHandler(this.pbMaximize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(668, 14);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 2;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenedor.Controls.Add(this.lblHora);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.HorizontalScrollbarBarColor = true;
            this.pnlContenedor.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlContenedor.HorizontalScrollbarSize = 10;
            this.pnlContenedor.Location = new System.Drawing.Point(270, 110);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(710, 370);
            this.pnlContenedor.TabIndex = 4;
            this.pnlContenedor.UseCustomBackColor = true;
            this.pnlContenedor.VerticalScrollbarBarColor = true;
            this.pnlContenedor.VerticalScrollbarHighlightOnWheel = false;
            this.pnlContenedor.VerticalScrollbarSize = 10;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(543, 266);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 16);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "00:00:00";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lblSesionUsuario
            // 
            this.lblSesionUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSesionUsuario.ForeColor = System.Drawing.Color.White;
            this.lblSesionUsuario.Location = new System.Drawing.Point(0, 375);
            this.lblSesionUsuario.Name = "lblSesionUsuario";
            this.lblSesionUsuario.Size = new System.Drawing.Size(250, 45);
            this.lblSesionUsuario.TabIndex = 8;
            this.lblSesionUsuario.Text = "Logged in: User";
            this.lblSesionUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlArriba);
            this.Controls.Add(this.pnlVertical);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBienvenido);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlVertical.Width == 250)
            {
                pnlVertical.Width = 70;
            }
            else
                pnlVertical.Width = 250;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbWindow.Visible = true;
            pbMaximize.Visible = false;
        }

        private void pbWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbWindow.Visible = false;
            pbMaximize.Visible = true;
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock=DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Productos());
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
