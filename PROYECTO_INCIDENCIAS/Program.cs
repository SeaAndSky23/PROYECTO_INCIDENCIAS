using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROYECTO_INCIDENCIAS.ColaReportes;

namespace PROYECTO_INCIDENCIAS
{
    internal static class Program
    {
        // Instancias globales accesibles en toda la aplicación
        public static ColaReportes ColaReportesGLOBAL = new ColaReportes();

        // Como las clases están anidadas dentro de ColaReportes,
        // debes anteponer "ColaReportes."
        public static ColaReportes.ListaEnlazadaReportesAtendidos ListaReportesGlobal = new ColaReportes.ListaEnlazadaReportesAtendidos();
        public static ListaEnlazadaReportesAtendidos Lista___Eliminados_Global = new ListaEnlazadaReportesAtendidos();
        public static ColaReportes.PilaReportes PilaReportesGlobal = new ColaReportes.PilaReportes();

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
