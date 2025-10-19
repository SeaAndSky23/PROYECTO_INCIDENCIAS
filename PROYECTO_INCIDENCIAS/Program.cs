using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INCIDENCIAS
{
    internal static class Program
    {
        public static ColaReportes ColaReportesGLOBAL = new ColaReportes();
        public static ListaEnlazadaReportesAtendidos ListaReportesGlobal = new ListaEnlazadaReportesAtendidos();
        public static PilaReportes PilaReportesGlobal = new PilaReportes();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
