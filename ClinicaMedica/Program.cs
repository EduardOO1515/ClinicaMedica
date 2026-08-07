using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//fly
namespace ClinicaMedica
{
    internal static class Program
    {
        // Punto de entrada de la aplicacion.
        // frmPrincipal se crea primero y muestra frmLogin antes de hacerse visible.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
