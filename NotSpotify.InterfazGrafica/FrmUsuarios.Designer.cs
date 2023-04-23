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
            dgr_listaUsuarios = new DataGridView();
            columnaNombre = new DataGridViewTextBoxColumn();
            columnaApellido = new DataGridViewTextBoxColumn();
            comlumnaEmail = new DataGridViewTextBoxColumn();
            columnaPassword = new DataGridViewTextBoxColumn();
            btn_del = new Button();
            btn_mod = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgr_listaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgr_listaUsuarios
            // 
            dgr_listaUsuarios.AllowUserToAddRows = false;
            dgr_listaUsuarios.AllowUserToDeleteRows = false;
            dgr_listaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgr_listaUsuarios.Columns.AddRange(new DataGridViewColumn[] { columnaNombre, columnaApellido, comlumnaEmail, columnaPassword });
            dgr_listaUsuarios.Location = new Point(12, 61);
            dgr_listaUsuarios.Name = "dgr_listaUsuarios";
            dgr_listaUsuarios.ReadOnly = true;
            dgr_listaUsuarios.RowTemplate.Height = 25;
            dgr_listaUsuarios.Size = new Size(636, 377);
            dgr_listaUsuarios.TabIndex = 0;
            // 
            // columnaNombre
            // 
            columnaNombre.HeaderText = "Nombre";
            columnaNombre.Name = "columnaNombre";
            columnaNombre.ReadOnly = true;
            columnaNombre.Width = 150;
            // 
            // columnaApellido
            // 
            columnaApellido.HeaderText = "Apellido";
            columnaApellido.Name = "columnaApellido";
            columnaApellido.ReadOnly = true;
            columnaApellido.Width = 150;
            // 
            // comlumnaEmail
            // 
            comlumnaEmail.HeaderText = "Email";
            comlumnaEmail.Name = "comlumnaEmail";
            comlumnaEmail.ReadOnly = true;
            comlumnaEmail.Width = 150;
            // 
            // columnaPassword
            // 
            columnaPassword.HeaderText = "Password";
            columnaPassword.Name = "columnaPassword";
            columnaPassword.ReadOnly = true;
            columnaPassword.Width = 150;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(601, 32);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(47, 23);
            btn_del.TabIndex = 1;
            btn_del.Text = "Del";
            btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_mod
            // 
            btn_mod.Location = new Point(548, 32);
            btn_mod.Name = "btn_mod";
            btn_mod.Size = new Size(47, 23);
            btn_mod.TabIndex = 2;
            btn_mod.Text = "Mod";
            btn_mod.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(495, 32);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(47, 23);
            btn_add.TabIndex = 3;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btn_add);
            Controls.Add(btn_mod);
            Controls.Add(btn_del);
            Controls.Add(dgr_listaUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuarios";
            WindowState = FormWindowState.Maximized;
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgr_listaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgr_listaUsuarios;
        private Button btn_del;
        private Button btn_mod;
        private Button btn_add;
        private DataGridViewTextBoxColumn columnaNombre;
        private DataGridViewTextBoxColumn columnaApellido;
        private DataGridViewTextBoxColumn comlumnaEmail;
        private DataGridViewTextBoxColumn columnaPassword;
    }
}