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
            lbl_administradores = new Label();
            dgv_adminsCargados = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            btn_add = new Button();
            btn_modificar = new Button();
            btn_delete = new Button();
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
            lbl_administradores.Click += lbl_administradores_Click;
            // 
            // dgv_adminsCargados
            // 
            dgv_adminsCargados.BackgroundColor = Color.Black;
            dgv_adminsCargados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adminsCargados.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Email, Password, Dni });
            dgv_adminsCargados.Location = new Point(12, 130);
            dgv_adminsCargados.Name = "dgv_adminsCargados";
            dgv_adminsCargados.RowTemplate.Height = 25;
            dgv_adminsCargados.Size = new Size(796, 308);
            dgv_adminsCargados.TabIndex = 6;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 160;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 160;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 160;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.Width = 160;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.Name = "Dni";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(128, 255, 255);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Location = new Point(814, 130);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(128, 255, 255);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(814, 159);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 8;
            btn_modificar.Text = "Mod";
            btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(128, 255, 255);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Location = new Point(814, 188);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Del";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // FrmAdministradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(895, 450);
            ControlBox = false;
            Controls.Add(btn_delete);
            Controls.Add(btn_modificar);
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
        private Button btn_add;
        private Button btn_modificar;
        private Button btn_delete;
        private DataGridViewTextBoxColumn Dni;
    }
}