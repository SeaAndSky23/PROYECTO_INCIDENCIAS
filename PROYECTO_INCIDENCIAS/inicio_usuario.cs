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
    public partial class inicio_usuario : Form
    {
        private string usuarioActual;
        public inicio_usuario(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            lblbienvenido.Text = "Bienvenido, " + usuarioActual;
        }

        private void btnregistroincidencia_Click(object sender, EventArgs e)
        {
            registro_incidencia incidencia = new registro_incidencia(usuarioActual);
            incidencia.Show();
            this.Hide();
        }

        private void btncerrarses_Click(object sender, EventArgs e)
        {
            Form1 INICIO = new Form1();
            INICIO.Show();
            this.Hide();
        }
    }
}
