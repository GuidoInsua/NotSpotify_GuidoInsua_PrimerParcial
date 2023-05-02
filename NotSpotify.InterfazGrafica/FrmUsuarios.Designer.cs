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
            btn_add = new Button();
            btn_modificar = new Button();
            btn_delete = new Button();
            lbl_usuarios = new Label();
            btn_refresh = new Button();
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
            dgv_usuariosCargados.Location = new Point(12, 120);
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
            dgv_usuariosCargados.Size = new Size(688, 463);
            dgv_usuariosCargados.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.False;
            Nombre.Width = 160;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Resizable = DataGridViewTriState.False;
            Apellido.Width = 160;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Resizable = DataGridViewTriState.False;
            Email.Width = 160;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Resizable = DataGridViewTriState.False;
            Password.Width = 160;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(128, 255, 255);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Location = new Point(659, 91);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(41, 23);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(128, 255, 255);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(608, 91);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(45, 23);
            btn_modificar.TabIndex = 2;
            btn_modificar.Text = "Mod";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(128, 255, 255);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Location = new Point(563, 91);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(39, 23);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Del";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // lbl_usuarios
            // 
            lbl_usuarios.AutoSize = true;
            lbl_usuarios.Font = new Font("Palatino Linotype", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuarios.ForeColor = Color.Lime;
            lbl_usuarios.Location = new Point(12, 82);
            lbl_usuarios.Name = "lbl_usuarios";
            lbl_usuarios.Size = new Size(120, 35);
            lbl_usuarios.TabIndex = 4;
            lbl_usuarios.Text = "Usuarios";
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.FromArgb(128, 255, 255);
            btn_refresh.FlatAppearance.BorderSize = 0;
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Location = new Point(518, 91);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(39, 23);
            btn_refresh.TabIndex = 5;
            btn_refresh.Text = "Ref";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(812, 595);
            ControlBox = false;
            Controls.Add(btn_refresh);
            Controls.Add(lbl_usuarios);
            Controls.Add(btn_delete);
            Controls.Add(btn_modificar);
            Controls.Add(btn_add);
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
        private Button btn_add;
        private Button btn_modificar;
        private Button btn_delete;
        private Label lbl_usuarios;
        private Button btn_refresh;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
    }
}