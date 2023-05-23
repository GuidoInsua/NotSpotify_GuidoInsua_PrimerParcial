namespace NotSpotify.Controles
{
    partial class BotonPlayList
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
            pnl_backGround = new Panel();
            pbx_play = new PictureBox();
            lbl_titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_imagen).BeginInit();
            pnl_backGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_play).BeginInit();
            SuspendLayout();
            // 
            // pbx_imagen
            // 
            pbx_imagen.BackColor = Color.FromArgb(255, 128, 0);
            pbx_imagen.Location = new Point(12, 13);
            pbx_imagen.Name = "pbx_imagen";
            pbx_imagen.Size = new Size(130, 130);
            pbx_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_imagen.TabIndex = 0;
            pbx_imagen.TabStop = false;
            pbx_imagen.Click += pnl_backGround_Click;
            pbx_imagen.MouseEnter += pbx_imagen_MouseEnter;
            // 
            // pnl_backGround
            // 
            pnl_backGround.BackColor = Color.FromArgb(35, 35, 35);
            pnl_backGround.Controls.Add(pbx_play);
            pnl_backGround.Controls.Add(pbx_imagen);
            pnl_backGround.Controls.Add(lbl_titulo);
            pnl_backGround.Dock = DockStyle.Fill;
            pnl_backGround.Location = new Point(0, 0);
            pnl_backGround.Name = "pnl_backGround";
            pnl_backGround.Size = new Size(152, 239);
            pnl_backGround.TabIndex = 1;
            pnl_backGround.Click += pnl_backGround_Click;
            pnl_backGround.MouseEnter += pnl_backGround_MouseEnter;
            pnl_backGround.MouseLeave += pnl_backGround_MouseLeave;
            // 
            // pbx_play
            // 
            pbx_play.BackColor = Color.FromArgb(30, 215, 96);
            pbx_play.Image = Properties.Resources.imgBotonVerde;
            pbx_play.Location = new Point(97, 99);
            pbx_play.Name = "pbx_play";
            pbx_play.Size = new Size(35, 35);
            pbx_play.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_play.TabIndex = 1;
            pbx_play.TabStop = false;
            pbx_play.Visible = false;
            pbx_play.Click += pnl_backGround_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.Location = new Point(12, 156);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(130, 74);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "label1";
            lbl_titulo.Click += pnl_backGround_Click;
            // 
            // BotonPlayList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            Controls.Add(pnl_backGround);
            Margin = new Padding(12);
            Name = "BotonPlayList";
            Size = new Size(152, 239);
            Load += BotonPlayList_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_imagen).EndInit();
            pnl_backGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_play).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbx_imagen;
        private Panel pnl_backGround;
        private Label lbl_titulo;
        private PictureBox pbx_play;
    }
}
