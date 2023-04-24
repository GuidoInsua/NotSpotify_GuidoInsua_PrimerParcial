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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            tbx_loginMail = new TextBox();
            tbx_loginPassword = new TextBox();
            btn_loginAceptar = new Button();
            btn_loginAutoCompletar = new Button();
            lbl_loginLabel = new Label();
            lbl_loginPassword = new Label();
            pbx_loginLogo = new PictureBox();
            pnl_topBar = new PanelMovimiento();
            btn_cerrar = new Controles.BotonCerrar();
            ((System.ComponentModel.ISupportInitialize)pbx_loginLogo).BeginInit();
            SuspendLayout();
            // 
            // tbx_loginMail
            // 
            tbx_loginMail.BackColor = Color.Gray;
            tbx_loginMail.BorderStyle = BorderStyle.None;
            tbx_loginMail.ForeColor = Color.White;
            tbx_loginMail.Location = new Point(152, 108);
            tbx_loginMail.Name = "tbx_loginMail";
            tbx_loginMail.Size = new Size(215, 16);
            tbx_loginMail.TabIndex = 0;
            tbx_loginMail.Leave += tbx_loginMail_Leave;
            // 
            // tbx_loginPassword
            // 
            tbx_loginPassword.BackColor = Color.Gray;
            tbx_loginPassword.BorderStyle = BorderStyle.None;
            tbx_loginPassword.ForeColor = Color.White;
            tbx_loginPassword.Location = new Point(152, 147);
            tbx_loginPassword.Name = "tbx_loginPassword";
            tbx_loginPassword.Size = new Size(215, 16);
            tbx_loginPassword.TabIndex = 1;
            tbx_loginPassword.Leave += tbx_loginPassword_Leave;
            // 
            // btn_loginAceptar
            // 
            btn_loginAceptar.BackColor = Color.FromArgb(0, 192, 0);
            btn_loginAceptar.FlatAppearance.BorderSize = 0;
            btn_loginAceptar.FlatStyle = FlatStyle.Flat;
            btn_loginAceptar.Location = new Point(273, 183);
            btn_loginAceptar.Name = "btn_loginAceptar";
            btn_loginAceptar.Size = new Size(94, 26);
            btn_loginAceptar.TabIndex = 2;
            btn_loginAceptar.Text = "Aceptar";
            btn_loginAceptar.UseVisualStyleBackColor = false;
            btn_loginAceptar.Click += btn_loginAceptar_Click;
            // 
            // btn_loginAutoCompletar
            // 
            btn_loginAutoCompletar.BackColor = Color.FromArgb(0, 192, 0);
            btn_loginAutoCompletar.FlatAppearance.BorderSize = 0;
            btn_loginAutoCompletar.FlatStyle = FlatStyle.Flat;
            btn_loginAutoCompletar.Location = new Point(152, 183);
            btn_loginAutoCompletar.Name = "btn_loginAutoCompletar";
            btn_loginAutoCompletar.Size = new Size(115, 26);
            btn_loginAutoCompletar.TabIndex = 3;
            btn_loginAutoCompletar.Text = "AutoCompletar";
            btn_loginAutoCompletar.UseVisualStyleBackColor = false;
            btn_loginAutoCompletar.Click += btn_loginAutoCompletar_Click;
            // 
            // lbl_loginLabel
            // 
            lbl_loginLabel.AutoSize = true;
            lbl_loginLabel.BackColor = Color.Transparent;
            lbl_loginLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_loginLabel.ForeColor = Color.Silver;
            lbl_loginLabel.Location = new Point(152, 86);
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
            lbl_loginPassword.Location = new Point(152, 127);
            lbl_loginPassword.Name = "lbl_loginPassword";
            lbl_loginPassword.Size = new Size(67, 19);
            lbl_loginPassword.TabIndex = 5;
            lbl_loginPassword.Text = "Password";
            // 
            // pbx_loginLogo
            // 
            pbx_loginLogo.BackColor = Color.Black;
            pbx_loginLogo.Image = (Image)resources.GetObject("pbx_loginLogo.Image");
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
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(21, 21);
            btn_cerrar.TabIndex = 9;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(524, 300);
            ControlBox = false;
            Controls.Add(btn_cerrar);
            Controls.Add(pbx_loginLogo);
            Controls.Add(lbl_loginPassword);
            Controls.Add(lbl_loginLabel);
            Controls.Add(btn_loginAutoCompletar);
            Controls.Add(btn_loginAceptar);
            Controls.Add(tbx_loginPassword);
            Controls.Add(tbx_loginMail);
            Controls.Add(pnl_topBar);
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
        private Button btn_loginAutoCompletar;
        private Label lbl_loginLabel;
        private Label lbl_loginPassword;
        private PictureBox pbx_loginLogo;
        private PanelMovimiento pnl_topBar;
        private Controles.BotonCerrar btn_cerrar;
    }
}