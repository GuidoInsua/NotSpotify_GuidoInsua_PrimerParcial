namespace NotSpotify.Controles
{
    partial class BotonMinimizar
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
            pbx_imagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx_imagen).BeginInit();
            SuspendLayout();
            // 
            // pbx_imagen
            // 
            pbx_imagen.Dock = DockStyle.Fill;
            pbx_imagen.Image = Properties.Resources.imgMinimizar;
            pbx_imagen.Location = new Point(0, 0);
            pbx_imagen.Margin = new Padding(0);
            pbx_imagen.Name = "pbx_imagen";
            pbx_imagen.Size = new Size(21, 21);
            pbx_imagen.SizeMode = PictureBoxSizeMode.CenterImage;
            pbx_imagen.TabIndex = 0;
            pbx_imagen.TabStop = false;
            pbx_imagen.MouseEnter += pbx_imagen_MouseEnter;
            pbx_imagen.MouseLeave += pbx_imagen_MouseLeave;
            // 
            // BotonMinimizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pbx_imagen);
            Margin = new Padding(0);
            Name = "BotonMinimizar";
            Size = new Size(21, 21);
            ((System.ComponentModel.ISupportInitialize)pbx_imagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbx_imagen;
    }
}
