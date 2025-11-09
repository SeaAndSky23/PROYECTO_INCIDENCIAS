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
    public partial class registro_incidencia : Form
    {
        private string usuarioActual;
        public registro_incidencia(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void btnenviarep_Click(object sender, EventArgs e)
        {
            string usuario = usuarioActual;
            string tipo = cb_TipoIncidencia.Text;
            string descripcion = tb_DescripcionProblema.Text;
            string ubicacion = cbdistrito.Text + " , " + tb_Ubicacion.Text;
            string comentarios = tb_comentarios.Text;
            DateTime fechaHora = DateTime.Now;
            RegistroProblema registroproblema = new RegistroProblema(usuario, tipo, descripcion, ubicacion, fechaHora, comentarios);
            registroproblema.Estado_Reporte = false;
            Program.ColaReportesGLOBAL.Encolar(registroproblema);
            MessageBox.Show("Reporte enviado correctamente");
            cb_TipoIncidencia.SelectedIndex = -1;
            tb_DescripcionProblema.Clear();
            cbdistrito.SelectedIndex = -1;
            tb_Ubicacion.Clear();
            tb_comentarios.Clear();
        }
    }
}
