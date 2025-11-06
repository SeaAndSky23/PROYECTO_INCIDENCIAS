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
            DateTime fechaHora = DateTime.Now;
            RegistroProblema registroproblema = new RegistroProblema(usuario, tipo, descripcion, ubicacion, fechaHora);
            registroproblema.Estado_Reporte = false;
            Program.ColaReportesGLOBAL.Encolar(registroproblema);
            MessageBox.Show("Reporte enviado correctamente");
            cb_TipoIncidencia.SelectedIndex = -1;
            tb_DescripcionProblema.Clear();       
            cbdistrito.SelectedIndex = -1;       
            tb_Ubicacion.Clear();
        }

        private void btnvolver_Click_1(object sender, EventArgs e)
        {
            inicio_usuario usuario = new inicio_usuario(usuarioActual);
            usuario.Show();
            this.Close();
        }
    }
}
