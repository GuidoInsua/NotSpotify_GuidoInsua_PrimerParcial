namespace NotSpotify.InterfazGrafica
{
    partial class PanelMovimiento
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnl_movimiento = new Panel();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pnl_movimiento
            // 
            pnl_movimiento.Dock = DockStyle.Fill;
            pnl_movimiento.Location = new Point(0, 0);
            pnl_movimiento.Name = "pnl_movimiento";
            pnl_movimiento.Size = new Size(150, 150);
            pnl_movimiento.TabIndex = 0;
            pnl_movimiento.Paint += pnl_movimiento_Paint;
            pnl_movimiento.MouseDown += pnl_movimiento_MouseDown;
            pnl_movimiento.MouseMove += pnl_movimiento_MouseMove;
            pnl_movimiento.MouseUp += pnl_movimiento_MouseUp;
            // 
            // PanelMovimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_movimiento);
            Name = "PanelMovimiento";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_movimiento;
        private BindingSource bindingSource1;
    }
}
