namespace NotSpotify.InterfazGrafica
{
    partial class FrmUsuarios
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
            dgv_usuariosCargados = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            lbl_usuarios = new Label();
            btn_add = new Controles.BotonAdd();
            btn_borrar = new Controles.BotonBorrar();
            btn_editar = new Controles.BotonEditar();
            btn_ascender = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_usuariosCargados).BeginInit();
            SuspendLayout();
            // 
            // dgv_usuariosCargados
            // 
            dgv_usuariosCargados.AllowUserToAddRows = false;
            dgv_usuariosCargados.AllowUserToDeleteRows = false;
            dgv_usuariosCargados.AllowUserToResizeColumns = false;
            dgv_usuariosCargados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_usuariosCargados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_usuariosCargados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_usuariosCargados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_usuariosCargados.BackgroundColor = Color.Black;
            dgv_usuariosCargados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_usuariosCargados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Firebrick;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_usuariosCargados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_usuariosCargados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_usuariosCargados.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Email, Password });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_usuariosCargados.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_usuariosCargados.EnableHeadersVisualStyles = false;
            dgv_usuariosCargados.Location = new Point(12, 132);
            dgv_usuariosCargados.MultiSelect = false;
            dgv_usuariosCargados.Name = "dgv_usuariosCargados";
            dgv_usuariosCargados.ReadOnly = true;
            dgv_usuariosCargados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Firebrick;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_usuariosCargados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_usuariosCargados.RowHeadersWidth = 20;
            dgv_usuariosCargados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_usuariosCargados.RowTemplate.Height = 25;
            dgv_usuariosCargados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_usuariosCargados.Size = new Size(985, 451);
            dgv_usuariosCargados.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.False;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Resizable = DataGridViewTriState.False;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Resizable = DataGridViewTriState.False;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Resizable = DataGridViewTriState.False;
            // 
            // lbl_usuarios
            // 
            lbl_usuarios.AutoSize = true;
            lbl_usuarios.Font = new Font("Palatino Linotype", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuarios.ForeColor = Color.Lime;
            lbl_usuarios.Location = new Point(12, 94);
            lbl_usuarios.Name = "lbl_usuarios";
            lbl_usuarios.Size = new Size(120, 35);
            lbl_usuarios.TabIndex = 4;
            lbl_usuarios.Text = "Usuarios";
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.Location = new Point(971, 100);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(26, 26);
            btn_add.TabIndex = 8;
            btn_add.MyClick += btn_add_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_borrar.Location = new Point(907, 100);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(26, 26);
            btn_borrar.TabIndex = 9;
            btn_borrar.MyClick += btn_borrar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.Location = new Point(939, 100);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(26, 26);
            btn_editar.TabIndex = 10;
            btn_editar.MyClick += btn_editar_Click;
            // 
            // btn_ascender
            // 
            btn_ascender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ascender.BackColor = Color.Cyan;
            btn_ascender.FlatAppearance.BorderSize = 0;
            btn_ascender.FlatStyle = FlatStyle.Flat;
            btn_ascender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ascender.Location = new Point(875, 100);
            btn_ascender.Name = "btn_ascender";
            btn_ascender.Size = new Size(26, 26);
            btn_ascender.TabIndex = 15;
            btn_ascender.Text = "^";
            btn_ascender.UseVisualStyleBackColor = false;
            btn_ascender.Click += btn_ascender_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1009, 595);
            ControlBox = false;
            Controls.Add(btn_ascender);
            Controls.Add(btn_editar);
            Controls.Add(btn_borrar);
            Controls.Add(btn_add);
            Controls.Add(lbl_usuarios);
            Controls.Add(dgv_usuariosCargados);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_usuariosCargados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_usuariosCargados;
        private Label lbl_usuarios;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private Controles.BotonAdd btn_add;
        private Controles.BotonBorrar btn_borrar;
        private Controles.BotonEditar btn_editar;
        private Button btn_ascender;
    }
}