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
            if (Program.PilaReportesGlobal.Inicio == null)
            {
                MessageBox.Show("No hay reportes finalizados.");
            }
            else
            {
                // Crear carpeta dentro del proyecto si no existe
                string carpetaReportes = Path.Combine(Application.StartupPath, "Reportes");
                if (!Directory.Exists(carpetaReportes))
                {
                    Directory.CreateDirectory(carpetaReportes);
                }

                // Crear archivo con fecha y hora
                string nombreArchivo = $"ReportesFinalizados_{DateTime.Now:yyyy-MM-dd-HH-mm}.txt";
                string rutaArchivo = Path.Combine(carpetaReportes, nombreArchivo);

                using (TextWriter FINALIZADOS = new StreamWriter(rutaArchivo, true))
                {
                    FINALIZADOS.WriteLine("******************** REPORTES FINALIZADOS ********************");
                    FINALIZADOS.WriteLine("Fecha de exportación: " + DateTime.Now);
                    FINALIZADOS.WriteLine();

                    Nodo actual = Program.PilaReportesGlobal.Inicio;
                    int i = 0;
                    while (actual != null)
                    {
                        FINALIZADOS.WriteLine($"[{i + 1}]");
                        FINALIZADOS.WriteLine("Usuario: " + actual.dato.Usuario);
                        FINALIZADOS.WriteLine("Tipo de problema: " + actual.dato.Tipo);
                        FINALIZADOS.WriteLine("Descripción: " + actual.dato.Descripcion);
                        FINALIZADOS.WriteLine("Ubicación: " + actual.dato.Ubicacion);
                        FINALIZADOS.WriteLine("Fecha del reporte: " + actual.dato.FechaHora);
                        FINALIZADOS.WriteLine("------------------------------------------------------------");
                        FINALIZADOS.WriteLine();
                        actual = actual.siguiente;
                        i++;
                    }

                    FINALIZADOS.WriteLine("Número total de reportes finalizados con éxito: " + i);
                    FINALIZADOS.WriteLine("***************************************************************");
                }

                MessageBox.Show($"Archivo guardado en: {rutaArchivo}");
                dgvincifinalizadas.Rows.Clear();
            }
        }
    }
}
