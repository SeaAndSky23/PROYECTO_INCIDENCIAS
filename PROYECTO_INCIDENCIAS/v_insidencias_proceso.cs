using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INCIDENCIAS
{
    public partial class v_insidencias_proceso : Form
    {
        string[] mensajes = new string[]
        {
               "Estate atento al estado del caso.",
              "Verifica los reportes pendientes.",
               "Mantén la comunicación con tu equipo.",
               "Finaliza los reportes cuando estén resueltos.",
               "Recuerda actualizar la lista de incidencias.",
               "Actúa con calma y precisión ante emergencias."
        };
        int indiceMensaje = 0;
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
                dgv.Rows.Add(i, usario, tipo, descripcion, ubicacion, fecha.ToString("dd/MM/yyyy HH:mm:ss"));
                actual = actual.siguiente;
                i++;
            }
        }
        public v_insidencias_proceso()
        {
            InitializeComponent();
        }

        private void tsactualizar_Click(object sender, EventArgs e)
        {
            dgvincidenciasproceso.Refresh();
            MostrarDataLista(Program.ListaReportesGlobal.Inicio, dgvincidenciasproceso);
        }

        private void tsvolver_Click(object sender, EventArgs e)
        {
            inicio_autoridad ver_incidencias = new inicio_autoridad();
            ver_incidencias.Show();
            this.Hide();
            MostrarDataLista(Program.ListaReportesGlobal.Inicio, dgvincidenciasproceso);
        }

        private void tssalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsfinalizarcaso_Click(object sender, EventArgs e)
        {
            if (dgvincidenciasproceso.CurrentRow == null)
            {
                MessageBox.Show("Porfavor selecciona una reporte");
            }
            int filaseleccionada = dgvincidenciasproceso.CurrentRow.Index;
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
                MostrarDataLista(Program.ListaReportesGlobal.Inicio, dgvincidenciasproceso);
            }
            else
            {
                MessageBox.Show("Porfavor asegurate de su conclusión");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMensajes.Text = mensajes[indiceMensaje];
            indiceMensaje++;
            if (indiceMensaje >= mensajes.Length)
            {
                indiceMensaje = 0;
            }
        }

        private void btnvisreportfinal_Click(object sender, EventArgs e)
        {
            Inicidencias_finalizadas finalizadas = new Inicidencias_finalizadas();
            finalizadas.Show();
            this.Hide();
        }
    }
}