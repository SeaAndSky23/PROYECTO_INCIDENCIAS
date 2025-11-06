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
    public partial class v_insidencias_proceso : Form
    {
        private void MostrarDataLista(Nodo inicio, DataGridView dgv)
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
                int riesgo = actual.dato.riesgo;
                string mostrar_riesgo = "DESCONOCIDO";
                switch (riesgo)
                {
                    case 1:
                        mostrar_riesgo = "URGENTE"; break;
                    case 2:
                        mostrar_riesgo = "MEDIO"; break;
                    case 3:
                        mostrar_riesgo = "BAJO"; break;
                    case 4:
                        mostrar_riesgo = "NO ESPECIFICADO"; break;

                }
                dgv.Rows.Add(i, usario, tipo, descripcion, ubicacion, fecha.ToString("dd/MM/yyyy HH:mm:ss"), mostrar_riesgo);
                actual = actual.siguiente;
                i++;
            }
        }
        public v_insidencias_proceso()
        {
            InitializeComponent();
        }

        //ACTUALIZAR LISTA
        private void aCTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_ListaAtendiendose.Refresh();
            MostrarDataLista(Program.ListaReportesGlobal.Inicio, dgv_ListaAtendiendose);
        }

        //FINALIZAR CASO
        private void fINALIZARCASOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_ListaAtendiendose.CurrentRow == null)
            {
                MessageBox.Show("Porfavor selecciona una reporte");
                return;
            }
            int filaseleccionada = dgv_ListaAtendiendose.CurrentRow.Index;
            Nodo actual = Program.ListaReportesGlobal.Inicio;
            int i = 0;
            while (actual != null && i != filaseleccionada)
            {
                actual = actual.siguiente;
                i++;
            }
            if (actual == null)
            {
                return;
            }
            RegistroProblema seleccionado = actual.dato;
            if (MessageBox.Show("¿Estas seguro de dar por finalizado el reporte?", "ATENCIÓN",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.ListaReportesGlobal.EliminarReporteFINALIZADO(seleccionado);
                Program.PilaReportesGlobal.Apilar(seleccionado);
                MessageBox.Show("Reporte correctamente finalizado");
                MostrarDataLista(Program.ListaReportesGlobal.Inicio, dgv_ListaAtendiendose);
            }
            else
            {
                MessageBox.Show("Porfavor asegurate de su conclusión");
            }
        }
        //ELIMINAR CASO
        private void eLIMINARCASOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_ListaAtendiendose.CurrentRow == null)
            {
                MessageBox.Show("Porfavor selecciona una reporte");
                return;
            }
            int filaseleccionada = dgv_ListaAtendiendose.CurrentRow.Index;
            Nodo actual = Program.ListaReportesGlobal.Inicio;
            int i = 0;
            while (actual != null && i != filaseleccionada)
            {
                actual = actual.siguiente;
                i++;
            }
            if (actual == null)
            {
                return;
            }
            RegistroProblema seleccionado_elimiar = actual.dato;
            if (MessageBox.Show("¿Estas seguro de eliminar el reporte?", "ATENCIÓN",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.ListaReportesGlobal.EliminarReporteFINALIZADO(seleccionado_elimiar);
                Program.Lista___Eliminados_Global.AgregarReporteAtendidos(seleccionado_elimiar);
                MessageBox.Show("Reporte correctamente eliminado");
                MostrarDataLista(Program.ListaReportesGlobal.Inicio, dgv_ListaAtendiendose);
            }
            else
            {
                MessageBox.Show("Porfavor haz seguimiento al reporte");
            }
        }

        //REGRESAR AL INICIO
        private void vOLVERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio_autoridad autoridadinicio = new inicio_autoridad();
            autoridadinicio.Show();
            this.Hide();
        }

        //IMPRIMIR REPORTES DEL DIA
        private void rEPORTESDELDIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.PilaReportesGlobal.Inicio == null)
            {
                MessageBox.Show("No hay reportes finalizados.");
            }
            else
            {
                // Obtener la ruta base del proyecto (carpeta bin/Debug o bin/Release)
                string rutaBase = Application.StartupPath;

                // Crear la carpeta "ReportesFinalizados" dentro del proyecto si no existe
                string carpetaReportes = Path.Combine(rutaBase, "ReportesFinalizados");
                if (!Directory.Exists(carpetaReportes))
                {
                    Directory.CreateDirectory(carpetaReportes);
                }

                // Generar el nombre del archivo con la fecha y hora
                string nombreArchivo = "ReportesFinalizados_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".txt";
                string rutaArchivo = Path.Combine(carpetaReportes, nombreArchivo);

                // CREAR Y ESCRIBIR EL ARCHIVO
                using (TextWriter FINALIZADOS = new StreamWriter(rutaArchivo, true))
                {
                    FINALIZADOS.WriteLine("******************** REPORTES FINALIZADOS *******************");
                    FINALIZADOS.WriteLine("Fecha: " + DateTime.Now);
                    FINALIZADOS.WriteLine();

                    Nodo actual = Program.PilaReportesGlobal.Inicio;
                    int i = 0;

                    while (actual != null)
                    {
                        FINALIZADOS.WriteLine("Usuario: " + actual.dato.Usuario);
                        FINALIZADOS.WriteLine("Tipo de problema: " + actual.dato.Tipo);
                        FINALIZADOS.WriteLine("Descripción del problema: " + actual.dato.Descripcion);
                        FINALIZADOS.WriteLine("Ubicación del problema: " + actual.dato.Ubicacion);
                        FINALIZADOS.WriteLine("Enviado: " + actual.dato.FechaHora);
                        FINALIZADOS.WriteLine("----------------------------------------------------");
                        actual = actual.siguiente;
                        i++;
                    }

                    FINALIZADOS.WriteLine("Número total de reportes finalizados con éxito: " + i);
                }

                MessageBox.Show("Reporte generado correctamente en la carpeta 'ReportesFinalizados'.");
                Program.PilaReportesGlobal = new PilaReportes();
            }
        }

        //IMPRIMIR REPORTES ELIMINADOS
        private void eLIMINADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Lista___Eliminados_Global.Inicio == null)
            {
                MessageBox.Show("No hay reportes eliminados.");
            }
            else
            {
                // Obtener la ruta base del proyecto (bin/Debug o bin/Release)
                string rutaBase = Application.StartupPath;

                // Crear la carpeta "ReportesEliminados" dentro del proyecto si no existe
                string carpetaReportes = Path.Combine(rutaBase, "ReportesEliminados");
                if (!Directory.Exists(carpetaReportes))
                {
                    Directory.CreateDirectory(carpetaReportes);
                }

                // Generar el nombre del archivo con la fecha y hora
                string nombreArchivo = "ReportesEliminados_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".txt";
                string rutaArchivo = Path.Combine(carpetaReportes, nombreArchivo);

                // CREAR Y ESCRIBIR EL ARCHIVO
                using (TextWriter FINALIZADOS_ELIMINADOS = new StreamWriter(rutaArchivo, true))
                {
                    FINALIZADOS_ELIMINADOS.WriteLine("******************** REPORTES ELIMINADOS *******************");
                    FINALIZADOS_ELIMINADOS.WriteLine("Fecha: " + DateTime.Now);
                    FINALIZADOS_ELIMINADOS.WriteLine();

                    Nodo actual = Program.Lista___Eliminados_Global.Inicio;
                    int i = 0;

                    while (actual != null)
                    {
                        FINALIZADOS_ELIMINADOS.WriteLine("Usuario: " + actual.dato.Usuario);
                        FINALIZADOS_ELIMINADOS.WriteLine("Tipo de problema: " + actual.dato.Tipo);
                        FINALIZADOS_ELIMINADOS.WriteLine("Descripción del problema: " + actual.dato.Descripcion);
                        FINALIZADOS_ELIMINADOS.WriteLine("Ubicación del problema: " + actual.dato.Ubicacion);
                        FINALIZADOS_ELIMINADOS.WriteLine("Enviado: " + actual.dato.FechaHora);
                        FINALIZADOS_ELIMINADOS.WriteLine("----------------------------------------------------");
                        actual = actual.siguiente;
                        i++;
                    }

                    FINALIZADOS_ELIMINADOS.WriteLine("Número total de reportes eliminados: " + i);
                }

                MessageBox.Show("Los reportes eliminados se guardaron correctamente en la carpeta 'ReportesEliminados'.");
                Program.Lista___Eliminados_Global = new ListaEnlazadaReportesAtendidos();
            }
        }
        public int Contador_todos()
        {
            int i = 0;
            Nodo actual = Program.PilaReportesGlobal.Inicio;
            while (actual != null)
            {
                i++;
                actual = actual.siguiente;
            }
            return i;
        }
        public int Contador_Segun(int tipo)
        {
            int i = 0;
            Nodo Actual = Program.PilaReportesGlobal.Inicio;
            while (Actual != null)
            {
                if (Actual.dato.riesgo == tipo)
                {
                    i++;
                }
                Actual = Actual.siguiente;
            }
            return i;
        }
        public int contador_eliminados()
        {
            int i = 0;
            Nodo actual = Program.Lista___Eliminados_Global.Inicio;
            while (actual != null)
            {
                i++;
                actual = actual.siguiente;
            }
            return i;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblcontador_final.Text = Contador_todos().ToString();
            lblcontador_urgente.Text = Contador_Segun(1).ToString();
            lblcontador_medio.Text = Contador_Segun(2).ToString();
            lblcontador_bajo.Text = Contador_Segun(3).ToString();
            lblcontador_noespec.Text = Contador_Segun(4).ToString();
            lblcontador_elininados.Text = contador_eliminados().ToString();
        }

        private void v_insidencias_proceso_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}