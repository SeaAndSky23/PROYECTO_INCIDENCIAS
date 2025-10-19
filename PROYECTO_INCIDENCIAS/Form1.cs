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
    public partial class Form1 : Form
    {
        string archivoUsuarios = "usuarios.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void iscrearcuenta_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.Show();
            this.Hide();
        }

        private void isbtningresar_Click(object sender, EventArgs e)
        {
            string usuario = isusuario.Text.Trim();
            string contrasena = iscontrase.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, ingresa usuario y contraseña.");
                return;
            }

            if (!File.Exists(archivoUsuarios))
            {
                MessageBox.Show("No hay usuarios registrados.");
                return;
            }

            // Leer todas las líneas del archivo
            var lineas = File.ReadAllLines(archivoUsuarios);

            bool usuarioEncontrado = lineas.Any(linea =>
            {
                var datos = linea.Split('|');
                if (datos.Length >= 5)
                {
                    string usuarioArchivo = datos[1];
                    string contrasenaArchivo = datos[4];
                    return usuarioArchivo == usuario && contrasenaArchivo == contrasena;
                }
                return false;
            });

            if (usuarioEncontrado)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                roles rolesform = new roles();
                rolesform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
