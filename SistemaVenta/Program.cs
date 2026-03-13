using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CapaPresentacion;

namespace SistemaVenta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
             Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());


            //cuando ya existe una instancia se ejecuta la línea de abajo:
            //Application.Run(FrmVenta.GetInstancia());
        }
    }
}
