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
            RegistroProblema registroProblema = new RegistroProblema();
            registroProblema.Usuario = usuarioActual;
            registroProblema.Tipo = cb_TipoIncidencia.Text;
            registroProblema.Descripcion = tb_DescripcionProblema.Text;
            registroProblema.Ubicacion = tb_Ubicacion.Text;
            registroProblema.FechaHora = DateTime.Now;
            MessageBox.Show("Reporte enviado correctamente");
            Program.ColaReportesGLOBAL.Encolar(registroProblema);
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            inicio_usuario usuario = new inicio_usuario(usuarioActual);
            usuario.Show();
            this.Close();
        }
    }
}
