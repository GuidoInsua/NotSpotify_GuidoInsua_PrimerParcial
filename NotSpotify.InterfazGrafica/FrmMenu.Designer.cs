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
            listBox1 = new ListBox();
            btn_menuLibarary = new Button();
            btn_menuHome = new Button();
            imageList1 = new ImageList(components);
            pbx_menuImagenCancion = new PictureBox();
            pnl_menuBarraInferior = new Panel();
            button1 = new Button();
            trackBar1 = new TrackBar();
            pnl_menuFormChanger = new Panel();
            panelMovimiento2 = new PanelMovimiento();
            botonCerrar1 = new Controles.BotonCerrar();
            pnl_menuBarraIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_menuImagenCancion).BeginInit();
            pnl_menuBarraInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pnl_menuBarraIzquierda
            // 
            pnl_menuBarraIzquierda.BackColor = Color.Black;
            pnl_menuBarraIzquierda.Controls.Add(listBox1);
            pnl_menuBarraIzquierda.Controls.Add(btn_menuLibarary);
            pnl_menuBarraIzquierda.Controls.Add(btn_menuHome);
            pnl_menuBarraIzquierda.Controls.Add(pbx_menuImagenCancion);
            pnl_menuBarraIzquierda.Dock = DockStyle.Left;
            pnl_menuBarraIzquierda.Location = new Point(0, 21);
            pnl_menuBarraIzquierda.Name = "pnl_menuBarraIzquierda";
            pnl_menuBarraIzquierda.Size = new Size(162, 496);
            pnl_menuBarraIzquierda.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 264);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(157, 94);
            listBox1.TabIndex = 3;
            // 
            // btn_menuLibarary
            // 
            btn_menuLibarary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_menuLibarary.BackgroundImage = (Image)resources.GetObject("btn_menuLibarary.BackgroundImage");
            btn_menuLibarary.BackgroundImageLayout = ImageLayout.Center;
            btn_menuLibarary.FlatAppearance.BorderSize = 0;
            btn_menuLibarary.FlatStyle = FlatStyle.Flat;
            btn_menuLibarary.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_menuLibarary.ForeColor = Color.FromArgb(224, 224, 224);
            btn_menuLibarary.Location = new Point(-3, 78);
            btn_menuLibarary.Name = "btn_menuLibarary";
            btn_menuLibarary.Size = new Size(162, 41);
            btn_menuLibarary.TabIndex = 2;
            btn_menuLibarary.TextAlign = ContentAlignment.MiddleLeft;
            btn_menuLibarary.UseVisualStyleBackColor = true;
            btn_menuLibarary.Click += btn_menuLibarary_Click;
            // 
            // btn_menuHome
            // 
            btn_menuHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_menuHome.BackgroundImageLayout = ImageLayout.Center;
            btn_menuHome.FlatAppearance.BorderSize = 0;
            btn_menuHome.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_menuHome.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_menuHome.FlatStyle = FlatStyle.Flat;
            btn_menuHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_menuHome.ForeColor = Color.Silver;
            btn_menuHome.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menuHome.ImageIndex = 0;
            btn_menuHome.ImageList = imageList1;
            btn_menuHome.Location = new Point(0, 33);
            btn_menuHome.Name = "btn_menuHome";
            btn_menuHome.Size = new Size(162, 39);
            btn_menuHome.TabIndex = 1;
            btn_menuHome.Text = "Home";
            btn_menuHome.UseVisualStyleBackColor = true;
            btn_menuHome.Click += btn_menuHome_Click;
            btn_menuHome.MouseEnter += btn_menuHome_MouseEnter;
            btn_menuHome.MouseLeave += btn_menuHome_MouseLeave;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.PNG");
            imageList1.Images.SetKeyName(1, "home2.PNG");
            // 
            // pbx_menuImagenCancion
            // 
            pbx_menuImagenCancion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbx_menuImagenCancion.Image = (Image)resources.GetObject("pbx_menuImagenCancion.Image");
            pbx_menuImagenCancion.Location = new Point(22, 410);
            pbx_menuImagenCancion.Name = "pbx_menuImagenCancion";
            pbx_menuImagenCancion.Size = new Size(115, 80);
            pbx_menuImagenCancion.TabIndex = 0;
            pbx_menuImagenCancion.TabStop = false;
            // 
            // pnl_menuBarraInferior
            // 
            pnl_menuBarraInferior.BackColor = Color.FromArgb(64, 64, 64);
            pnl_menuBarraInferior.Controls.Add(button1);
            pnl_menuBarraInferior.Controls.Add(trackBar1);
            pnl_menuBarraInferior.Dock = DockStyle.Bottom;
            pnl_menuBarraInferior.Location = new Point(0, 517);
            pnl_menuBarraInferior.Name = "pnl_menuBarraInferior";
            pnl_menuBarraInferior.Size = new Size(963, 60);
            pnl_menuBarraInferior.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(311, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(409, 6);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(406, 45);
            trackBar1.TabIndex = 0;
            // 
            // pnl_menuFormChanger
            // 
            pnl_menuFormChanger.BackColor = Color.FromArgb(255, 192, 192);
            pnl_menuFormChanger.Dock = DockStyle.Fill;
            pnl_menuFormChanger.Location = new Point(0, 21);
            pnl_menuFormChanger.Name = "pnl_menuFormChanger";
            pnl_menuFormChanger.Size = new Size(963, 496);
            pnl_menuFormChanger.TabIndex = 2;
            // 
            // panelMovimiento2
            // 
            panelMovimiento2.BackColor = Color.Black;
            panelMovimiento2.Dock = DockStyle.Top;
            panelMovimiento2.Location = new Point(0, 0);
            panelMovimiento2.Name = "panelMovimiento2";
            panelMovimiento2.Size = new Size(963, 21);
            panelMovimiento2.TabIndex = 3;
            panelMovimiento2.Load += panelMovimiento2_Load;
            // 
            // botonCerrar1
            // 
            botonCerrar1.BackColor = Color.Transparent;
            botonCerrar1.BackgroundImageLayout = ImageLayout.Center;
            botonCerrar1.Location = new Point(942, 0);
            botonCerrar1.Name = "botonCerrar1";
            botonCerrar1.Size = new Size(21, 21);
            botonCerrar1.TabIndex = 4;
            botonCerrar1.Click += botonCerrar1_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(963, 577);
            ControlBox = false;
            Controls.Add(botonCerrar1);
            Controls.Add(pnl_menuBarraIzquierda);
            Controls.Add(pnl_menuFormChanger);
            Controls.Add(pnl_menuBarraInferior);
            Controls.Add(panelMovimiento2);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmMenu_Load;
            pnl_menuBarraIzquierda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_menuImagenCancion).EndInit();
            pnl_menuBarraInferior.ResumeLayout(false);
            pnl_menuBarraInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_menuBarraIzquierda;
        private Panel pnl_menuBarraInferior;
        private Panel pnl_menuFormChanger;
        private PictureBox pbx_menuImagenCancion;
        private Button btn_menuHome;
        private Button btn_menuLibarary;
        private ImageList imageList1;
        private Button button1;
        private TrackBar trackBar1;
        private ListBox listBox1;
        private PanelMovimiento panelMovimiento2;
        private Controles.BotonCerrar botonCerrar1;
    }
}