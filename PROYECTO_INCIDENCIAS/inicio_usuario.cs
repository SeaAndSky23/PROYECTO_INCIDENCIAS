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
        #region FORMULARIO
        //Constructor
        public inicio_usuario()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion

        private string usuarioActual;
        public inicio_usuario(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            lblbienvenido.Text = "Bienvenido, " + usuarioActual;
            lblbienvenido.Font = new Font("Microsoft Sans Serif", 10);
        }

        string[] consejos = {
    "Envia tu reporte",
    "Visualiza en tiempo real el estado de tu reporte",
    "Revisa las estadisticas de incidencias",
    "Mantén la calma ante cualquier situación de peligro",
    "Llama inmediatamente al 105 si observas un delito",
    "Evita confrontar a los sospechosos",
    "busca zonas seguras si hay peligro cerca",
    "Usa grupos vecinales o redes sociales para alertas",
    "Si ocurre un accidente, no interfieras en la escena",
    "Reporta cualquier actividad sospechosa mediante este sistema"
};

        int index = 0;

        private async void inicio_usuario_Load(object sender, EventArgs e)
        {
            string post1 = @"<iframe src='https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2FmunitruGMCRR%2Fposts%2Fpfbid02C2eW84W3ov352j8D8KYg16kVBDmrzzXmdHReHX96iUMH6hL3G6vmnWxoL9vr1zk4l&show_text=true&width=500' width='229' height='262' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";
            string post2 = @"<iframe src='https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2FmunitruGMCRR%2Fposts%2Fpfbid0vVzShRZbhpsWTwWtnbsXypSDZxiFtXSzCrGboxDAxygWEmNwLKsA4ts8pWhzQDQ6l&show_text=true&width=500' width='229' height='262' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";
            string video = @"<iframe src='https://www.facebook.com/plugins/video.php?height=476&href=https%3A%2F%2Fwww.facebook.com%2Freel%2F1171150814980486%2F&show_text=false&width=267&t=0' width='229' height='262' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";
            string video2 = @"<iframe src='https://www.facebook.com/plugins/video.php?height=476&href=https%3A%2F%2Fwww.facebook.com%2Freel%2F3880564268747410%2F&show_text=false&width=380&t=0' width='229' height='262' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";
            string post3 = @"<iframe src='https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2FTrujilloENVIVONoticias%2Fposts%2Fpfbid02r5gAxiVtb2D4jRTtmwtNSjrDr5po8Ngy2MHPKpoHQMWUUtzQxWn5Tfgoejwvk1WSl&show_text=true&width=500' ' width='229' height='262' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";
            string post4 = @"<iframe src='https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2FmunitruGMCRR%2Fposts%2Fpfbid037J6Q2Gksp5HsiuFcFBNKoYP4j5VuB2hpTrhACS25cBYmHxZ7Xja7raByfYTzJanwl&show_text=true&width=500' width='229' height='262' style='border:none;overflow:hidden' scrolling='no' frameborder='0' allowfullscreen='true' allow='autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share'></iframe>";

            await webView21.EnsureCoreWebView2Async(null);
            webView21.NavigateToString(post1);

            await webView22.EnsureCoreWebView2Async(null);
            webView22.NavigateToString(post2);

            await webView23.EnsureCoreWebView2Async(null);
            webView23.NavigateToString(video);

            await webView24.EnsureCoreWebView2Async(null);
            webView24.NavigateToString(video2);

            await webView25.EnsureCoreWebView2Async(null);
            webView25.NavigateToString(post3);

            await webView26.EnsureCoreWebView2Async(null);
            webView26.NavigateToString(post4);

            labelConsejo.Text = consejos[index];
            labelConsejo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelConsejo.ForeColor = Color.White;
            labelConsejo.BackColor = Color.Transparent;

            timer1.Start();
        }

        private void btnregistroincidencia_Click_1(object sender, EventArgs e)
        {
            AbrirFormulaio(new registro_incidencia(usuarioActual));
            //registro_incidencia incidencia = new registro_incidencia(usuarioActual);
            //incidencia.Show();
            //this.Hide();
        }

        private void btnvisestado_Click(object sender, EventArgs e)
        {
            AbrirFormulaio(new visualizar_estado_reporte(usuarioActual));
            //visualizar_estado_reporte visualizar_Estado_ = new visualizar_estado_reporte(usuarioActual);
            //visualizar_Estado_.Show();
            //this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % consejos.Length; // Cambia al siguiente
            labelConsejo.Text = consejos[index];
            labelConsejo.Font = new Font("Microsoft Sans Serif", 16);
        }

        private void btncerrarses_Click(object sender, EventArgs e)
        {
            Form1 INICIO = new Form1();
            //INICIO.Show();
            this.Hide();
        }

        private void btnestadis_Click(object sender, EventArgs e)
        {
            AbrirFormulaio_2<frmEstadisticas>();
            //frmEstadisticas estadisticas = new frmEstadisticas();
            //estadisticas.Show();
            //this.Hide();
        }
        private void AbrirFormulaio(Form formulario)
        {
            Form abiertoformulario;
            abiertoformulario = panelformularios.Controls.OfType<Form>().FirstOrDefault(f => f.GetType() == formulario.GetType());

            if (abiertoformulario == null)
            {
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                abiertoformulario.BringToFront();
            }
        }
        private void AbrirFormulaio_2<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //else
            //{
            formulario.BringToFront();
            //}
        }
        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {
            panel4.AutoScroll = true;

        }
    }
}

