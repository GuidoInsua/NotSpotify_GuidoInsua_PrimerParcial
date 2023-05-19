namespace NotSpotify.InterfazGrafica
{
    partial class FrmLibrary
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
            btn_tema1 = new Button();
            btn_tema2 = new Button();
            btn_tema3 = new Button();
            btn_tema4 = new Button();
            SuspendLayout();
            // 
            // btn_tema1
            // 
            btn_tema1.BackColor = Color.FromArgb(128, 128, 255);
            btn_tema1.FlatAppearance.BorderSize = 0;
            btn_tema1.FlatStyle = FlatStyle.Flat;
            btn_tema1.Location = new Point(51, 59);
            btn_tema1.Name = "btn_tema1";
            btn_tema1.Size = new Size(105, 81);
            btn_tema1.TabIndex = 0;
            btn_tema1.Text = "Tema1";
            btn_tema1.UseVisualStyleBackColor = false;
            btn_tema1.Click += btn_tema1_Click;
            // 
            // btn_tema2
            // 
            btn_tema2.BackColor = Color.FromArgb(128, 128, 255);
            btn_tema2.FlatAppearance.BorderSize = 0;
            btn_tema2.FlatStyle = FlatStyle.Flat;
            btn_tema2.Location = new Point(162, 59);
            btn_tema2.Name = "btn_tema2";
            btn_tema2.Size = new Size(105, 81);
            btn_tema2.TabIndex = 1;
            btn_tema2.Text = "Tema2";
            btn_tema2.UseVisualStyleBackColor = false;
            btn_tema2.Click += btn_tema2_Click;
            // 
            // btn_tema3
            // 
            btn_tema3.BackColor = Color.FromArgb(128, 128, 255);
            btn_tema3.FlatAppearance.BorderSize = 0;
            btn_tema3.FlatStyle = FlatStyle.Flat;
            btn_tema3.Location = new Point(273, 59);
            btn_tema3.Name = "btn_tema3";
            btn_tema3.Size = new Size(105, 81);
            btn_tema3.TabIndex = 2;
            btn_tema3.Text = "Tema3";
            btn_tema3.UseVisualStyleBackColor = false;
            btn_tema3.Click += btn_tema3_Click;
            // 
            // btn_tema4
            // 
            btn_tema4.BackColor = Color.FromArgb(128, 128, 255);
            btn_tema4.FlatAppearance.BorderSize = 0;
            btn_tema4.FlatStyle = FlatStyle.Flat;
            btn_tema4.Location = new Point(384, 59);
            btn_tema4.Name = "btn_tema4";
            btn_tema4.Size = new Size(105, 81);
            btn_tema4.TabIndex = 3;
            btn_tema4.Text = "Tema4";
            btn_tema4.UseVisualStyleBackColor = false;
            btn_tema4.Click += btn_tema4_Click;
            // 
            // FrmLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1058, 556);
            ControlBox = false;
            Controls.Add(btn_tema4);
            Controls.Add(btn_tema3);
            Controls.Add(btn_tema2);
            Controls.Add(btn_tema1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLibrary";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_tema1;
        private Button btn_tema2;
        private Button btn_tema3;
        private Button btn_tema4;
    }
}