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
    public partial class FrmGestionUsuarios : Form
    {
        string archivoUsuarios = "usuarios.txt";
        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }
        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {

            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Usuario", "Usuario");
            dgvUsuarios.Columns.Add("DNI", "DNI");
            dgvUsuarios.Columns.Add("Telefono", "Teléfono");
            dgvUsuarios.Columns.Add("Contrasena", "Contraseña");
            dgvUsuarios.Columns.Add("Rol", "Rol");

            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ReadOnly = true;

            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            if (!File.Exists(archivoUsuarios))
                return;

            var lineas = File.ReadAllLines(archivoUsuarios);

            foreach (var linea in lineas)
            {
                var datos = linea.Split('|');

                // Si el usuario es antiguo (sin rol), lo agregamos como "Usuario"
                if (datos.Length == 5)
                {
                    string nuevo = $"{linea}|Usuario";
                    File.AppendAllText(archivoUsuarios, Environment.NewLine + nuevo);
                    continue;
                }

                if (datos.Length >= 6)
                {
                    dgvUsuarios.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
                }
            }
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario primero.");
                return;
            }

            var usuarioSeleccionado = dgvUsuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();

            var lineas = File.ReadAllLines(archivoUsuarios).ToList();
            bool encontrado = false;

            for (int i = 0; i < lineas.Count; i++)
            {
                var datos = lineas[i].Split('|');
                if (datos.Length >= 6 && datos[1] == usuarioSeleccionado)
                {
                    datos[5] = "Administrador"; // Asigna el nuevo rol
                    lineas[i] = string.Join("|", datos);
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(archivoUsuarios, lineas);
                MessageBox.Show("Rol asignado correctamente.");
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("No se encontró el usuario en el archivo.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
                return;
            }

            // Obtener el usuario seleccionado
            string usuarioSeleccionado = dgvUsuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();

            // Confirmación antes de eliminar
            DialogResult confirmacion = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar al usuario '{usuarioSeleccionado}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                // Leer todas las líneas del archivo
                var lineas = File.ReadAllLines("usuarios.txt").ToList();

                // Crear nueva lista sin el usuario seleccionado (validando correctamente)
                var nuevaLista = lineas
                    .Where(l =>
                    {
                        var partes = l.Split('|');
                        if (partes.Length > 1)
                            return !partes[1].Equals(usuarioSeleccionado);
                        return true; // Mantiene líneas vacías o inválidas
                    })
                    .ToList();

                // Guardar cambios en el archivo
                File.WriteAllLines("usuarios.txt", nuevaLista);

                // Refrescar DataGridView
                CargarUsuarios();

                MessageBox.Show("Usuario eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
            MessageBox.Show("Lista actualizada.");
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            inicio_autoridad inicio = new inicio_autoridad();
            inicio.Show();
            this.Hide();
        }
    }
}
