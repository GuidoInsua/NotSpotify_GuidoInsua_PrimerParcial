using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.InterfazGrafica
{
    static public class movimientoForms
    {
        static public bool isDragging = false;
        static public Point startPoint = new Point(0, 0);

        static public void MoverForm(Form unForm, EventArgs mouseDown, EventArgs mouseUp, EventArgs mouseMove)
        {
            if(mouseDown)
            {

            }
        }

        static public void pnl_topBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        static public void pnl_topBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        static public void pnl_topBar_MouseMove(object sender, MouseEventArgs e,object FrmLogin,Form unForm,EventArgs unevento)
        {
            if (isDragging)
            {
                Point p = unForm.PointToScreen(e.Location);
                //unForm.Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }
}
