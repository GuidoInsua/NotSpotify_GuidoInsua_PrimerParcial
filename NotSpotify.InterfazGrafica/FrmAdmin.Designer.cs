namespace NotSpotify.InterfazGrafica
{
    partial class FrmAdmin
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
            pnl_adminTopBar = new Panel();
            btn_canciones = new Button();
            btn_usuarios = new Button();
            pnl_adminFormChanger = new Panel();
            pnl_adminTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_adminTopBar
            // 
            pnl_adminTopBar.BackColor = Color.FromArgb(255, 224, 192);
            pnl_adminTopBar.Controls.Add(btn_canciones);
            pnl_adminTopBar.Controls.Add(btn_usuarios);
            pnl_adminTopBar.Dock = DockStyle.Top;
            pnl_adminTopBar.Location = new Point(0, 0);
            pnl_adminTopBar.Name = "pnl_adminTopBar";
            pnl_adminTopBar.Size = new Size(800, 57);
            pnl_adminTopBar.TabIndex = 0;
            // 
            // btn_canciones
            // 
            btn_canciones.BackColor = Color.FromArgb(255, 128, 128);
            btn_canciones.FlatAppearance.BorderSize = 0;
            btn_canciones.FlatStyle = FlatStyle.Flat;
            btn_canciones.Location = new Point(142, 12);
            btn_canciones.Name = "btn_canciones";
            btn_canciones.Size = new Size(124, 36);
            btn_canciones.TabIndex = 1;
            btn_canciones.Text = "Canciones";
            btn_canciones.UseVisualStyleBackColor = false;
            btn_canciones.Click += btn_canciones_Click;
            // 
            // btn_usuarios
            // 
            btn_usuarios.BackColor = Color.FromArgb(255, 128, 128);
            btn_usuarios.FlatAppearance.BorderSize = 0;
            btn_usuarios.FlatStyle = FlatStyle.Flat;
            btn_usuarios.Location = new Point(12, 12);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(124, 36);
            btn_usuarios.TabIndex = 0;
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // pnl_adminFormChanger
            // 
            pnl_adminFormChanger.BackColor = Color.FromArgb(255, 192, 128);
            pnl_adminFormChanger.Dock = DockStyle.Fill;
            pnl_adminFormChanger.Location = new Point(0, 57);
            pnl_adminFormChanger.Name = "pnl_adminFormChanger";
            pnl_adminFormChanger.Size = new Size(800, 393);
            pnl_adminFormChanger.TabIndex = 1;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pnl_adminFormChanger);
            Controls.Add(pnl_adminTopBar);
            Name = "FrmAdmin";
            pnl_adminTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_adminTopBar;
        private Panel pnl_adminFormChanger;
        private Button btn_usuarios;
        private Button btn_canciones;
    }
}