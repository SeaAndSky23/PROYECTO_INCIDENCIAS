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
        const string contraseñaMaestra = "Admin123";
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
            bool usuarioEncontrado = false;

            foreach (var linea in lineas)
            {
                var datos = linea.Split('|');
                if (datos.Length >= 6)
                {
                    string usuarioArchivo = datos[1];
                    string contrasenaArchivo = datos[4];
                    string rol = datos[5];

                    if (usuarioArchivo == usuario && contrasenaArchivo == contrasena)
                    {
                        usuarioEncontrado = true;

                        MessageBox.Show($"Inicio de sesión exitoso como {rol}.");

                        if (rol == "Administrador")
                        {
                            FormAutoridad autoridad = new FormAutoridad();
                            autoridad.Show();
                            //inicio_autoridad formAdmin = new inicio_autoridad();
                            //formAdmin.Show();
                        }
                        else
                        {
                            inicio_usuario formUsuario = new inicio_usuario(usuario);
                            formUsuario.Show();
                        }

                        //this.Hide();
                        break;
                    }
                }
            }

            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
