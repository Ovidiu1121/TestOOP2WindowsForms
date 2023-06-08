using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestOOP2WindowsFormsApp.figuri;

namespace TestOOP2WindowsFormsApp
{
    public partial class FrmDesen : Form
    {
        List<IFigura> lista = new List<IFigura>();

        public FrmDesen()
        {
            InitializeComponent();

            PnlDreptunghi pnldreptunghi = new PnlDreptunghi();
            this.Controls.Add(pnldreptunghi);
            pnldreptunghi.Location=new Point(27, 160);
            pnldreptunghi.afisare();

            PnlEticheta pnleticheta=new PnlEticheta();
            this.Controls.Add(pnleticheta);
            pnleticheta.Location=new Point(56, 29);
            pnleticheta.afisare();

            PnlCerc pnlcerc=new PnlCerc();
            this.Controls.Add(pnlcerc);
            pnlcerc.Location=new Point(308, 143);
            pnlcerc.afisare();

            lista.Add(pnldreptunghi);
            lista.Add(pnleticheta);
            lista.Add(pnlcerc);
        }

        private void FrmDesen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (IFigura f in lista)
            {
                f.afisare();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(IFigura f in lista)
            {
                f.translatare(100,100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(IFigura figura in lista)
            {
                Panel panel=new Panel();
                figura.duplicare(panel);
                this.Controls.Add(panel);
            }
        }
    }
}
