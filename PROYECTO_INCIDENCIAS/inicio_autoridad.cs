using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INCIDENCIAS
{
    public partial class inicio_autoridad : Form
    {
        public inicio_autoridad()
        {
            InitializeComponent();
        }

        //COLUMNA RIESGO
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
                int riesgo = actual.dato.riesgo;
                string mostrar_riesgo = "DESCONOCIDO";

                switch (riesgo)
                {
                    case 1: mostrar_riesgo = "URGENTE"; break;
                    case 2: mostrar_riesgo = "MEDIO"; break;
                    case 3: mostrar_riesgo = "BAJO"; break;
                    case 4: mostrar_riesgo = "A EVALUACIÓN"; break;
                }

                dgv.Rows.Add(i, usuario, tipo, descripcion, ubicacion, fecha.ToString("dd/MM/yyyy HH:mm:ss"), mostrar_riesgo);
                actual = actual.siguiente;
                i++;
            }
        }
            
        private int Contadores(int riesgo)
        {
            Nodo actual = Program.ColaReportesGLOBAL.Inicio;
            int i = 0;
            while (actual != null)
            {
                if (actual.dato.riesgo == riesgo)
                {
                    i++;
                }
                actual = actual.siguiente;
            }
            return i;
        }
        private void actualizarcontadores()
        {
            label5.Text = Contadores(1).ToString();
            label6.Text = Contadores(2).ToString();
            label7.Text = Contadores(3).ToString();
            label8.Text = Contadores(4).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int contador = 0;
            Nodo actual = Program.ColaReportesGLOBAL.Inicio;
            while (actual != null)
            {
                contador++;
                actual = actual.siguiente;
            }
            label4.Text = contador.ToString();
            actualizarcontadores();
        }

        //ADMINISTRAR USUARIOS
        private void btadmuser_Click(object sender, EventArgs e)
        {
            FrmClaveAdmin clave = new FrmClaveAdmin();
            clave.Show();
            this.Hide();
        }

        private void dgvvisualincidencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //METODO MOSTRAR
        private void Mostrar(int e, Nodo actual, DataGridView dgv)
        {
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
                    mostrar_riesgo = "A EVALUACIÓN"; break;

            }
            dgv.Rows.Add(e, actual.dato.Usuario, actual.dato.Tipo, actual.dato.Descripcion, actual.dato.Ubicacion, actual.dato.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"), mostrar_riesgo);
        }

        //REGRESAR AL INICIO
        private void vOLVERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        //VER REPORTES EN PROCESO
        private void vERREPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_insidencias_proceso proceso = new v_insidencias_proceso();
            proceso.Show();
            this.Hide();
        }

        //ATENDER REPORTE
        private void aTENDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvvisualincidencias.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un reporte para atender");
                return;
            }
            if (MessageBox.Show("¿Tienes los recursos para antender ese problema?", "ATENCIÓN",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string usuario = dgvvisualincidencias.CurrentRow.Cells[1].Value.ToString();
                string tipo = dgvvisualincidencias.CurrentRow.Cells[2].Value.ToString();
                string descripcion = dgvvisualincidencias.CurrentRow.Cells[3].Value.ToString();
                string ubicacion = dgvvisualincidencias.CurrentRow.Cells[4].Value.ToString();
                string fecha = dgvvisualincidencias.CurrentRow.Cells[5].Value.ToString();
                string riesgo = dgvvisualincidencias.CurrentRow.Cells[6].Value.ToString();
                int riesgo_mostrar = 0;
                switch (riesgo.ToLower())
                {
                    case "urgente": riesgo_mostrar = 1; break;
                    case "medio": riesgo_mostrar = 2; break;
                    case "bajo": riesgo_mostrar = 3; break;
                    case "a evaluación": riesgo_mostrar = 4; break;

                }
                RegistroProblema atendido = Program.ColaReportesGLOBAL.EliminarPorDatos(usuario, tipo, descripcion, ubicacion, fecha, riesgo_mostrar);
                if (atendido != null)
                {
                    MessageBox.Show("Registro correctamente procesado, no olvidar comunicar a la comisaría respectiva");
                    Program.ListaReportesGlobal.AgregarReporteAtendidos(atendido);
                    MostrarDataCola(Program.ColaReportesGLOBAL.Inicio, dgvvisualincidencias);
                }
                else
                {
                    MessageBox.Show("Reporte no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Porfavor atiende el problema lo más pronto posible");
            }
        }

        //ORDENAR POR PRIORIDAD
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvvisualincidencias.Rows.Clear();
            int i = 1;
            // Recorremos 4 veces, una por cada prioridad
            for (int nivel = 1; nivel <= 4; nivel++)
            {
                Nodo actual = Program.ColaReportesGLOBAL.Inicio;
                while (actual != null)
                {
                    if (actual.dato.riesgo == nivel)
                    {
                        Mostrar(i, actual, dgvvisualincidencias);
                        i++;
                    }
                    actual = actual.siguiente;
                }
            }
        }

        //VER REPORTES EN ORDEN DE LLEGADA
        private void eNORDENDELLEGADAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarDataCola(Program.ColaReportesGLOBAL.Inicio, dgvvisualincidencias);
        }

        //VER SOLO REPORTES URGENTES
        private void sOLOURGENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvvisualincidencias.Rows.Clear();
            Nodo actual = Program.ColaReportesGLOBAL.Inicio;
            int i = 1;
            while (actual != null)
            {
                if (actual.dato.riesgo == 1)
                {
                    Mostrar(i, actual, dgvvisualincidencias);
                    i++;
                }
                actual = actual.siguiente;
            }
        }

        //VER SOLO REPORTES MEDIOS
        private void sOLOMEDIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvvisualincidencias.Rows.Clear();
            Nodo actual = Program.ColaReportesGLOBAL.Inicio;
            int i = 1;
            while (actual != null)
            {
                if (actual.dato.riesgo == 2)
                {
                    Mostrar(i, actual, dgvvisualincidencias);
                    i++;
                }
                actual = actual.siguiente;
            }
        }

        //VER SOLO REPORTES BAJOS
        private void sOLOBAJOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvvisualincidencias.Rows.Clear();
            Nodo actual = Program.ColaReportesGLOBAL.Inicio;
            int i = 1;
            while (actual != null)
            {
                if (actual.dato.riesgo == 3)
                {
                    Mostrar(i, actual, dgvvisualincidencias);
                    i++;
                }
                actual = actual.siguiente;
            }
        }

        //VER SOLO REPORTES NO ESPECIFICADOS
        private void sOLODESCONOCIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvvisualincidencias.Rows.Clear();
            Nodo actual = Program.ColaReportesGLOBAL.Inicio;
            int i = 1;
            while (actual != null)
            {
                if (actual.dato.riesgo == 4)
                {
                    Mostrar(i, actual, dgvvisualincidencias);
                    i++;
                }
                actual = actual.siguiente;
            }
        }

        private void inicio_autoridad_Load(object sender, EventArgs e)
        {
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";

            timer1.Enabled = true;  
            timer1.Interval = 1000; 
        }
    }
}
