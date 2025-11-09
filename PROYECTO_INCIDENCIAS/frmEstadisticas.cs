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
        //clase nodo para almacenar las ubicaciones
        public class NodoUbicacion
        {
            public string Ubicacion;
            public NodoUbicacion Siguiente;
        }

        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void CargarGrafico()
        {
            //buscar la ruta de la carpeta ReportesFinalizados
            string carpetaReportes = Path.Combine(Application.StartupPath, "ReportesFinalizados");

            //comprobamos si la carpeta existe
            if (!Directory.Exists(carpetaReportes))
            {
                MessageBox.Show("No se encontró la carpeta 'Reportes'.");
                return;
            }
            //inicializa los punteros de la lista
            NodoUbicacion inicio = null;
            NodoUbicacion fin = null;

            //obtener todos los archivos de texto de la carpeta
            DirectoryInfo dir = new DirectoryInfo(carpetaReportes);
            FileInfo[] archivos = dir.GetFiles("*.txt");

            //rerorrer cada archivo linea por linea
            foreach (FileInfo archivo in archivos)
            {
                StreamReader lector = new StreamReader(archivo.FullName); //abre el archivo para leer el texto
                //se declara la variable linea para guardar cada linea leida
                string linea;
                while ((linea = lector.ReadLine()) != null)
                {
                    //verifica si la linea comienza exactamente con "Ubicación del problema:"
                    if (linea.StartsWith("Ubicación del problema:", StringComparison.OrdinalIgnoreCase))
                    {
                        //elimina la parte literal "Ubicación del problema:" y deja lo restante (la dirección).
                        string ubicacionCompleta = linea.Replace("Ubicación del problema:", "").Trim();

                        // Tomar solo lo primero antes de la coma
                        string ubicacion = ubicacionCompleta;
                        //busca la primera aparición de la coma dentro de la cadena ubicacionCompleta y se guarda en la variable coma
                        int coma = ubicacionCompleta.IndexOf(',');
                        //si el valor de coma es diferente a -1
                        if (coma != -1)
                            //se extrae una subcadena de ubicacionCompleta,Comienza en la posición 0(el inicio de la cadena) y continúa hasta la posición indicada por la variable coma(sin incluir la coma)
                            ubicacion = ubicacionCompleta.Substring(0, coma).Trim();

                        //verifica que la ubicación no esté vacía
                        if (!string.IsNullOrWhiteSpace(ubicacion))
                        {
                            //Se crea un nuevo nodo que contendrá la ubicación extraída
                            NodoUbicacion nuevo = new NodoUbicacion();
                            nuevo.Ubicacion = ubicacion;
                            nuevo.Siguiente = null;

                            if (inicio == null)
                            {
                                inicio = nuevo;
                                fin = nuevo;
                            }
                            else
                            {
                                fin.Siguiente = nuevo;
                                fin = nuevo;
                            }
                        }
                    }
                }
                lector.Close();
            }

            if (inicio == null)
            {
                MessageBox.Show("No se encontraron ubicaciones en los archivos.");
                return;
            }

            //aux1 recorre la lista principal; aux2 busca coincidencias desde el siguiente nodo; contador guarda cuántas veces se repite una ubicación
            NodoUbicacion aux1 = inicio;
            NodoUbicacion aux2;
            int contador;

            chartIncidencias.Series.Clear();
            chartIncidencias.Titles.Clear();

            //Crea una serie nueva llamada "Ubicaciones" del tipo Barra
            Series serie = new Series("Ubicaciones")
            {
                ChartType = SeriesChartType.Bar
            };

            //recorre la lista principal
            while (aux1 != null)
            {
                contador = 1;
                aux2 = aux1.Siguiente;
                NodoUbicacion anterior = aux1;

                //buscar duplicados
                //Compara las ubicaciones, Si son iguales: Incrementa el contador, se elimina el duplicado y avanza aux2 al siguiente nodo.
                while (aux2 != null)
                {
                    if (aux2.Ubicacion == aux1.Ubicacion)
                    {
                        contador++;
                        // Eliminar duplicado
                        anterior.Siguiente = aux2.Siguiente;
                        aux2 = aux2.Siguiente;
                        continue;
                    }
                    anterior = aux2;
                    aux2 = aux2.Siguiente;
                }
                //Cada vez que termina de contar una ubicación, agrega un punto en el gráfico
                serie.Points.AddXY(aux1.Ubicacion, contador);
                aux1 = aux1.Siguiente;
            }
            //configura el gráfico
            chartIncidencias.Series.Add(serie);
            chartIncidencias.ChartAreas[0].AxisX.Title = "Ubicación";
            chartIncidencias.ChartAreas[0].AxisY.Title = "Cantidad de Reportes";
            chartIncidencias.Titles.Add("CANTIDAD DE REPORTES FINALIZADOS POR UBICACIÓN");
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            CargarGrafico();
        }

        private void btnactu_Click(object sender, EventArgs e)
        {
            chartIncidencias.Series.Clear();
            chartIncidencias.Titles.Clear();
            CargarGrafico();
        }
    }
}
