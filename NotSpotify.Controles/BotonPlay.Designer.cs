namespace NotSpotify.Controles
{
    partial class BotonPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonPlay));
            imgl_imagenes = new ImageList(components);
            btn_paly = new Button();
            SuspendLayout();
            // 
            // imgl_imagenes
            // 
            imgl_imagenes.ColorDepth = ColorDepth.Depth8Bit;
            imgl_imagenes.ImageStream = (ImageListStreamer)resources.GetObject("imgl_imagenes.ImageStream");
            imgl_imagenes.TransparentColor = Color.Transparent;
            imgl_imagenes.Images.SetKeyName(0, "imgPlay.png");
            imgl_imagenes.Images.SetKeyName(1, "imgPause.png");
            // 
            // btn_paly
            // 
            btn_paly.BackgroundImageLayout = ImageLayout.Center;
            btn_paly.Dock = DockStyle.Fill;
            btn_paly.FlatAppearance.BorderSize = 0;
            btn_paly.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_paly.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_paly.FlatStyle = FlatStyle.Flat;
            btn_paly.ImageIndex = 0;
            btn_paly.ImageList = imgl_imagenes;
            btn_paly.Location = new Point(0, 0);
            btn_paly.Name = "btn_paly";
            btn_paly.Size = new Size(38, 36);
            btn_paly.TabIndex = 0;
            btn_paly.UseVisualStyleBackColor = false;
            // 
            // BotonPlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(btn_paly);
            Name = "BotonPlay";
            Size = new Size(38, 36);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imgl_imagenes;
        private Button btn_paly;
    }
}
