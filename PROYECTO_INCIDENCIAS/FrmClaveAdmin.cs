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
    public partial class FrmClaveAdmin : Form
    {
        private const string contraseñaMaestra = "Admin123";
        public FrmClaveAdmin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbClave.Text == contraseñaMaestra)
            {
                MessageBox.Show("Acceso concedido.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGestionUsuarios gestionUsuarios = new FrmGestionUsuarios();
                gestionUsuarios.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbClave.Clear();
                tbClave.Focus();
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
