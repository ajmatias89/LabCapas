namespace Presentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlLateral = new MetroFramework.Controls.MetroPanel();
            this.btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.pbxLogin = new FontAwesome.Sharp.IconPictureBox();
            this.pnlLineaSuperior = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pnlLineaInferior = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(535, 449);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLateral.BackgroundImage")));
            this.pnlLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLateral.HorizontalScrollbarBarColor = true;
            this.pnlLateral.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLateral.HorizontalScrollbarSize = 10;
            this.pnlLateral.Location = new System.Drawing.Point(23, 94);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(303, 383);
            this.pnlLateral.TabIndex = 6;
            this.pnlLateral.VerticalScrollbarBarColor = true;
            this.pnlLateral.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLateral.VerticalScrollbarSize = 10;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.btnIniciarSesion.IconColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesion.IconSize = 28;
            this.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(504, 368);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(219, 48);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(397, 192);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 20);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(397, 291);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(189, 2);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.DisplayIcon = true;
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(504, 192);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Ingrese Usuario";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(219, 36);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.UseCustomBackColor = true;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Ingrese Usuario";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(189, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(504, 291);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Ingrese password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(219, 36);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Ingrese password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbxLogin
            // 
            this.pbxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbxLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxLogin.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.pbxLogin.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxLogin.IconSize = 94;
            this.pbxLogin.Location = new System.Drawing.Point(535, 34);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(94, 111);
            this.pbxLogin.TabIndex = 12;
            this.pbxLogin.TabStop = false;
            // 
            // pnlLineaSuperior
            // 
            this.pnlLineaSuperior.BackColor = System.Drawing.Color.Gray;
            this.pnlLineaSuperior.HorizontalScrollbarBarColor = true;
            this.pnlLineaSuperior.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLineaSuperior.HorizontalScrollbarSize = 10;
            this.pnlLineaSuperior.Location = new System.Drawing.Point(409, 151);
            this.pnlLineaSuperior.Name = "pnlLineaSuperior";
            this.pnlLineaSuperior.Size = new System.Drawing.Size(350, 1);
            this.pnlLineaSuperior.TabIndex = 13;
            this.pnlLineaSuperior.UseCustomBackColor = true;
            this.pnlLineaSuperior.VerticalScrollbarBarColor = true;
            this.pnlLineaSuperior.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLineaSuperior.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gray;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(409, 158);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(350, 1);
            this.metroPanel1.TabIndex = 14;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pnlLineaInferior
            // 
            this.pnlLineaInferior.BackColor = System.Drawing.Color.Gray;
            this.pnlLineaInferior.HorizontalScrollbarBarColor = true;
            this.pnlLineaInferior.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLineaInferior.HorizontalScrollbarSize = 10;
            this.pnlLineaInferior.Location = new System.Drawing.Point(409, 442);
            this.pnlLineaInferior.Name = "pnlLineaInferior";
            this.pnlLineaInferior.Size = new System.Drawing.Size(350, 1);
            this.pnlLineaInferior.TabIndex = 15;
            this.pnlLineaInferior.UseCustomBackColor = true;
            this.pnlLineaInferior.VerticalScrollbarBarColor = true;
            this.pnlLineaInferior.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLineaInferior.VerticalScrollbarSize = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pnlLineaInferior);
            this.Controls.Add(this.pnlLineaSuperior);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.btnSalir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Ingreso de Usuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private MetroFramework.Controls.MetroPanel pnlLateral;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox pbxLogin;
        private MetroFramework.Controls.MetroPanel pnlLineaSuperior;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel pnlLineaInferior;
    }
}

