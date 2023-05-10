namespace NotSpotify.InterfazGrafica
{
    partial class FrmPopUp
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
            lbl_titulo = new Label();
            btn_cancelar = new Button();
            tbx_apellido = new TextBox();
            btn_acceptar = new Button();
            lbl_nombre = new Label();
            lbl_password = new Label();
            tbx_eMail = new TextBox();
            tbx_nombre = new TextBox();
            lbl_eMail = new Label();
            lbl_apellido = new Label();
            tbx_password = new TextBox();
            pnl_movimiento = new PanelMovimiento();
            lbl_dni = new Label();
            tbx_dni = new TextBox();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Palatino Linotype", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.ForeColor = Color.Lime;
            lbl_titulo.Location = new Point(88, 37);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(109, 35);
            lbl_titulo.TabIndex = 6;
            lbl_titulo.Text = "Agregar";
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(128, 255, 255);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(13, 315);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(126, 23);
            btn_cancelar.TabIndex = 11;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // tbx_apellido
            // 
            tbx_apellido.BorderStyle = BorderStyle.None;
            tbx_apellido.Location = new Point(13, 148);
            tbx_apellido.Name = "tbx_apellido";
            tbx_apellido.Size = new Size(261, 16);
            tbx_apellido.TabIndex = 1;
            // 
            // btn_acceptar
            // 
            btn_acceptar.BackColor = Color.FromArgb(128, 255, 255);
            btn_acceptar.FlatAppearance.BorderSize = 0;
            btn_acceptar.FlatStyle = FlatStyle.Flat;
            btn_acceptar.Location = new Point(148, 315);
            btn_acceptar.Name = "btn_acceptar";
            btn_acceptar.Size = new Size(126, 23);
            btn_acceptar.TabIndex = 6;
            btn_acceptar.Text = "Acceptar";
            btn_acceptar.UseVisualStyleBackColor = false;
            btn_acceptar.Click += btn_acceptar_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.ForeColor = Color.Lime;
            lbl_nombre.Location = new Point(13, 83);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(67, 20);
            lbl_nombre.TabIndex = 7;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.Lime;
            lbl_password.Location = new Point(13, 209);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(76, 20);
            lbl_password.TabIndex = 10;
            lbl_password.Text = "Password";
            // 
            // tbx_eMail
            // 
            tbx_eMail.BorderStyle = BorderStyle.None;
            tbx_eMail.Location = new Point(13, 190);
            tbx_eMail.Name = "tbx_eMail";
            tbx_eMail.Size = new Size(261, 16);
            tbx_eMail.TabIndex = 2;
            // 
            // tbx_nombre
            // 
            tbx_nombre.BorderStyle = BorderStyle.None;
            tbx_nombre.Location = new Point(13, 106);
            tbx_nombre.Name = "tbx_nombre";
            tbx_nombre.Size = new Size(261, 16);
            tbx_nombre.TabIndex = 0;
            // 
            // lbl_eMail
            // 
            lbl_eMail.AutoSize = true;
            lbl_eMail.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_eMail.ForeColor = Color.Lime;
            lbl_eMail.Location = new Point(13, 167);
            lbl_eMail.Name = "lbl_eMail";
            lbl_eMail.Size = new Size(47, 20);
            lbl_eMail.TabIndex = 9;
            lbl_eMail.Text = "Email";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_apellido.ForeColor = Color.Lime;
            lbl_apellido.Location = new Point(13, 125);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(67, 20);
            lbl_apellido.TabIndex = 8;
            lbl_apellido.Text = "Apellido";
            // 
            // tbx_password
            // 
            tbx_password.BorderStyle = BorderStyle.None;
            tbx_password.Location = new Point(13, 232);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(261, 16);
            tbx_password.TabIndex = 3;
            // 
            // pnl_movimiento
            // 
            pnl_movimiento.BackColor = Color.Transparent;
            pnl_movimiento.Dock = DockStyle.Top;
            pnl_movimiento.ForeColor = Color.Transparent;
            pnl_movimiento.Location = new Point(0, 0);
            pnl_movimiento.Name = "pnl_movimiento";
            pnl_movimiento.Size = new Size(291, 34);
            pnl_movimiento.TabIndex = 12;
            pnl_movimiento.Load += pnl_movimiento_Load;
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dni.ForeColor = Color.Lime;
            lbl_dni.Location = new Point(13, 251);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(33, 20);
            lbl_dni.TabIndex = 13;
            lbl_dni.Text = "Dni";
            lbl_dni.Visible = false;
            // 
            // tbx_dni
            // 
            tbx_dni.BorderStyle = BorderStyle.None;
            tbx_dni.Location = new Point(12, 274);
            tbx_dni.Name = "tbx_dni";
            tbx_dni.Size = new Size(261, 16);
            tbx_dni.TabIndex = 14;
            tbx_dni.Visible = false;
            // 
            // FrmPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(291, 354);
            ControlBox = false;
            Controls.Add(tbx_dni);
            Controls.Add(lbl_dni);
            Controls.Add(pnl_movimiento);
            Controls.Add(lbl_titulo);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_acceptar);
            Controls.Add(tbx_apellido);
            Controls.Add(tbx_password);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_eMail);
            Controls.Add(lbl_password);
            Controls.Add(tbx_nombre);
            Controls.Add(tbx_eMail);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmPopUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Button btn_cancelar;
        private TextBox tbx_apellido;
        private Button btn_acceptar;
        private Label lbl_nombre;
        private Label lbl_password;
        private TextBox tbx_eMail;
        private TextBox tbx_nombre;
        private Label lbl_eMail;
        private Label lbl_apellido;
        private TextBox tbx_password;
        private PanelMovimiento pnl_movimiento;
        private Label lbl_dni;
        private TextBox tbx_dni;
    }
}