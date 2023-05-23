namespace NotSpotify.InterfazGrafica
{
    partial class FrmUnaPlayList
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lbx_canciones = new ListBox();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 222);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(203, 33);
            label3.Name = "label3";
            label3.Size = new Size(81, 29);
            label3.TabIndex = 3;
            label3.Text = "label1";
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(203, 149);
            label2.Name = "label2";
            label2.Size = new Size(596, 48);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbx_canciones
            // 
            lbx_canciones.BackColor = Color.FromArgb(25, 25, 25);
            lbx_canciones.BorderStyle = BorderStyle.None;
            lbx_canciones.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbx_canciones.ForeColor = Color.White;
            lbx_canciones.FormattingEnabled = true;
            lbx_canciones.ItemHeight = 18;
            lbx_canciones.Items.AddRange(new object[] { "Cancion cualquiera", "Cancion cualquiera", "Cancion cualquiera", "Cancion cualquiera", "Cancion cualquiera", "Cancion cualquiera", "Cancion cualquiera", "Cancion cualquiera", "Cancion cualquiera" });
            lbx_canciones.Location = new Point(12, 328);
            lbx_canciones.Name = "lbx_canciones";
            lbx_canciones.Size = new Size(847, 342);
            lbx_canciones.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(871, 89);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(29, 26);
            button1.Name = "button1";
            button1.Size = new Size(39, 38);
            button1.TabIndex = 0;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmUnaPlayList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(25, 25, 25);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(871, 682);
            ControlBox = false;
            Controls.Add(lbx_canciones);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUnaPlayList";
            Load += FrmUnaPlayList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private ListBox lbx_canciones;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}