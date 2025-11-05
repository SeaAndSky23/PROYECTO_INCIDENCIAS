using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROYECTO_INCIDENCIAS
{
    public partial class RegistroUsuario : Form
    {
        string archivoUsuarios = "usuarios.txt";
        private string codigo_telefono;
        private bool codigo_generado = false;

        public RegistroUsuario()
        {
            InitializeComponent();
            tbNombre.TextChanged += GenerarNombreUsuario;
            TbDNI.TextChanged += GenerarNombreUsuario;

            lblVerificacion.Visible = false;
            tbVerificacion.Visible = false;
        }
        private void GenerarNombreUsuario(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            string dni = TbDNI.Text.Trim();

            if (!string.IsNullOrEmpty(nombre) && dni.Length >= 3)
            {
                string[] partes = nombre.Split(' ');
                string primeraPalabra = partes[0];
                string ultimos3 = dni.Substring(dni.Length - 3);
                tbusuario.Text = primeraPalabra + ultimos3;
            }
            else
            {
                tbusuario.Text = "";
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            string dni = TbDNI.Text.Trim();
            string telefono = tbTelefono.Text.Trim();
            string contrasena = tbcontra.Text.Trim();

            if (nombre == "" || dni == "" || telefono == "" || contrasena == "")
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("Numero de DNI no valido");
                return;
            }

            if (telefono.Length != 9 || !telefono.All(char.IsDigit))
            {
                MessageBox.Show("Numero de celular no valido");
                return;
            }

            // Generar usuario
            string[] partesNombre = nombre.Split(' ');
            string primeraPalabra = partesNombre[0];
            string ultimos3 = dni.Length >= 3 ? dni.Substring(dni.Length - 3) : dni;
            string nombreUsuario = primeraPalabra + ultimos3;

            try
            {
                if (!codigo_generado)
                {
                    // Generar código
                    Random rnd = new Random();
                    codigo_telefono = rnd.Next(1000, 999999).ToString();
                    MessageBox.Show("Tu código de verificación es: " + codigo_telefono + ". Por favor, ingrésalo.");

                    lblVerificacion.Visible = true;
                    tbVerificacion.Visible = true;
                    btRegistrar.Text = "Verificar teléfono y registrar";
                    codigo_generado = true;
                }
                else
                {
                    if (string.IsNullOrEmpty(tbVerificacion.Text))
                    {
                        MessageBox.Show("Por favor ingresa el código de verificación.");
                        return;
                    }

                    if (tbVerificacion.Text == codigo_telefono)
                    {
                        // Crear archivo si no existe
                        if (!File.Exists(archivoUsuarios))
                            File.Create(archivoUsuarios).Close();

                        // Verificar duplicados
                        var lineas = File.ReadAllLines(archivoUsuarios);
                        bool existe = lineas.Any(linea =>
                        {
                            var datos = linea.Split('|');
                            return datos.Length >= 3 && (datos[2] == dni || datos[1] == nombreUsuario);
                        });

                        if (existe)
                        {
                            MessageBox.Show("Ya existe un usuario con ese DNI o nombre de usuario.");
                            return;
                        }

                        // Guardar usuario en archivo
                        string nuevoUsuario = $"{nombre}|{nombreUsuario}|{dni}|{telefono}|{contrasena}|Usuario";

                        File.AppendAllText(archivoUsuarios, nuevoUsuario + Environment.NewLine);

                        MessageBox.Show("Usuario registrado correctamente.");

                        Form1 inicio = new Form1();
                        inicio.Show();
                        this.Close();

                        // Resetear
                        codigo_generado = false;
                        btRegistrar.Text = "Registrar";
                        lblVerificacion.Visible = false;
                        tbVerificacion.Visible = false;
                        tbVerificacion.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado es incorrecto. Inténtalo nuevamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnvolver3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
