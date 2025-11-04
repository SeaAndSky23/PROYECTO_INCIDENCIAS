using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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

        string[] consejos = {
    "Mantén la calma ante cualquier situación de peligro",
    "Llama inmediatamente al 105 si observas un delito",
    "Evita confrontar a los sospechosos, busca zonas seguras",
    "Usa grupos vecinales o redes sociales para alertas",
    "Si ocurre un accidente, no interfieras en la escena",
    "Reporta cualquier actividad sospechosa mediante este sistema"
};

        int index = 0;

        private async void inicio_usuario_Load(object sender, EventArgs e)
        {
            string post1 = @"<iframe src='https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2FmunitruGMCRR%2Fposts%2Fpfbid02C2eW84W3ov352j8D8KYg16kVBDmrzzXmdHReHX96iUMH6hL3G6vmnWxoL9vr1zk4l&show_text=true&width=500' width='210' height='210' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";
            string post2 = @"<iframe src='https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2FmunitruGMCRR%2Fposts%2Fpfbid0vVzShRZbhpsWTwWtnbsXypSDZxiFtXSzCrGboxDAxygWEmNwLKsA4ts8pWhzQDQ6l&show_text=true&width=500' width='210' height='210' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";
            string post3 = @"<iframe src='https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2FmunitruGMCRR%2Fposts%2Fpfbid0o5NmjYHLyzXyaKTeXS9DYin236mLMNxXoFGB4muz4yzZhnfS3BrDUYMVHGQibgRil&show_text=true&width=500' width='210' height='210' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";
            string video = @"<iframe src='https://www.facebook.com/plugins/video.php?height=476&href=https%3A%2F%2Fwww.facebook.com%2Freel%2F1171150814980486%2F&show_text=false&width=267&t=0' width='210' height='210' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";

            await webView21.EnsureCoreWebView2Async(null);
            webView21.NavigateToString(post1);

            await webView22.EnsureCoreWebView2Async(null);
            webView22.NavigateToString(post2);

            await webView23.EnsureCoreWebView2Async(null);
            webView23.NavigateToString(post3);

            await webView24.EnsureCoreWebView2Async(null);
            webView24.NavigateToString(video);

            labelConsejo.Text = consejos[index];
            labelConsejo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelConsejo.ForeColor = Color.Black;
            labelConsejo.BackColor = Color.White;

            timer1.Start();
        }

        private void btnregistroincidencia_Click_1(object sender, EventArgs e)
        {
            registro_incidencia incidencia = new registro_incidencia(usuarioActual);
            incidencia.Show();
            this.Hide();
        }

        private void btnvisestado_Click(object sender, EventArgs e)
        {
            visualizar_estado_reporte visualizar_Estado_ = new visualizar_estado_reporte(usuarioActual);
            visualizar_Estado_.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % consejos.Length; // Cambia al siguiente
            labelConsejo.Text = consejos[index];
        }

        private void btncerrarses_Click(object sender, EventArgs e)
        {
            Form1 INICIO = new Form1();
            INICIO.Show();
            this.Hide();
        }

        private void btnestadis_Click(object sender, EventArgs e)
        {
            frmEstadisticas estadisticas = new frmEstadisticas();
            estadisticas.Show();
            this.Hide();
        }
    }
}

