using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_INCIDENCIAS
{
    public partial class Vistarepfin : Form
    {
        public Vistarepfin()
        {
            InitializeComponent();
        }

        private void Vistarepfin_Load(object sender, EventArgs e)
        {
            vreportesfinal.ScrollBars = RichTextBoxScrollBars.Both;
            vreportesfinal.WordWrap = false; // opcional, si no quieres que el texto se corte

            // Ruta de la carpeta con los archivos txt
            string carpeta = Path.Combine(Application.StartupPath, "ReportesFinalizados");

            // Verifica que la carpeta exista
            if (!Directory.Exists(carpeta))
            {
                MessageBox.Show("La carpeta 'ReportesFinalizados' no existe.");
                return;
            }

            // Obtiene todos los archivos .txt
            string[] archivos = Directory.GetFiles(carpeta, "*.txt");

            // Limpia el RichTextBox antes de mostrar el contenido
            vreportesfinal.Clear();

            // Lee y muestra solo el contenido de los archivos
            foreach (string archivo in archivos)
            {
                string contenido = File.ReadAllText(archivo);
                vreportesfinal.AppendText(contenido + Environment.NewLine + Environment.NewLine);
            }
        }

    }
}
