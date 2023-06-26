namespace NotSpotify.Controles
{
    partial class BotonMaximizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonMaximizar));
            imgl_imagenes = new ImageList(components);
            btn_maximizar = new Button();
            SuspendLayout();
            // 
            // imgl_imagenes
            // 
            imgl_imagenes.ColorDepth = ColorDepth.Depth8Bit;
            imgl_imagenes.ImageStream = (ImageListStreamer)resources.GetObject("imgl_imagenes.ImageStream");
            imgl_imagenes.TransparentColor = Color.Transparent;
            imgl_imagenes.Images.SetKeyName(0, "imgMaximizar.png");
            imgl_imagenes.Images.SetKeyName(1, "imgDesMaximizar.png");
            // 
            // btn_maximizar
            // 
            btn_maximizar.BackColor = Color.Transparent;
            btn_maximizar.Dock = DockStyle.Fill;
            btn_maximizar.FlatAppearance.BorderSize = 0;
            btn_maximizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_maximizar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_maximizar.FlatStyle = FlatStyle.Flat;
            btn_maximizar.ImageIndex = 0;
            btn_maximizar.ImageList = imgl_imagenes;
            btn_maximizar.Location = new Point(0, 0);
            btn_maximizar.Margin = new Padding(0);
            btn_maximizar.Name = "btn_maximizar";
            btn_maximizar.Size = new Size(22, 21);
            btn_maximizar.TabIndex = 0;
            btn_maximizar.UseVisualStyleBackColor = false;
            // 
            // BotonMaximizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btn_maximizar);
            Margin = new Padding(0);
            Name = "BotonMaximizar";
            Size = new Size(22, 21);
            MyClick += BotonMaximizar_Click;
            ResumeLayout(false);
        }

        #endregion

        private ImageList imgl_imagenes;
        private Button btn_maximizar;
    }
}
