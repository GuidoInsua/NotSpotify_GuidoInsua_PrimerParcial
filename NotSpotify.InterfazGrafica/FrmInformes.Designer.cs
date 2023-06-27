namespace NotSpotify.InterfazGrafica
{
    partial class FrmInformes
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
            pic_slash = new PictureBox();
            pnl_bordeJson = new Panel();
            pnl_expJson = new Panel();
            btn_cancionesJson = new Button();
            lbl_json = new Label();
            btn_PlayListsJson = new Button();
            btn_usuariosJson = new Button();
            pnl_bordeCsv = new Panel();
            pnl_expCsv = new Panel();
            btn_cancionesCsv = new Button();
            btn_playListsCsv = new Button();
            btn_usuariosCsv = new Button();
            lbl_csv = new Label();
            pnl_contenedor = new Panel();
            pnl_separador = new Panel();
            pbx_tickUsuarioCsv = new PictureBox();
            pbx_tickPlayListCsv = new PictureBox();
            pbx_tickCancionesCsv = new PictureBox();
            pbx_tickUsuarioJson = new PictureBox();
            pbx_tickPlayListJson = new PictureBox();
            pbx_tickCancionesJson = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_slash).BeginInit();
            pnl_bordeJson.SuspendLayout();
            pnl_expJson.SuspendLayout();
            pnl_bordeCsv.SuspendLayout();
            pnl_expCsv.SuspendLayout();
            pnl_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_tickUsuarioCsv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickPlayListCsv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickCancionesCsv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickUsuarioJson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickPlayListJson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickCancionesJson).BeginInit();
            SuspendLayout();
            // 
            // pic_slash
            // 
            pic_slash.BackColor = Color.Black;
            pic_slash.Dock = DockStyle.Right;
            pic_slash.Image = Properties.Resources._222;
            pic_slash.Location = new Point(695, 0);
            pic_slash.Name = "pic_slash";
            pic_slash.Size = new Size(314, 595);
            pic_slash.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_slash.TabIndex = 0;
            pic_slash.TabStop = false;
            // 
            // pnl_bordeJson
            // 
            pnl_bordeJson.BackColor = Color.FromArgb(192, 0, 192);
            pnl_bordeJson.Controls.Add(pnl_expJson);
            pnl_bordeJson.Dock = DockStyle.Bottom;
            pnl_bordeJson.Location = new Point(0, 334);
            pnl_bordeJson.Name = "pnl_bordeJson";
            pnl_bordeJson.Size = new Size(450, 261);
            pnl_bordeJson.TabIndex = 4;
            // 
            // pnl_expJson
            // 
            pnl_expJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_expJson.BackColor = Color.Black;
            pnl_expJson.Controls.Add(pbx_tickCancionesJson);
            pnl_expJson.Controls.Add(btn_cancionesJson);
            pnl_expJson.Controls.Add(pbx_tickPlayListJson);
            pnl_expJson.Controls.Add(lbl_json);
            pnl_expJson.Controls.Add(pbx_tickUsuarioJson);
            pnl_expJson.Controls.Add(btn_PlayListsJson);
            pnl_expJson.Controls.Add(btn_usuariosJson);
            pnl_expJson.Location = new Point(4, 4);
            pnl_expJson.Margin = new Padding(4);
            pnl_expJson.Name = "pnl_expJson";
            pnl_expJson.Size = new Size(442, 253);
            pnl_expJson.TabIndex = 1;
            // 
            // btn_cancionesJson
            // 
            btn_cancionesJson.BackColor = Color.FromArgb(192, 0, 192);
            btn_cancionesJson.FlatAppearance.BorderSize = 0;
            btn_cancionesJson.FlatStyle = FlatStyle.Flat;
            btn_cancionesJson.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancionesJson.Location = new Point(9, 189);
            btn_cancionesJson.Margin = new Padding(9);
            btn_cancionesJson.Name = "btn_cancionesJson";
            btn_cancionesJson.Size = new Size(368, 36);
            btn_cancionesJson.TabIndex = 9;
            btn_cancionesJson.Text = "Canciones";
            btn_cancionesJson.UseVisualStyleBackColor = false;
            btn_cancionesJson.Click += btn_cancionesJson_Click;
            // 
            // lbl_json
            // 
            lbl_json.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_json.AutoSize = true;
            lbl_json.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_json.ForeColor = Color.FromArgb(192, 0, 192);
            lbl_json.Location = new Point(82, 4);
            lbl_json.Margin = new Padding(3, 4, 3, 0);
            lbl_json.Name = "lbl_json";
            lbl_json.Size = new Size(281, 40);
            lbl_json.TabIndex = 1;
            lbl_json.Text = "Exportar como JSON";
            // 
            // btn_PlayListsJson
            // 
            btn_PlayListsJson.BackColor = Color.FromArgb(192, 0, 192);
            btn_PlayListsJson.FlatAppearance.BorderSize = 0;
            btn_PlayListsJson.FlatStyle = FlatStyle.Flat;
            btn_PlayListsJson.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_PlayListsJson.Location = new Point(9, 135);
            btn_PlayListsJson.Margin = new Padding(9);
            btn_PlayListsJson.Name = "btn_PlayListsJson";
            btn_PlayListsJson.Size = new Size(368, 36);
            btn_PlayListsJson.TabIndex = 8;
            btn_PlayListsJson.Text = "PlayLists";
            btn_PlayListsJson.UseVisualStyleBackColor = false;
            btn_PlayListsJson.Click += btn_PlayListsJson_Click;
            // 
            // btn_usuariosJson
            // 
            btn_usuariosJson.BackColor = Color.FromArgb(192, 0, 192);
            btn_usuariosJson.FlatAppearance.BorderSize = 0;
            btn_usuariosJson.FlatStyle = FlatStyle.Flat;
            btn_usuariosJson.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_usuariosJson.Location = new Point(9, 81);
            btn_usuariosJson.Margin = new Padding(9);
            btn_usuariosJson.Name = "btn_usuariosJson";
            btn_usuariosJson.Size = new Size(368, 36);
            btn_usuariosJson.TabIndex = 7;
            btn_usuariosJson.Text = "Usuarios";
            btn_usuariosJson.UseVisualStyleBackColor = false;
            btn_usuariosJson.Click += btn_usuariosJson_Click;
            // 
            // pnl_bordeCsv
            // 
            pnl_bordeCsv.BackColor = Color.FromArgb(192, 0, 192);
            pnl_bordeCsv.Controls.Add(pnl_expCsv);
            pnl_bordeCsv.Dock = DockStyle.Bottom;
            pnl_bordeCsv.Location = new Point(0, 61);
            pnl_bordeCsv.Name = "pnl_bordeCsv";
            pnl_bordeCsv.Size = new Size(450, 261);
            pnl_bordeCsv.TabIndex = 5;
            // 
            // pnl_expCsv
            // 
            pnl_expCsv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_expCsv.BackColor = Color.Black;
            pnl_expCsv.Controls.Add(btn_cancionesCsv);
            pnl_expCsv.Controls.Add(btn_playListsCsv);
            pnl_expCsv.Controls.Add(btn_usuariosCsv);
            pnl_expCsv.Controls.Add(pbx_tickCancionesCsv);
            pnl_expCsv.Controls.Add(lbl_csv);
            pnl_expCsv.Controls.Add(pbx_tickPlayListCsv);
            pnl_expCsv.Controls.Add(pbx_tickUsuarioCsv);
            pnl_expCsv.Location = new Point(4, 4);
            pnl_expCsv.Margin = new Padding(4);
            pnl_expCsv.Name = "pnl_expCsv";
            pnl_expCsv.Size = new Size(442, 253);
            pnl_expCsv.TabIndex = 0;
            // 
            // btn_cancionesCsv
            // 
            btn_cancionesCsv.BackColor = Color.FromArgb(192, 0, 192);
            btn_cancionesCsv.FlatAppearance.BorderSize = 0;
            btn_cancionesCsv.FlatStyle = FlatStyle.Flat;
            btn_cancionesCsv.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancionesCsv.Location = new Point(9, 189);
            btn_cancionesCsv.Margin = new Padding(9);
            btn_cancionesCsv.Name = "btn_cancionesCsv";
            btn_cancionesCsv.Size = new Size(368, 36);
            btn_cancionesCsv.TabIndex = 6;
            btn_cancionesCsv.Text = "Canciones";
            btn_cancionesCsv.UseVisualStyleBackColor = false;
            btn_cancionesCsv.Click += btn_cancionesCsv_Click;
            // 
            // btn_playListsCsv
            // 
            btn_playListsCsv.BackColor = Color.FromArgb(192, 0, 192);
            btn_playListsCsv.FlatAppearance.BorderSize = 0;
            btn_playListsCsv.FlatStyle = FlatStyle.Flat;
            btn_playListsCsv.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_playListsCsv.Location = new Point(9, 135);
            btn_playListsCsv.Margin = new Padding(9);
            btn_playListsCsv.Name = "btn_playListsCsv";
            btn_playListsCsv.Size = new Size(368, 36);
            btn_playListsCsv.TabIndex = 5;
            btn_playListsCsv.Text = "PlayLists";
            btn_playListsCsv.UseVisualStyleBackColor = false;
            btn_playListsCsv.Click += btn_playListsCsv_Click;
            // 
            // btn_usuariosCsv
            // 
            btn_usuariosCsv.BackColor = Color.FromArgb(192, 0, 192);
            btn_usuariosCsv.FlatAppearance.BorderSize = 0;
            btn_usuariosCsv.FlatStyle = FlatStyle.Flat;
            btn_usuariosCsv.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_usuariosCsv.Location = new Point(9, 81);
            btn_usuariosCsv.Margin = new Padding(9);
            btn_usuariosCsv.Name = "btn_usuariosCsv";
            btn_usuariosCsv.Size = new Size(368, 36);
            btn_usuariosCsv.TabIndex = 4;
            btn_usuariosCsv.Text = "Usuarios";
            btn_usuariosCsv.UseVisualStyleBackColor = false;
            btn_usuariosCsv.Click += btn_usuariosCsv_Click;
            // 
            // lbl_csv
            // 
            lbl_csv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_csv.AutoSize = true;
            lbl_csv.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_csv.ForeColor = Color.FromArgb(192, 0, 192);
            lbl_csv.Location = new Point(82, 4);
            lbl_csv.Margin = new Padding(3, 4, 3, 0);
            lbl_csv.Name = "lbl_csv";
            lbl_csv.Size = new Size(263, 40);
            lbl_csv.TabIndex = 2;
            lbl_csv.Text = "Exportar como CSV";
            // 
            // pnl_contenedor
            // 
            pnl_contenedor.Controls.Add(pnl_bordeCsv);
            pnl_contenedor.Controls.Add(pnl_separador);
            pnl_contenedor.Controls.Add(pnl_bordeJson);
            pnl_contenedor.Dock = DockStyle.Left;
            pnl_contenedor.Location = new Point(0, 0);
            pnl_contenedor.Name = "pnl_contenedor";
            pnl_contenedor.Size = new Size(450, 595);
            pnl_contenedor.TabIndex = 6;
            // 
            // pnl_separador
            // 
            pnl_separador.BackColor = Color.Black;
            pnl_separador.Dock = DockStyle.Bottom;
            pnl_separador.Location = new Point(0, 322);
            pnl_separador.Name = "pnl_separador";
            pnl_separador.Size = new Size(450, 12);
            pnl_separador.TabIndex = 6;
            // 
            // pbx_tickUsuarioCsv
            // 
            pbx_tickUsuarioCsv.Image = Properties.Resources.tickVerde;
            pbx_tickUsuarioCsv.Location = new Point(389, 81);
            pbx_tickUsuarioCsv.Name = "pbx_tickUsuarioCsv";
            pbx_tickUsuarioCsv.Size = new Size(44, 36);
            pbx_tickUsuarioCsv.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_tickUsuarioCsv.TabIndex = 7;
            pbx_tickUsuarioCsv.TabStop = false;
            // 
            // pbx_tickPlayListCsv
            // 
            pbx_tickPlayListCsv.Image = Properties.Resources.tickVerde;
            pbx_tickPlayListCsv.Location = new Point(389, 135);
            pbx_tickPlayListCsv.Name = "pbx_tickPlayListCsv";
            pbx_tickPlayListCsv.Size = new Size(44, 36);
            pbx_tickPlayListCsv.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_tickPlayListCsv.TabIndex = 8;
            pbx_tickPlayListCsv.TabStop = false;
            // 
            // pbx_tickCancionesCsv
            // 
            pbx_tickCancionesCsv.Image = Properties.Resources.tickVerde;
            pbx_tickCancionesCsv.Location = new Point(389, 189);
            pbx_tickCancionesCsv.Name = "pbx_tickCancionesCsv";
            pbx_tickCancionesCsv.Size = new Size(44, 36);
            pbx_tickCancionesCsv.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_tickCancionesCsv.TabIndex = 9;
            pbx_tickCancionesCsv.TabStop = false;
            // 
            // pbx_tickUsuarioJson
            // 
            pbx_tickUsuarioJson.Image = Properties.Resources.tickVerde;
            pbx_tickUsuarioJson.Location = new Point(389, 81);
            pbx_tickUsuarioJson.Name = "pbx_tickUsuarioJson";
            pbx_tickUsuarioJson.Size = new Size(44, 36);
            pbx_tickUsuarioJson.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_tickUsuarioJson.TabIndex = 10;
            pbx_tickUsuarioJson.TabStop = false;
            // 
            // pbx_tickPlayListJson
            // 
            pbx_tickPlayListJson.Image = Properties.Resources.tickVerde;
            pbx_tickPlayListJson.Location = new Point(389, 135);
            pbx_tickPlayListJson.Name = "pbx_tickPlayListJson";
            pbx_tickPlayListJson.Size = new Size(44, 36);
            pbx_tickPlayListJson.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_tickPlayListJson.TabIndex = 11;
            pbx_tickPlayListJson.TabStop = false;
            // 
            // pbx_tickCancionesJson
            // 
            pbx_tickCancionesJson.Image = Properties.Resources.tickVerde;
            pbx_tickCancionesJson.Location = new Point(389, 189);
            pbx_tickCancionesJson.Name = "pbx_tickCancionesJson";
            pbx_tickCancionesJson.Size = new Size(44, 36);
            pbx_tickCancionesJson.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_tickCancionesJson.TabIndex = 12;
            pbx_tickCancionesJson.TabStop = false;
            // 
            // FrmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1009, 595);
            ControlBox = false;
            Controls.Add(pnl_contenedor);
            Controls.Add(pic_slash);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInformes";
            Load += FrmInformes_Load;
            ((System.ComponentModel.ISupportInitialize)pic_slash).EndInit();
            pnl_bordeJson.ResumeLayout(false);
            pnl_expJson.ResumeLayout(false);
            pnl_expJson.PerformLayout();
            pnl_bordeCsv.ResumeLayout(false);
            pnl_expCsv.ResumeLayout(false);
            pnl_expCsv.PerformLayout();
            pnl_contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_tickUsuarioCsv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickPlayListCsv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickCancionesCsv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickUsuarioJson).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickPlayListJson).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_tickCancionesJson).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_slash;
        private Panel pnl_bordeJson;
        private Panel pnl_expJson;
        private Label lbl_json;
        private Panel pnl_bordeCsv;
        private Panel pnl_expCsv;
        private Panel pnl_contenedor;
        private Panel pnl_separador;
        private Label lbl_csv;
        private Button btn_cancionesJson;
        private Button btn_PlayListsJson;
        private Button btn_usuariosJson;
        private Button btn_cancionesCsv;
        private Button btn_playListsCsv;
        private Button btn_usuariosCsv;
        private PictureBox pbx_tickUsuarioCsv;
        private PictureBox pbx_tickPlayListCsv;
        private PictureBox pbx_tickCancionesCsv;
        private PictureBox pbx_tickUsuarioJson;
        private PictureBox pbx_tickPlayListJson;
        private PictureBox pbx_tickCancionesJson;
    }
}