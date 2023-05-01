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
            components = new System.ComponentModel.Container();
            pnl_adminTopBar = new Panel();
            botonMaximizar1 = new Controles.BotonMaximizar();
            botonCerrar1 = new Controles.BotonCerrar();
            pnl_movimientoTopBar = new PanelMovimiento();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            btn_usuarios = new Button();
            panel2 = new Panel();
            btn_canciones = new Button();
            btn_playLists = new Button();
            btn_admins = new Button();
            pnl_adminTopBar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_adminTopBar
            // 
            pnl_adminTopBar.BackColor = Color.Black;
            pnl_adminTopBar.Controls.Add(botonMaximizar1);
            pnl_adminTopBar.Controls.Add(botonCerrar1);
            pnl_adminTopBar.Controls.Add(pnl_movimientoTopBar);
            pnl_adminTopBar.Dock = DockStyle.Top;
            pnl_adminTopBar.Location = new Point(0, 0);
            pnl_adminTopBar.Name = "pnl_adminTopBar";
            pnl_adminTopBar.Size = new Size(895, 21);
            pnl_adminTopBar.TabIndex = 0;
            // 
            // botonMaximizar1
            // 
            botonMaximizar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonMaximizar1.BackColor = Color.Transparent;
            botonMaximizar1.Location = new Point(845, 0);
            botonMaximizar1.Name = "botonMaximizar1";
            botonMaximizar1.Size = new Size(21, 21);
            botonMaximizar1.TabIndex = 2;
            botonMaximizar1.Click += botonMaximizar1_Click;
            // 
            // botonCerrar1
            // 
            botonCerrar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonCerrar1.BackColor = Color.Transparent;
            botonCerrar1.BackgroundImageLayout = ImageLayout.Center;
            botonCerrar1.Location = new Point(872, 0);
            botonCerrar1.Name = "botonCerrar1";
            botonCerrar1.Size = new Size(21, 21);
            botonCerrar1.TabIndex = 1;
            botonCerrar1.Click += botonCerrar1_Click;
            // 
            // pnl_movimientoTopBar
            // 
            pnl_movimientoTopBar.Dock = DockStyle.Fill;
            pnl_movimientoTopBar.Location = new Point(0, 0);
            pnl_movimientoTopBar.Name = "pnl_movimientoTopBar";
            pnl_movimientoTopBar.Size = new Size(895, 21);
            pnl_movimientoTopBar.TabIndex = 0;
            pnl_movimientoTopBar.Load += pnl_movimientoTopBar_Load;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 474);
            panel1.TabIndex = 6;
            // 
            // btn_usuarios
            // 
            btn_usuarios.BackColor = Color.FromArgb(128, 255, 255);
            btn_usuarios.FlatAppearance.BorderSize = 0;
            btn_usuarios.FlatStyle = FlatStyle.Flat;
            btn_usuarios.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_usuarios.Location = new Point(12, 6);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(131, 36);
            btn_usuarios.TabIndex = 0;
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btn_canciones);
            panel2.Controls.Add(btn_playLists);
            panel2.Controls.Add(btn_admins);
            panel2.Controls.Add(btn_usuarios);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 47);
            panel2.TabIndex = 8;
            // 
            // btn_canciones
            // 
            btn_canciones.BackColor = Color.FromArgb(128, 255, 255);
            btn_canciones.FlatAppearance.BorderSize = 0;
            btn_canciones.FlatStyle = FlatStyle.Flat;
            btn_canciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_canciones.Location = new Point(423, 6);
            btn_canciones.Name = "btn_canciones";
            btn_canciones.Size = new Size(131, 36);
            btn_canciones.TabIndex = 3;
            btn_canciones.Text = "Canciones";
            btn_canciones.UseVisualStyleBackColor = false;
            // 
            // btn_playLists
            // 
            btn_playLists.BackColor = Color.FromArgb(128, 255, 255);
            btn_playLists.FlatAppearance.BorderSize = 0;
            btn_playLists.FlatStyle = FlatStyle.Flat;
            btn_playLists.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_playLists.Location = new Point(286, 6);
            btn_playLists.Name = "btn_playLists";
            btn_playLists.Size = new Size(131, 36);
            btn_playLists.TabIndex = 2;
            btn_playLists.Text = "PlayLists";
            btn_playLists.UseVisualStyleBackColor = false;
            // 
            // btn_admins
            // 
            btn_admins.BackColor = Color.FromArgb(128, 255, 255);
            btn_admins.FlatAppearance.BorderSize = 0;
            btn_admins.FlatStyle = FlatStyle.Flat;
            btn_admins.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_admins.Location = new Point(149, 6);
            btn_admins.Name = "btn_admins";
            btn_admins.Size = new Size(131, 36);
            btn_admins.TabIndex = 1;
            btn_admins.Text = "Admins";
            btn_admins.UseVisualStyleBackColor = false;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 495);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnl_adminTopBar);
            IsMdiContainer = true;
            Name = "FrmAdmin";
            pnl_adminTopBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_adminTopBar;
        private Controles.BotonCerrar botonCerrar1;
        private PanelMovimiento pnl_movimientoTopBar;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Controles.BotonMaximizar botonMaximizar1;
        private Button btn_usuarios;
        private Panel panel2;
        private Button btn_canciones;
        private Button btn_playLists;
        private Button btn_admins;
    }
}