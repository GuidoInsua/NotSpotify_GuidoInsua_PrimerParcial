namespace NotSpotify.InterfazGrafica
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            pnl_menuBarraIzquierda = new Panel();
            btn_admin = new Button();
            btn_menuLibrary = new Controles.BotonLibrary();
            btn_menuHome = new Controles.BotonHome();
            pbx_menuImagenCancion = new PictureBox();
            imageList1 = new ImageList(components);
            pnl_menuBarraInferior = new Panel();
            pbx_anterior = new PictureBox();
            pbx_siguiente = new PictureBox();
            btn_play = new Controles.BotonPlay();
            pnl_menuFormChanger = new Panel();
            panelMovimiento2 = new PanelMovimiento();
            botonCerrar1 = new Controles.BotonCerrar();
            botonMaximizar1 = new Controles.BotonMaximizar();
            botonMinimizar1 = new Controles.BotonMinimizar();
            pnl_menuBarraIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_menuImagenCancion).BeginInit();
            pnl_menuBarraInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_anterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_siguiente).BeginInit();
            SuspendLayout();
            // 
            // pnl_menuBarraIzquierda
            // 
            pnl_menuBarraIzquierda.BackColor = Color.Black;
            pnl_menuBarraIzquierda.BackgroundImageLayout = ImageLayout.None;
            pnl_menuBarraIzquierda.Controls.Add(btn_admin);
            pnl_menuBarraIzquierda.Controls.Add(btn_menuLibrary);
            pnl_menuBarraIzquierda.Controls.Add(btn_menuHome);
            pnl_menuBarraIzquierda.Controls.Add(pbx_menuImagenCancion);
            pnl_menuBarraIzquierda.Dock = DockStyle.Left;
            pnl_menuBarraIzquierda.Location = new Point(0, 21);
            pnl_menuBarraIzquierda.Margin = new Padding(0);
            pnl_menuBarraIzquierda.Name = "pnl_menuBarraIzquierda";
            pnl_menuBarraIzquierda.Size = new Size(162, 610);
            pnl_menuBarraIzquierda.TabIndex = 0;
            // 
            // btn_admin
            // 
            btn_admin.BackColor = Color.Fuchsia;
            btn_admin.FlatAppearance.BorderSize = 0;
            btn_admin.FlatStyle = FlatStyle.Flat;
            btn_admin.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_admin.Location = new Point(12, 95);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(131, 32);
            btn_admin.TabIndex = 6;
            btn_admin.Text = "Admin";
            btn_admin.UseVisualStyleBackColor = false;
            btn_admin.Visible = false;
            btn_admin.Click += btn_admin_Click;
            // 
            // btn_menuLibrary
            // 
            btn_menuLibrary.BackColor = Color.Transparent;
            btn_menuLibrary.Dock = DockStyle.Top;
            btn_menuLibrary.Location = new Point(0, 39);
            btn_menuLibrary.Name = "btn_menuLibrary";
            btn_menuLibrary.Size = new Size(162, 39);
            btn_menuLibrary.TabIndex = 5;
            btn_menuLibrary.MyClick += btn_menuLibrary_Click;
            // 
            // btn_menuHome
            // 
            btn_menuHome.BackColor = Color.Transparent;
            btn_menuHome.Dock = DockStyle.Top;
            btn_menuHome.Location = new Point(0, 0);
            btn_menuHome.Name = "btn_menuHome";
            btn_menuHome.Size = new Size(162, 39);
            btn_menuHome.TabIndex = 4;
            btn_menuHome.MyClick += btn_menuHome_Click;
            // 
            // pbx_menuImagenCancion
            // 
            pbx_menuImagenCancion.Dock = DockStyle.Bottom;
            pbx_menuImagenCancion.Image = (Image)resources.GetObject("pbx_menuImagenCancion.Image");
            pbx_menuImagenCancion.Location = new Point(0, 468);
            pbx_menuImagenCancion.Margin = new Padding(0);
            pbx_menuImagenCancion.Name = "pbx_menuImagenCancion";
            pbx_menuImagenCancion.Size = new Size(162, 142);
            pbx_menuImagenCancion.TabIndex = 0;
            pbx_menuImagenCancion.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.PNG");
            imageList1.Images.SetKeyName(1, "home2.PNG");
            // 
            // pnl_menuBarraInferior
            // 
            pnl_menuBarraInferior.BackColor = Color.Black;
            pnl_menuBarraInferior.Controls.Add(pbx_anterior);
            pnl_menuBarraInferior.Controls.Add(pbx_siguiente);
            pnl_menuBarraInferior.Controls.Add(btn_play);
            pnl_menuBarraInferior.Dock = DockStyle.Bottom;
            pnl_menuBarraInferior.Location = new Point(0, 631);
            pnl_menuBarraInferior.Margin = new Padding(0);
            pnl_menuBarraInferior.Name = "pnl_menuBarraInferior";
            pnl_menuBarraInferior.Size = new Size(1044, 60);
            pnl_menuBarraInferior.TabIndex = 1;
            // 
            // pbx_anterior
            // 
            pbx_anterior.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pbx_anterior.Image = (Image)resources.GetObject("pbx_anterior.Image");
            pbx_anterior.Location = new Point(475, 13);
            pbx_anterior.Name = "pbx_anterior";
            pbx_anterior.Size = new Size(38, 35);
            pbx_anterior.SizeMode = PictureBoxSizeMode.CenterImage;
            pbx_anterior.TabIndex = 9;
            pbx_anterior.TabStop = false;
            pbx_anterior.Click += pbx_anterior_Click;
            // 
            // pbx_siguiente
            // 
            pbx_siguiente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pbx_siguiente.Image = (Image)resources.GetObject("pbx_siguiente.Image");
            pbx_siguiente.Location = new Point(563, 12);
            pbx_siguiente.Name = "pbx_siguiente";
            pbx_siguiente.Size = new Size(38, 36);
            pbx_siguiente.SizeMode = PictureBoxSizeMode.CenterImage;
            pbx_siguiente.TabIndex = 8;
            pbx_siguiente.TabStop = false;
            pbx_siguiente.Click += pbx_siguiente_Click;
            // 
            // btn_play
            // 
            btn_play.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btn_play.BackColor = Color.Black;
            btn_play.Location = new Point(519, 12);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(38, 36);
            btn_play.TabIndex = 7;
            btn_play.MyClick += btn_play_Click;
            // 
            // pnl_menuFormChanger
            // 
            pnl_menuFormChanger.AutoSize = true;
            pnl_menuFormChanger.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_menuFormChanger.BackColor = Color.Transparent;
            pnl_menuFormChanger.BackgroundImageLayout = ImageLayout.None;
            pnl_menuFormChanger.Dock = DockStyle.Fill;
            pnl_menuFormChanger.Location = new Point(162, 21);
            pnl_menuFormChanger.Margin = new Padding(0);
            pnl_menuFormChanger.Name = "pnl_menuFormChanger";
            pnl_menuFormChanger.Size = new Size(882, 610);
            pnl_menuFormChanger.TabIndex = 2;
            // 
            // panelMovimiento2
            // 
            panelMovimiento2.BackColor = Color.Black;
            panelMovimiento2.Dock = DockStyle.Top;
            panelMovimiento2.Location = new Point(0, 0);
            panelMovimiento2.Margin = new Padding(0);
            panelMovimiento2.Name = "panelMovimiento2";
            panelMovimiento2.Size = new Size(1044, 21);
            panelMovimiento2.TabIndex = 3;
            panelMovimiento2.Load += panelMovimiento2_Load;
            // 
            // botonCerrar1
            // 
            botonCerrar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonCerrar1.BackColor = Color.Transparent;
            botonCerrar1.BackgroundImageLayout = ImageLayout.Center;
            botonCerrar1.Location = new Point(1023, 0);
            botonCerrar1.Margin = new Padding(0);
            botonCerrar1.Name = "botonCerrar1";
            botonCerrar1.Size = new Size(21, 21);
            botonCerrar1.TabIndex = 4;
            botonCerrar1.MyClick += botonCerrar1_Click;
            // 
            // botonMaximizar1
            // 
            botonMaximizar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonMaximizar1.BackColor = Color.Transparent;
            botonMaximizar1.Location = new Point(1001, 0);
            botonMaximizar1.Margin = new Padding(0);
            botonMaximizar1.Name = "botonMaximizar1";
            botonMaximizar1.Size = new Size(22, 21);
            botonMaximizar1.TabIndex = 5;
            botonMaximizar1.MyClick += botonMaximizar1_Click;
            // 
            // botonMinimizar1
            // 
            botonMinimizar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonMinimizar1.BackColor = Color.Transparent;
            botonMinimizar1.Location = new Point(980, 0);
            botonMinimizar1.Margin = new Padding(0);
            botonMinimizar1.Name = "botonMinimizar1";
            botonMinimizar1.Size = new Size(21, 21);
            botonMinimizar1.TabIndex = 6;
            botonMinimizar1.MyClick += botonMinimizar1_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1044, 691);
            ControlBox = false;
            Controls.Add(botonMinimizar1);
            Controls.Add(botonCerrar1);
            Controls.Add(botonMaximizar1);
            Controls.Add(pnl_menuFormChanger);
            Controls.Add(pnl_menuBarraIzquierda);
            Controls.Add(panelMovimiento2);
            Controls.Add(pnl_menuBarraInferior);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            pnl_menuBarraIzquierda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_menuImagenCancion).EndInit();
            pnl_menuBarraInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_anterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_siguiente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_menuBarraIzquierda;
        private Panel pnl_menuBarraInferior;
        private Panel pnl_menuFormChanger;
        private PictureBox pbx_menuImagenCancion;
        private ImageList imageList1;
        private PanelMovimiento panelMovimiento2;
        private Controles.BotonCerrar botonCerrar1;
        private Controles.BotonHome btn_menuHome;
        private Controles.BotonLibrary btn_menuLibrary;
        private Controles.BotonMaximizar botonMaximizar1;
        private Button btn_admin;
        private Controles.BotonMinimizar botonMinimizar1;
        private Controles.BotonPlay btn_play;
        private PictureBox pbx_anterior;
        private PictureBox pbx_siguiente;
    }
}