namespace NotSpotify.InterfazGrafica
{
    partial class FrmInformacion
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
            lbl_titulo = new Label();
            tbx_dni = new TextBox();
            lbl_dni = new Label();
            pnl_movimiento = new PanelMovimiento();
            lbl_texto = new Label();
            btn_cancelar = new Button();
            btn_acceptar = new Button();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Palatino Linotype", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.ForeColor = Color.Lime;
            lbl_titulo.Location = new Point(151, 47);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(109, 35);
            lbl_titulo.TabIndex = 7;
            lbl_titulo.Text = "Agregar";
            // 
            // tbx_dni
            // 
            tbx_dni.BorderStyle = BorderStyle.None;
            tbx_dni.Location = new Point(14, 220);
            tbx_dni.Name = "tbx_dni";
            tbx_dni.Size = new Size(283, 16);
            tbx_dni.TabIndex = 16;
            tbx_dni.Visible = false;
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dni.ForeColor = Color.Lime;
            lbl_dni.Location = new Point(12, 197);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(33, 20);
            lbl_dni.TabIndex = 15;
            lbl_dni.Text = "Dni";
            lbl_dni.Visible = false;
            // 
            // pnl_movimiento
            // 
            pnl_movimiento.Dock = DockStyle.Top;
            pnl_movimiento.Location = new Point(0, 0);
            pnl_movimiento.Name = "pnl_movimiento";
            pnl_movimiento.Size = new Size(404, 44);
            pnl_movimiento.TabIndex = 17;
            pnl_movimiento.Load += pnl_movimiento_Load;
            // 
            // lbl_texto
            // 
            lbl_texto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_texto.ForeColor = Color.White;
            lbl_texto.Location = new Point(12, 93);
            lbl_texto.Name = "lbl_texto";
            lbl_texto.Size = new Size(380, 104);
            lbl_texto.TabIndex = 18;
            lbl_texto.Text = "Esta seguro";
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(128, 255, 255);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(134, 269);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(126, 23);
            btn_cancelar.TabIndex = 20;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_acceptar
            // 
            btn_acceptar.BackColor = Color.FromArgb(128, 255, 255);
            btn_acceptar.FlatAppearance.BorderSize = 0;
            btn_acceptar.FlatStyle = FlatStyle.Flat;
            btn_acceptar.Location = new Point(266, 269);
            btn_acceptar.Name = "btn_acceptar";
            btn_acceptar.Size = new Size(126, 23);
            btn_acceptar.TabIndex = 19;
            btn_acceptar.Text = "Acceptar";
            btn_acceptar.UseVisualStyleBackColor = false;
            btn_acceptar.Click += btn_acceptar_Click;
            // 
            // FrmInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(404, 304);
            ControlBox = false;
            Controls.Add(btn_cancelar);
            Controls.Add(btn_acceptar);
            Controls.Add(lbl_texto);
            Controls.Add(pnl_movimiento);
            Controls.Add(tbx_dni);
            Controls.Add(lbl_dni);
            Controls.Add(lbl_titulo);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInformacion";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmInformacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private TextBox tbx_dni;
        private Label lbl_dni;
        private PanelMovimiento pnl_movimiento;
        private Label lbl_texto;
        private Button btn_cancelar;
        private Button btn_acceptar;
    }
}