using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace PROYECTO_INCIDENCIAS
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void btnvolver4_Click(object sender, EventArgs e)
        {
            inicio_usuario usuarioinicio = new inicio_usuario("");
            usuarioinicio.Show();
            this.Close();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            // Carpeta donde están los archivos
            string carpetaReportes = Path.Combine(Application.StartupPath, "ReportesFinalizados");

            if (!Directory.Exists(carpetaReportes))
            {
                MessageBox.Show("No se encontró la carpeta 'Reportes'.");
                return;
            }

            List<string> ubicaciones = new List<string>();
            string[] archivos = Directory.GetFiles(carpetaReportes, "*.txt");

            foreach (string archivo in archivos)
            {
                foreach (string linea in File.ReadAllLines(archivo))
                {
                    if (linea.StartsWith("Ubicación del problema:", StringComparison.OrdinalIgnoreCase))
                    {
                        // Extraer texto después de los dos puntos
                        string ubicacionCompleta = linea.Replace("Ubicación del problema:", "").Trim();

                        // Si hay una coma, tomar solo lo primero antes de la coma
                        string ubicacion = ubicacionCompleta.Split(',')[0].Trim();

                        if (!string.IsNullOrWhiteSpace(ubicacion))
                            ubicaciones.Add(ubicacion);
                    }
                }
            }

            if (ubicaciones.Count == 0)
            {
                MessageBox.Show("No se encontraron ubicaciones en los archivos.");
                return;
            }

            // Agrupar y contar ubicaciones
            var conteo = ubicaciones
                .GroupBy(u => u)
                .ToDictionary(g => g.Key, g => g.Count());

            // Configurar gráfico
            chartIncidencias.Series.Clear();
            chartIncidencias.Titles.Clear();

            Series serie = new Series("Ubicaciones")
            {
                ChartType = SeriesChartType.Bar
            };

            foreach (var item in conteo)
            {
                serie.Points.AddXY(item.Key, item.Value);
            }

            chartIncidencias.Series.Add(serie);
            chartIncidencias.ChartAreas[0].AxisX.Title = "Ubicación";
            chartIncidencias.ChartAreas[0].AxisY.Title = "Cantidad de Reportes";
            chartIncidencias.Titles.Add("CANTIDAD DE REPORTES FINALIZADOS POR UBICACIÓN");
        }
    }
}
