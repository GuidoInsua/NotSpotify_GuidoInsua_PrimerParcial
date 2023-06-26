namespace NotSpotify.InterfazGrafica
{
    partial class FrmLogin
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
            tbx_loginMail = new TextBox();
            tbx_loginPassword = new TextBox();
            btn_loginAceptar = new Button();
            btn_completarUsuario = new Button();
            lbl_loginLabel = new Label();
            lbl_loginPassword = new Label();
            pbx_loginLogo = new PictureBox();
            pnl_topBar = new PanelMovimiento();
            btn_cerrar = new Controles.BotonCerrar();
            lbl_mensajeError = new Label();
            btn_completarAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx_loginLogo).BeginInit();
            SuspendLayout();
            // 
            // tbx_loginMail
            // 
            tbx_loginMail.BackColor = Color.Gray;
            tbx_loginMail.BorderStyle = BorderStyle.None;
            tbx_loginMail.ForeColor = Color.White;
            tbx_loginMail.Location = new Point(138, 173);
            tbx_loginMail.Name = "tbx_loginMail";
            tbx_loginMail.Size = new Size(236, 16);
            tbx_loginMail.TabIndex = 0;
            tbx_loginMail.Leave += tbx_loginMail_Leave;
            // 
            // tbx_loginPassword
            // 
            tbx_loginPassword.BackColor = Color.Gray;
            tbx_loginPassword.BorderStyle = BorderStyle.None;
            tbx_loginPassword.ForeColor = Color.White;
            tbx_loginPassword.Location = new Point(138, 214);
            tbx_loginPassword.Name = "tbx_loginPassword";
            tbx_loginPassword.PasswordChar = '*';
            tbx_loginPassword.Size = new Size(236, 16);
            tbx_loginPassword.TabIndex = 1;
            tbx_loginPassword.Leave += tbx_loginPassword_Leave;
            // 
            // btn_loginAceptar
            // 
            btn_loginAceptar.BackColor = Color.FromArgb(0, 192, 0);
            btn_loginAceptar.FlatAppearance.BorderSize = 0;
            btn_loginAceptar.FlatStyle = FlatStyle.Flat;
            btn_loginAceptar.Location = new Point(280, 255);
            btn_loginAceptar.Name = "btn_loginAceptar";
            btn_loginAceptar.Size = new Size(94, 26);
            btn_loginAceptar.TabIndex = 2;
            btn_loginAceptar.Text = "Aceptar";
            btn_loginAceptar.UseVisualStyleBackColor = false;
            btn_loginAceptar.Click += btn_loginAceptar_Click;
            // 
            // btn_completarUsuario
            // 
            btn_completarUsuario.BackColor = Color.FromArgb(0, 192, 0);
            btn_completarUsuario.FlatAppearance.BorderSize = 0;
            btn_completarUsuario.FlatStyle = FlatStyle.Flat;
            btn_completarUsuario.Location = new Point(209, 255);
            btn_completarUsuario.Name = "btn_completarUsuario";
            btn_completarUsuario.Size = new Size(65, 26);
            btn_completarUsuario.TabIndex = 3;
            btn_completarUsuario.Text = "Usuario";
            btn_completarUsuario.UseVisualStyleBackColor = false;
            btn_completarUsuario.Click += btn_completarUsuario_Click;
            // 
            // lbl_loginLabel
            // 
            lbl_loginLabel.AutoSize = true;
            lbl_loginLabel.BackColor = Color.Transparent;
            lbl_loginLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_loginLabel.ForeColor = Color.Silver;
            lbl_loginLabel.Location = new Point(138, 151);
            lbl_loginLabel.Name = "lbl_loginLabel";
            lbl_loginLabel.Size = new Size(41, 19);
            lbl_loginLabel.TabIndex = 4;
            lbl_loginLabel.Text = "Email";
            // 
            // lbl_loginPassword
            // 
            lbl_loginPassword.AutoSize = true;
            lbl_loginPassword.BackColor = Color.Transparent;
            lbl_loginPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_loginPassword.ForeColor = Color.Silver;
            lbl_loginPassword.Location = new Point(138, 192);
            lbl_loginPassword.Name = "lbl_loginPassword";
            lbl_loginPassword.Size = new Size(67, 19);
            lbl_loginPassword.TabIndex = 5;
            lbl_loginPassword.Text = "Password";
            // 
            // pbx_loginLogo
            // 
            pbx_loginLogo.BackColor = Color.Black;
            pbx_loginLogo.Image = Properties.Resources.NotSpotifyLogo;
            pbx_loginLogo.Location = new Point(0, 0);
            pbx_loginLogo.Name = "pbx_loginLogo";
            pbx_loginLogo.Size = new Size(139, 79);
            pbx_loginLogo.TabIndex = 6;
            pbx_loginLogo.TabStop = false;
            // 
            // pnl_topBar
            // 
            pnl_topBar.BackColor = Color.Transparent;
            pnl_topBar.Dock = DockStyle.Top;
            pnl_topBar.Location = new Point(0, 0);
            pnl_topBar.Name = "pnl_topBar";
            pnl_topBar.Size = new Size(524, 78);
            pnl_topBar.TabIndex = 8;
            pnl_topBar.Load += pnl_topBar_Load;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.Transparent;
            btn_cerrar.BackgroundImageLayout = ImageLayout.Center;
            btn_cerrar.Location = new Point(503, 0);
            btn_cerrar.Margin = new Padding(0);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(21, 21);
            btn_cerrar.TabIndex = 9;
            btn_cerrar.MyClick += btn_cerrar_Click;
            // 
            // lbl_mensajeError
            // 
            lbl_mensajeError.AutoSize = true;
            lbl_mensajeError.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_mensajeError.Location = new Point(152, 119);
            lbl_mensajeError.Name = "lbl_mensajeError";
            lbl_mensajeError.Size = new Size(0, 15);
            lbl_mensajeError.TabIndex = 10;
            // 
            // btn_completarAdmin
            // 
            btn_completarAdmin.BackColor = Color.FromArgb(0, 192, 0);
            btn_completarAdmin.FlatAppearance.BorderSize = 0;
            btn_completarAdmin.FlatStyle = FlatStyle.Flat;
            btn_completarAdmin.Location = new Point(138, 255);
            btn_completarAdmin.Name = "btn_completarAdmin";
            btn_completarAdmin.Size = new Size(65, 26);
            btn_completarAdmin.TabIndex = 11;
            btn_completarAdmin.Text = "Admin";
            btn_completarAdmin.UseVisualStyleBackColor = false;
            btn_completarAdmin.Click += btn_completarAdmin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(524, 336);
            ControlBox = false;
            Controls.Add(btn_completarAdmin);
            Controls.Add(lbl_mensajeError);
            Controls.Add(btn_cerrar);
            Controls.Add(pbx_loginLogo);
            Controls.Add(lbl_loginPassword);
            Controls.Add(lbl_loginLabel);
            Controls.Add(btn_completarUsuario);
            Controls.Add(btn_loginAceptar);
            Controls.Add(pnl_topBar);
            Controls.Add(tbx_loginPassword);
            Controls.Add(tbx_loginMail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_loginLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_loginMail;
        private TextBox tbx_loginPassword;
        private Button btn_loginAceptar;
        private Button btn_completarUsuario;
        private Label lbl_loginLabel;
        private Label lbl_loginPassword;
        private PictureBox pbx_loginLogo;
        private PanelMovimiento pnl_topBar;
        private Controles.BotonCerrar btn_cerrar;
        private Label lbl_mensajeError;
        private Button btn_completarAdmin;
    }
}