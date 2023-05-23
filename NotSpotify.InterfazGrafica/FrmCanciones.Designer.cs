namespace NotSpotify.InterfazGrafica
{
    partial class FrmCanciones
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
            lbl_canciones = new Label();
            dgv_canciones = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Path = new DataGridViewTextBoxColumn();
            tbx_linkCancion = new TextBox();
            btn_add = new Controles.BotonAdd();
            btn_borrar = new Controles.BotonBorrar();
            tbx_nombre = new TextBox();
            lbl_cargando = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_canciones).BeginInit();
            SuspendLayout();
            // 
            // lbl_canciones
            // 
            lbl_canciones.AutoSize = true;
            lbl_canciones.Font = new Font("Palatino Linotype", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_canciones.ForeColor = Color.Lime;
            lbl_canciones.Location = new Point(12, 96);
            lbl_canciones.Name = "lbl_canciones";
            lbl_canciones.Size = new Size(139, 35);
            lbl_canciones.TabIndex = 6;
            lbl_canciones.Text = "Canciones";
            // 
            // dgv_canciones
            // 
            dgv_canciones.AllowUserToAddRows = false;
            dgv_canciones.AllowUserToDeleteRows = false;
            dgv_canciones.AllowUserToResizeColumns = false;
            dgv_canciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_canciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_canciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_canciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_canciones.BackgroundColor = Color.Black;
            dgv_canciones.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_canciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Firebrick;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_canciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_canciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_canciones.Columns.AddRange(new DataGridViewColumn[] { Nombre, Path });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_canciones.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_canciones.EnableHeadersVisualStyles = false;
            dgv_canciones.Location = new Point(12, 134);
            dgv_canciones.MultiSelect = false;
            dgv_canciones.Name = "dgv_canciones";
            dgv_canciones.ReadOnly = true;
            dgv_canciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Firebrick;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_canciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_canciones.RowHeadersWidth = 20;
            dgv_canciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_canciones.RowTemplate.Height = 25;
            dgv_canciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_canciones.Size = new Size(964, 392);
            dgv_canciones.TabIndex = 12;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Path
            // 
            Path.HeaderText = "Path";
            Path.Name = "Path";
            Path.ReadOnly = true;
            Path.Resizable = DataGridViewTriState.False;
            // 
            // tbx_linkCancion
            // 
            tbx_linkCancion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_linkCancion.Location = new Point(644, 108);
            tbx_linkCancion.Name = "tbx_linkCancion";
            tbx_linkCancion.Size = new Size(300, 23);
            tbx_linkCancion.TabIndex = 16;
            tbx_linkCancion.Text = "Link YouTube";
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.Location = new Point(612, 105);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(26, 26);
            btn_add.TabIndex = 17;
            btn_add.Click += btn_add_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_borrar.Location = new Point(950, 105);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(26, 26);
            btn_borrar.TabIndex = 18;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // tbx_nombre
            // 
            tbx_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_nombre.Location = new Point(644, 79);
            tbx_nombre.Name = "tbx_nombre";
            tbx_nombre.Size = new Size(300, 23);
            tbx_nombre.TabIndex = 20;
            tbx_nombre.Text = "Nombre";
            // 
            // lbl_cargando
            // 
            lbl_cargando.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_cargando.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cargando.ForeColor = Color.White;
            lbl_cargando.Location = new Point(385, 112);
            lbl_cargando.Name = "lbl_cargando";
            lbl_cargando.Size = new Size(221, 19);
            lbl_cargando.TabIndex = 21;
            lbl_cargando.Text = ".";
            lbl_cargando.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmCanciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(988, 538);
            ControlBox = false;
            Controls.Add(lbl_cargando);
            Controls.Add(tbx_nombre);
            Controls.Add(btn_borrar);
            Controls.Add(btn_add);
            Controls.Add(tbx_linkCancion);
            Controls.Add(dgv_canciones);
            Controls.Add(lbl_canciones);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCanciones";
            Load += FrmCanciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_canciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_canciones;
        private DataGridView dgv_canciones;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Path;
        private TextBox tbx_linkCancion;
        private Controles.BotonAdd btn_add;
        private Controles.BotonBorrar btn_borrar;
        private TextBox tbx_nombre;
        private Label lbl_cargando;
    }
}