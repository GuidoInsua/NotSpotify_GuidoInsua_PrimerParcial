namespace NotSpotify.InterfazGrafica
{
    partial class FrmAdmin
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
            pnl_adminTopBar = new Panel();
            pnl_adminFormChanger = new Panel();
            SuspendLayout();
            // 
            // pnl_adminTopBar
            // 
            pnl_adminTopBar.BackColor = Color.FromArgb(255, 224, 192);
            pnl_adminTopBar.Dock = DockStyle.Top;
            pnl_adminTopBar.Location = new Point(0, 0);
            pnl_adminTopBar.Name = "pnl_adminTopBar";
            pnl_adminTopBar.Size = new Size(800, 63);
            pnl_adminTopBar.TabIndex = 0;
            // 
            // pnl_adminFormChanger
            // 
            pnl_adminFormChanger.BackColor = Color.FromArgb(255, 192, 128);
            pnl_adminFormChanger.Dock = DockStyle.Fill;
            pnl_adminFormChanger.Location = new Point(0, 63);
            pnl_adminFormChanger.Name = "pnl_adminFormChanger";
            pnl_adminFormChanger.Size = new Size(800, 387);
            pnl_adminFormChanger.TabIndex = 1;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pnl_adminFormChanger);
            Controls.Add(pnl_adminTopBar);
            Name = "FrmAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_adminTopBar;
        private Panel pnl_adminFormChanger;
    }
}