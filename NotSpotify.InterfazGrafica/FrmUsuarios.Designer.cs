﻿namespace NotSpotify.InterfazGrafica
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
            dgv_usuariosCargados = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            btn_add = new Button();
            btn_modificar = new Button();
            btn_delete = new Button();
            lbl_usuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_usuariosCargados).BeginInit();
            SuspendLayout();
            // 
            // dgv_usuariosCargados
            // 
            dgv_usuariosCargados.BackgroundColor = Color.Black;
            dgv_usuariosCargados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuariosCargados.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Email, Password });
            dgv_usuariosCargados.Location = new Point(12, 101);
            dgv_usuariosCargados.Name = "dgv_usuariosCargados";
            dgv_usuariosCargados.RowTemplate.Height = 25;
            dgv_usuariosCargados.Size = new Size(706, 337);
            dgv_usuariosCargados.TabIndex = 0;
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
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(128, 255, 255);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Location = new Point(724, 101);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(128, 255, 255);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(724, 130);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 2;
            btn_modificar.Text = "Mod";
            btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(128, 255, 255);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Location = new Point(724, 159);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Del";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // lbl_usuarios
            // 
            lbl_usuarios.AutoSize = true;
            lbl_usuarios.Font = new Font("Palatino Linotype", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuarios.ForeColor = Color.Lime;
            lbl_usuarios.Location = new Point(12, 63);
            lbl_usuarios.Name = "lbl_usuarios";
            lbl_usuarios.Size = new Size(120, 35);
            lbl_usuarios.TabIndex = 4;
            lbl_usuarios.Text = "Usuarios";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(895, 450);
            ControlBox = false;
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
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private Button btn_add;
        private Button btn_modificar;
        private Button btn_delete;
        private Label lbl_usuarios;
    }
}