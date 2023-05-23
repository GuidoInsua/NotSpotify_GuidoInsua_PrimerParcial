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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibrary));
            dgv_canciones = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            lbl_canciones = new Label();
            pnl_banner = new Panel();
            pbx_imagenBanner = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_canciones).BeginInit();
            pnl_banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_imagenBanner).BeginInit();
            SuspendLayout();
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
            dgv_canciones.Location = new Point(44, 174);
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
            dgv_canciones.Size = new Size(1002, 370);
            dgv_canciones.TabIndex = 11;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // lbl_canciones
            // 
            lbl_canciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_canciones.AutoSize = true;
            lbl_canciones.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_canciones.ForeColor = Color.Black;
            lbl_canciones.Location = new Point(12, 74);
            lbl_canciones.Name = "lbl_canciones";
            lbl_canciones.Size = new Size(153, 32);
            lbl_canciones.TabIndex = 22;
            lbl_canciones.Text = "Canciones";
            // 
            // pnl_banner
            // 
            pnl_banner.BackColor = Color.FromArgb(51, 135, 193);
            pnl_banner.Controls.Add(lbl_canciones);
            pnl_banner.Controls.Add(pbx_imagenBanner);
            pnl_banner.Dock = DockStyle.Top;
            pnl_banner.Location = new Point(0, 0);
            pnl_banner.Name = "pnl_banner";
            pnl_banner.Size = new Size(1058, 114);
            pnl_banner.TabIndex = 23;
            // 
            // pbx_imagenBanner
            // 
            pbx_imagenBanner.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbx_imagenBanner.Image = (Image)resources.GetObject("pbx_imagenBanner.Image");
            pbx_imagenBanner.Location = new Point(384, 0);
            pbx_imagenBanner.Name = "pbx_imagenBanner";
            pbx_imagenBanner.Size = new Size(674, 114);
            pbx_imagenBanner.SizeMode = PictureBoxSizeMode.CenterImage;
            pbx_imagenBanner.TabIndex = 23;
            pbx_imagenBanner.TabStop = false;
            // 
            // FrmLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1058, 556);
            ControlBox = false;
            Controls.Add(dgv_canciones);
            Controls.Add(pnl_banner);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLibrary";
            Load += FrmLibrary_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_canciones).EndInit();
            pnl_banner.ResumeLayout(false);
            pnl_banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_imagenBanner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_canciones;
        private DataGridViewTextBoxColumn Nombre;
        private Label lbl_canciones;
        private Panel pnl_banner;
        private PictureBox pbx_imagenBanner;
    }
}