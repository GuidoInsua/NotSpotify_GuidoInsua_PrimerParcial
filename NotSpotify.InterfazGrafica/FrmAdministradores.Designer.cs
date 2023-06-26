namespace NotSpotify.InterfazGrafica
{
    partial class FrmAdministradores
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lbl_administradores = new Label();
            dgv_adminsCargados = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            btn_add = new Controles.BotonAdd();
            btn_editar = new Controles.BotonEditar();
            btn_borrar = new Controles.BotonBorrar();
            btn_degradar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_adminsCargados).BeginInit();
            SuspendLayout();
            // 
            // lbl_administradores
            // 
            lbl_administradores.AutoSize = true;
            lbl_administradores.Font = new Font("Palatino Linotype", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_administradores.ForeColor = Color.Lime;
            lbl_administradores.Location = new Point(12, 92);
            lbl_administradores.Name = "lbl_administradores";
            lbl_administradores.Size = new Size(215, 35);
            lbl_administradores.TabIndex = 5;
            lbl_administradores.Text = "Administradores";
            // 
            // dgv_adminsCargados
            // 
            dgv_adminsCargados.AllowUserToAddRows = false;
            dgv_adminsCargados.AllowUserToDeleteRows = false;
            dgv_adminsCargados.AllowUserToResizeColumns = false;
            dgv_adminsCargados.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgv_adminsCargados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_adminsCargados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_adminsCargados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_adminsCargados.BackgroundColor = Color.Black;
            dgv_adminsCargados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_adminsCargados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Firebrick;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_adminsCargados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_adminsCargados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_adminsCargados.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Email, Password, Dni });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgv_adminsCargados.DefaultCellStyle = dataGridViewCellStyle7;
            dgv_adminsCargados.EnableHeadersVisualStyles = false;
            dgv_adminsCargados.Location = new Point(12, 130);
            dgv_adminsCargados.MultiSelect = false;
            dgv_adminsCargados.Name = "dgv_adminsCargados";
            dgv_adminsCargados.ReadOnly = true;
            dgv_adminsCargados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Firebrick;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_adminsCargados.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgv_adminsCargados.RowHeadersWidth = 20;
            dgv_adminsCargados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_adminsCargados.RowTemplate.Height = 25;
            dgv_adminsCargados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_adminsCargados.Size = new Size(966, 398);
            dgv_adminsCargados.TabIndex = 10;
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
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            Dni.Resizable = DataGridViewTriState.False;
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.Location = new Point(952, 101);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(26, 26);
            btn_add.TabIndex = 11;
            btn_add.MyClick += btn_add_Click;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.Location = new Point(920, 101);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(26, 26);
            btn_editar.TabIndex = 12;
            btn_editar.MyClick += btn_editar_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_borrar.Location = new Point(888, 101);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(26, 26);
            btn_borrar.TabIndex = 13;
            btn_borrar.MyClick += btn_borrar_Click;
            // 
            // btn_degradar
            // 
            btn_degradar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_degradar.BackColor = Color.Cyan;
            btn_degradar.FlatAppearance.BorderSize = 0;
            btn_degradar.FlatStyle = FlatStyle.Flat;
            btn_degradar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_degradar.Location = new Point(856, 101);
            btn_degradar.Name = "btn_degradar";
            btn_degradar.Size = new Size(26, 26);
            btn_degradar.TabIndex = 14;
            btn_degradar.Text = "V";
            btn_degradar.UseVisualStyleBackColor = false;
            btn_degradar.Click += btn_degradar_Click;
            // 
            // FrmAdministradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(990, 540);
            ControlBox = false;
            Controls.Add(btn_degradar);
            Controls.Add(btn_borrar);
            Controls.Add(btn_editar);
            Controls.Add(btn_add);
            Controls.Add(dgv_adminsCargados);
            Controls.Add(lbl_administradores);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdministradores";
            Load += FrmAdministradores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_adminsCargados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_administradores;
        private DataGridView dgv_adminsCargados;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Dni;
        private Controles.BotonAdd btn_add;
        private Controles.BotonEditar btn_editar;
        private Controles.BotonBorrar btn_borrar;
        private Button btn_degradar;
    }
}