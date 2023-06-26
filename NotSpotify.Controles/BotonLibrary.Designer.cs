namespace NotSpotify.Controles
{
    partial class BotonLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonLibrary));
            imgl_imagenes = new ImageList(components);
            btn_library = new Button();
            SuspendLayout();
            // 
            // imgl_imagenes
            // 
            imgl_imagenes.ColorDepth = ColorDepth.Depth8Bit;
            imgl_imagenes.ImageStream = (ImageListStreamer)resources.GetObject("imgl_imagenes.ImageStream");
            imgl_imagenes.TransparentColor = Color.Transparent;
            imgl_imagenes.Images.SetKeyName(0, "imgLibraryOff.PNG");
            imgl_imagenes.Images.SetKeyName(1, "imgLibraryHover.PNG");
            imgl_imagenes.Images.SetKeyName(2, "imgLibraryOn.PNG");
            // 
            // btn_library
            // 
            btn_library.BackColor = Color.Black;
            btn_library.Dock = DockStyle.Fill;
            btn_library.FlatAppearance.BorderSize = 0;
            btn_library.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_library.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_library.FlatStyle = FlatStyle.Flat;
            btn_library.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_library.ForeColor = Color.Silver;
            btn_library.ImageAlign = ContentAlignment.MiddleLeft;
            btn_library.ImageIndex = 0;
            btn_library.ImageList = imgl_imagenes;
            btn_library.Location = new Point(0, 0);
            btn_library.Name = "btn_library";
            btn_library.Size = new Size(162, 39);
            btn_library.TabIndex = 0;
            btn_library.Text = "Library";
            btn_library.UseVisualStyleBackColor = false;
            btn_library.MouseEnter += btn_library_MouseEnter;
            btn_library.MouseLeave += btn_library_MouseLeave;
            // 
            // BotonLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btn_library);
            Name = "BotonLibrary";
            Size = new Size(162, 39);
            MyClick += BotonLibrary_Click;
            ResumeLayout(false);
        }

        #endregion

        private ImageList imgl_imagenes;
        private Button btn_library;
    }
}
