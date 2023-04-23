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
            btn_menuLibarary = new Button();
            btn_menuHome = new Button();
            imageList1 = new ImageList(components);
            pbx_menuImagenCancion = new PictureBox();
            pnl_menuBarraInferior = new Panel();
            pnl_menuFormChanger = new Panel();
            pnl_menuBarraIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_menuImagenCancion).BeginInit();
            SuspendLayout();
            // 
            // pnl_menuBarraIzquierda
            // 
            pnl_menuBarraIzquierda.BackColor = Color.Black;
            pnl_menuBarraIzquierda.Controls.Add(btn_menuLibarary);
            pnl_menuBarraIzquierda.Controls.Add(btn_menuHome);
            pnl_menuBarraIzquierda.Controls.Add(pbx_menuImagenCancion);
            pnl_menuBarraIzquierda.Dock = DockStyle.Left;
            pnl_menuBarraIzquierda.Location = new Point(0, 0);
            pnl_menuBarraIzquierda.Name = "pnl_menuBarraIzquierda";
            pnl_menuBarraIzquierda.Size = new Size(166, 530);
            pnl_menuBarraIzquierda.TabIndex = 0;
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
            btn_menuLibarary.Size = new Size(166, 41);
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
            btn_menuHome.Size = new Size(166, 39);
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
            pbx_menuImagenCancion.Location = new Point(0, 364);
            pbx_menuImagenCancion.Name = "pbx_menuImagenCancion";
            pbx_menuImagenCancion.Size = new Size(166, 166);
            pbx_menuImagenCancion.TabIndex = 0;
            pbx_menuImagenCancion.TabStop = false;
            // 
            // pnl_menuBarraInferior
            // 
            pnl_menuBarraInferior.BackColor = Color.FromArgb(64, 64, 64);
            pnl_menuBarraInferior.Dock = DockStyle.Bottom;
            pnl_menuBarraInferior.Location = new Point(166, 452);
            pnl_menuBarraInferior.Name = "pnl_menuBarraInferior";
            pnl_menuBarraInferior.Size = new Size(724, 78);
            pnl_menuBarraInferior.TabIndex = 1;
            // 
            // pnl_menuFormChanger
            // 
            pnl_menuFormChanger.BackColor = Color.FromArgb(64, 64, 64);
            pnl_menuFormChanger.Dock = DockStyle.Fill;
            pnl_menuFormChanger.Location = new Point(166, 0);
            pnl_menuFormChanger.Name = "pnl_menuFormChanger";
            pnl_menuFormChanger.Size = new Size(724, 452);
            pnl_menuFormChanger.TabIndex = 2;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(890, 530);
            Controls.Add(pnl_menuFormChanger);
            Controls.Add(pnl_menuBarraInferior);
            Controls.Add(pnl_menuBarraIzquierda);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotSpotify";
            Load += FrmMenu_Load;
            pnl_menuBarraIzquierda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_menuImagenCancion).EndInit();
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
    }
}