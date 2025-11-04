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
    public partial class visualizar_estado_reporte : Form
    {
        public string usuarioactual;
        public visualizar_estado_reporte(string usuario)
        {
            InitializeComponent();
            usuarioactual = usuario;
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            dgv_estado_reporte.Rows.Clear();
            string mostrar_estado;
            int i = 0;

            Nodo actual = Program.ColaReportesGLOBAL.Inicio;
            while (actual != null)
            {
                if (actual.dato.Usuario == usuarioactual)
                {
                    i++;
                    mostrar_estado = "EN ESPERA";
                    dgv_estado_reporte.Rows.Add(i, actual.dato.Usuario, actual.dato.Tipo, actual.dato.Descripcion, actual.dato.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"), mostrar_estado);
                }
                actual = actual.siguiente;
            }
            Nodo este = Program.ListaReportesGlobal.Inicio;
            while (este != null)
            {
                if (este.dato.Usuario == usuarioactual)
                {
                    i++;
                    mostrar_estado = "EN PROCESO";
                    dgv_estado_reporte.Rows.Add(i, este.dato.Usuario, este.dato.Tipo, este.dato.Descripcion, este.dato.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"), mostrar_estado);
                }
                este = este.siguiente;
            }
            Nodo yo = Program.PilaReportesGlobal.Inicio;
            while (yo != null)
            {
                if (yo.dato.Usuario == usuarioactual)
                {
                    i++;
                    mostrar_estado = "SOLUCIONADO";
                    dgv_estado_reporte.Rows.Add(i, yo.dato.Usuario, yo.dato.Tipo, yo.dato.Descripcion, yo.dato.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"), mostrar_estado);
                }
                yo = yo.siguiente;
            }
        }

        private void btnvolver2_Click(object sender, EventArgs e)
        {
            inicio_usuario usuario = new inicio_usuario(usuarioactual);
            usuario.Show();
            this.Close();
        }
    }
}
