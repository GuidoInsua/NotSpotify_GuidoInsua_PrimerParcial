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
            btn_maximizar = new Controles.BotonMaximizar();
            btn_cerrar = new Controles.BotonCerrar();
            pnl_movimientoTopBar = new PanelMovimiento();
            pnl_FrmChanger = new Panel();
            btn_usuarios = new Button();
            pnl_topBarrr = new Panel();
            btn_canciones = new Button();
            btn_playLists = new Button();
            btn_admins = new Button();
            pnl_topBarrr.SuspendLayout();
            SuspendLayout();
            // 
            // btn_maximizar
            // 
            btn_maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_maximizar.BackColor = Color.Transparent;
            btn_maximizar.Location = new Point(887, 0);
            btn_maximizar.Name = "btn_maximizar";
            btn_maximizar.Size = new Size(21, 21);
            btn_maximizar.TabIndex = 2;
            btn_maximizar.Click += btn_maximizar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.Transparent;
            btn_cerrar.BackgroundImageLayout = ImageLayout.Center;
            btn_cerrar.Location = new Point(911, 0);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(21, 21);
            btn_cerrar.TabIndex = 1;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // pnl_movimientoTopBar
            // 
            pnl_movimientoTopBar.Dock = DockStyle.Top;
            pnl_movimientoTopBar.Location = new Point(0, 0);
            pnl_movimientoTopBar.Name = "pnl_movimientoTopBar";
            pnl_movimientoTopBar.Size = new Size(935, 21);
            pnl_movimientoTopBar.TabIndex = 0;
            pnl_movimientoTopBar.Load += pnl_movimientoTopBar_Load;
            // 
            // pnl_FrmChanger
            // 
            pnl_FrmChanger.BackColor = Color.FromArgb(64, 64, 64);
            pnl_FrmChanger.Dock = DockStyle.Fill;
            pnl_FrmChanger.Location = new Point(0, 0);
            pnl_FrmChanger.Name = "pnl_FrmChanger";
            pnl_FrmChanger.Size = new Size(935, 547);
            pnl_FrmChanger.TabIndex = 6;
            // 
            // btn_usuarios
            // 
            btn_usuarios.BackColor = Color.FromArgb(128, 255, 255);
            btn_usuarios.FlatAppearance.BorderSize = 0;
            btn_usuarios.FlatStyle = FlatStyle.Flat;
            btn_usuarios.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_usuarios.Location = new Point(3, 27);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(131, 36);
            btn_usuarios.TabIndex = 0;
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // pnl_topBarrr
            // 
            pnl_topBarrr.BackColor = Color.Black;
            pnl_topBarrr.Controls.Add(btn_maximizar);
            pnl_topBarrr.Controls.Add(btn_cerrar);
            pnl_topBarrr.Controls.Add(btn_canciones);
            pnl_topBarrr.Controls.Add(pnl_movimientoTopBar);
            pnl_topBarrr.Controls.Add(btn_playLists);
            pnl_topBarrr.Controls.Add(btn_admins);
            pnl_topBarrr.Controls.Add(btn_usuarios);
            pnl_topBarrr.Dock = DockStyle.Top;
            pnl_topBarrr.Location = new Point(0, 0);
            pnl_topBarrr.Name = "pnl_topBarrr";
            pnl_topBarrr.Size = new Size(935, 72);
            pnl_topBarrr.TabIndex = 8;
            // 
            // btn_canciones
            // 
            btn_canciones.BackColor = Color.FromArgb(128, 255, 255);
            btn_canciones.FlatAppearance.BorderSize = 0;
            btn_canciones.FlatStyle = FlatStyle.Flat;
            btn_canciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_canciones.Location = new Point(414, 27);
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
            btn_playLists.Location = new Point(277, 27);
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
            btn_admins.Location = new Point(140, 27);
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
            ClientSize = new Size(935, 547);
            ControlBox = false;
            Controls.Add(pnl_topBarrr);
            Controls.Add(pnl_FrmChanger);
            IsMdiContainer = true;
            Name = "FrmAdmin";
            pnl_topBarrr.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Controles.BotonCerrar btn_cerrar;
        private PanelMovimiento pnl_movimientoTopBar;
        private Panel pnl_FrmChanger;
        private Controles.BotonMaximizar btn_maximizar;
        private Button btn_usuarios;
        private Panel pnl_topBarrr;
        private Button btn_canciones;
        private Button btn_playLists;
        private Button btn_admins;
    }
}