using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOP2WindowsFormsApp
{
    public interface IFigura
    {

        void afisare();
        
        void translatare(int x, int y);

        void duplicare(Panel panel);

    }
}
