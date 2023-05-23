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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btn_playListRandom = new Button();
            dgv_canciones = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_canciones).BeginInit();
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
            // panel3
            // 
            panel3.Controls.Add(btn_playListRandom);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(871, 89);
            panel3.TabIndex = 2;
            // 
            // btn_playListRandom
            // 
            btn_playListRandom.BackColor = Color.FromArgb(0, 192, 0);
            btn_playListRandom.FlatAppearance.BorderSize = 0;
            btn_playListRandom.FlatStyle = FlatStyle.Flat;
            btn_playListRandom.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_playListRandom.Location = new Point(29, 26);
            btn_playListRandom.Name = "btn_playListRandom";
            btn_playListRandom.Size = new Size(39, 38);
            btn_playListRandom.TabIndex = 0;
            btn_playListRandom.Text = ">";
            btn_playListRandom.UseVisualStyleBackColor = false;
            btn_playListRandom.Click += btn_playListRandom_Click;
            // 
            // dgv_canciones
            // 
            dgv_canciones.AllowUserToAddRows = false;
            dgv_canciones.AllowUserToDeleteRows = false;
            dgv_canciones.AllowUserToResizeColumns = false;
            dgv_canciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_canciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_canciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_canciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_canciones.BackgroundColor = Color.Black;
            dgv_canciones.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_canciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_canciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_canciones.ColumnHeadersHeight = 4;
            dgv_canciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_canciones.ColumnHeadersVisible = false;
            dgv_canciones.Columns.AddRange(new DataGridViewColumn[] { Nombre });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_canciones.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_canciones.EnableHeadersVisualStyles = false;
            dgv_canciones.Location = new Point(12, 317);
            dgv_canciones.MultiSelect = false;
            dgv_canciones.Name = "dgv_canciones";
            dgv_canciones.ReadOnly = true;
            dgv_canciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_canciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_canciones.RowHeadersVisible = false;
            dgv_canciones.RowHeadersWidth = 20;
            dgv_canciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_canciones.RowTemplate.Height = 25;
            dgv_canciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_canciones.Size = new Size(847, 353);
            dgv_canciones.TabIndex = 12;
            dgv_canciones.CellClick += dgv_canciones_CellClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // FrmUnaPlayList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(871, 682);
            ControlBox = false;
            Controls.Add(dgv_canciones);
            Controls.Add(panel3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUnaPlayList";
            Load += FrmUnaPlayList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_canciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btn_playListRandom;
        private Label label2;
        private Label label3;
        private DataGridView dgv_canciones;
        private DataGridViewTextBoxColumn Nombre;
    }
}