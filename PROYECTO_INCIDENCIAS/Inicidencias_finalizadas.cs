using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROYECTO_INCIDENCIAS.ColaReportes;

namespace PROYECTO_INCIDENCIAS
{
    public partial class Inicidencias_finalizadas : Form
    {
        private void MostrarDataPila(Nodo inicio, DataGridView dgv)
        {
            dgv.Refresh();
            dgv.Rows.Clear();
            int i = 1;
            Nodo actual = inicio;
            while (actual != null)
            {
                string usario = actual.dato.Usuario;
                string tipo = actual.dato.Tipo;
                string descripcion = actual.dato.Descripcion;
                string ubicacion = actual.dato.Ubicacion;
                DateTime fecha = actual.dato.FechaHora;
                dgv.Rows.Add(i, usario, tipo, descripcion, ubicacion, fecha.ToString("dd/MM/yyyy HH:mm:ss"));
                actual = actual.siguiente;
                i++;
            }
        }
        public Inicidencias_finalizadas()
        {
            InitializeComponent();
        }

        private void tsactualizar_Click(object sender, EventArgs e)
        {
            dgvincifinalizadas.Refresh();
            MostrarDataPila(Program.PilaReportesGlobal.Inicio, dgvincifinalizadas);
        }

        private void tssalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsvolver_Click(object sender, EventArgs e)
        {
            v_insidencias_proceso en_proceso = new v_insidencias_proceso();
            en_proceso.Show();
            this.Hide();
            MostrarDataPila(Program.PilaReportesGlobal.Inicio, dgvincifinalizadas);
        }

        private void tsfinalizardia_Click(object sender, EventArgs e)
        {
            string carpetaReportes = Path.Combine(Application.StartupPath, "Reportes");
            if (!Directory.Exists(carpetaReportes))
            {
                Directory.CreateDirectory(carpetaReportes);
            }

            // Crear archivo con fecha y hora
            string nombreArchivo = $"ReporteDiario_{DateTime.Now:yyyy-MM-dd-HH-mm}.txt";
            string rutaArchivo = Path.Combine(carpetaReportes, nombreArchivo);

            using (TextWriter archivo = new StreamWriter(rutaArchivo, true))
            {
                archivo.WriteLine("******************** REPORTE DIARIO ********************");
                archivo.WriteLine("Fecha de exportación: " + DateTime.Now);
                archivo.WriteLine();

                // 1. Reportes finalizados
                archivo.WriteLine("---- REPORTES FINALIZADOS ----");
                Nodo actual = Program.PilaReportesGlobal.Inicio;
                int i = 0;
                while (actual != null)
                {
                    i++;
                    archivo.WriteLine($"[{i}] Usuario: {actual.dato.Usuario}");
                    archivo.WriteLine("Tipo: " + actual.dato.Tipo);
                    archivo.WriteLine("Descripción: " + actual.dato.Descripcion);
                    archivo.WriteLine("Ubicación: " + actual.dato.Ubicacion);
                    archivo.WriteLine("Fecha del reporte: " + actual.dato.FechaHora);
                    archivo.WriteLine("---------------------------------------------------");
                    actual = actual.siguiente;
                }
                archivo.WriteLine($"Total reportes finalizados: {i}");
                archivo.WriteLine();

                // 2. Reportes pendientes
                archivo.WriteLine("---- REPORTES PENDIENTES ----");
                actual = Program.ColaReportesGLOBAL.Inicio;
                int j = 0;
                while (actual != null)
                {
                    j++;
                    archivo.WriteLine($"[{j}] Usuario: {actual.dato.Usuario}");
                    archivo.WriteLine("Tipo: " + actual.dato.Tipo);
                    archivo.WriteLine("Descripción: " + actual.dato.Descripcion);
                    archivo.WriteLine("Ubicación: " + actual.dato.Ubicacion);
                    archivo.WriteLine("Fecha del reporte: " + actual.dato.FechaHora);
                    archivo.WriteLine("---------------------------------------------------");
                    actual = actual.siguiente;
                }
                archivo.WriteLine($"Total reportes pendientes: {j}");
                archivo.WriteLine("********************************************************");
            }

            MessageBox.Show($"Reporte diario guardado en: {rutaArchivo}");

            // Limpiar DataGridViews y estructuras para el siguiente día
            dgvincifinalizadas.Rows.Clear();
            Program.PilaReportesGlobal = new PilaReportes();  // Reinicia pila
            Program.ColaReportesGLOBAL = new ColaReportes();  // Reinicia cola
        }
    }
}
