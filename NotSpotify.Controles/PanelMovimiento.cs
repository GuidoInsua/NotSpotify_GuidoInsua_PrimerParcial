using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace NotSpotify.InterfazGrafica
{
    public partial class PanelMovimiento : UserControl
    {
        public bool isDragging = false;
        public Point startPoint = new(0, 0);
        public Form miForm = new();

        public PanelMovimiento()
        {
            InitializeComponent();
        }

        public void EstablecerPadre(Form unForm)
        {
            miForm = unForm;
        }

        private void pnl_movimiento_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnl_movimiento_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pnl_movimiento_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                miForm.Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }
}
