using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciones
{
    class program
    {
        [STAThread]
        public static void Main()
        {
            frmPrincipal main = new frmPrincipal();
            main.Show();
            Application.Run();
        }
    }
}
