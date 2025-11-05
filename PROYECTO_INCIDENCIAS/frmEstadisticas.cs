using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
