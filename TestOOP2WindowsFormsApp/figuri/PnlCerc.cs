using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOP2WindowsFormsApp.figuri
{
    public class PnlCerc : Panel, IFigura
    {
        public PnlCerc()
        {
            this.Size = new System.Drawing.Size(128, 134);
        }

        public void grafica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.Red);

            g.DrawArc(pen, 0, 0, this.Width-50, this.Height-50, 400, 400) ;

        }

        public void afisare()
        {
            this.Paint+=new PaintEventHandler(grafica_Paint);
        }

        public Panel duplicare()
        {
            return this;
        }

        public void translatare(int x, int y)
        {
            this.Location = new Point(this.Location.X+x, this.Location.Y+y);
        }

        public void duplicare(Panel panel)
        {
            panel.Location=new Point(this.Location.X+500, this.Location.Y);
            panel.Paint+=new PaintEventHandler(grafica_Paint);
            panel.Size=new Size(128, 134);
            panel.BorderStyle=BorderStyle.FixedSingle;
        }
    }
}
