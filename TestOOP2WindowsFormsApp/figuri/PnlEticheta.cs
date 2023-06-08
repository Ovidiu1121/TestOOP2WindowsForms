using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOP2WindowsFormsApp.figuri
{
    public class PnlEticheta : Panel, IFigura
    {

        public PnlEticheta()
        {
            this.Size = new System.Drawing.Size(145, 70);
        }

        public void grafica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.Blue, 5);

            g.DrawRectangle(pen, 0, 0, this.Width, this.Height);

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
            panel.Size=new Size(145, 70);
            panel.BorderStyle=BorderStyle.FixedSingle;
        }
    }
}
