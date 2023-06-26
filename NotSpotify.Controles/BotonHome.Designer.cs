namespace NotSpotify.Controles
{
    partial class BotonHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonHome));
            imgl_imagenes = new ImageList(components);
            btn_home = new Button();
            SuspendLayout();
            // 
            // imgl_imagenes
            // 
            imgl_imagenes.ColorDepth = ColorDepth.Depth8Bit;
            imgl_imagenes.ImageStream = (ImageListStreamer)resources.GetObject("imgl_imagenes.ImageStream");
            imgl_imagenes.TransparentColor = Color.Transparent;
            imgl_imagenes.Images.SetKeyName(0, "imgHomeOff.PNG");
            imgl_imagenes.Images.SetKeyName(1, "imgHomeHover.PNG");
            imgl_imagenes.Images.SetKeyName(2, "imgHomeOn.PNG");
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.Black;
            btn_home.Dock = DockStyle.Fill;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_home.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.ForeColor = Color.Silver;
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.ImageIndex = 0;
            btn_home.ImageList = imgl_imagenes;
            btn_home.Location = new Point(0, 0);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(162, 39);
            btn_home.TabIndex = 0;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.MouseEnter += btn_home_MouseEnter;
            btn_home.MouseLeave += btn_home_MouseLeave;
            // 
            // BotonHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btn_home);
            Name = "BotonHome";
            Size = new Size(162, 39);
            MyClick += BotonHome_Click;
            ResumeLayout(false);
        }

        #endregion

        private ImageList imgl_imagenes;
        private Button btn_home;
    }
}
