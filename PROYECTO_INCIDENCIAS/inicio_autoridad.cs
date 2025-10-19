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
    public partial class inicio_autoridad : Form
    {
        private void MostrarDataCola(Nodo inicio, DataGridView dgv)
        {

            dgv.Rows.Clear();
            int i = 1;
            Nodo actual = inicio;
            while (actual != null)
            {
                string usuario = actual.dato.Usuario;
                string tipo = actual.dato.Tipo;
                string descripcion = actual.dato.Descripcion;
                string ubicacion = actual.dato.Ubicacion;
                DateTime fecha = actual.dato.FechaHora;
                dgv.Rows.Add(i, usuario, tipo, descripcion, ubicacion, fecha.ToString("dd/MM/yyyy HH:mm:ss"));
                actual = actual.siguiente;
                i++;
            }
        }

        public inicio_autoridad()
        {
            InitializeComponent();
        }

        private void inicio_autoridad_Load(object sender, EventArgs e)
        {
            
        }

        private void btadmuser_Click(object sender, EventArgs e)
        {
            FrmClaveAdmin clave = new FrmClaveAdmin();
            clave.Show();
            this.Hide();
        }

        private void tsactualizar_Click(object sender, EventArgs e)
        {
            MostrarDataCola(Program.ColaReportesGLOBAL.Inicio, dgvvisualincidencias);
        }

        private void tsatender_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Tienes los recursos para antender ese problema?", "ATENCIÓN",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RegistroProblema problemasAtendidos = Program.ColaReportesGLOBAL.Desencolar();
                if (problemasAtendidos != null)
                {
                    MessageBox.Show("Registro correctamente procesado, no olvidar comunicar a la comisaría respectiva");
                    Program.ListaReportesGlobal.AgregarReporteAtendidos(problemasAtendidos);
                    MostrarDataCola(Program.ColaReportesGLOBAL.Inicio, dgvvisualincidencias);
                }
                else
                {
                    MessageBox.Show("Ya no hay mas reportes por procesar");
                }
            }
            else
            {
                MessageBox.Show("Porfavor atiende el problema lo más pronto posible");
            }
        }

        private void tssalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsvolver_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void btnreporproces_Click(object sender, EventArgs e)
        {
            v_insidencias_proceso proceso = new v_insidencias_proceso();
            proceso.Show();
            this.Hide();
        }

        private void dgvvisualincidencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
