using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            //Expresiones lamda
            //Esta expresión permite tomar acciones sobre nuestra lista
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtDocumento.Text && u.Clave == txtContraseña.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio();

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("El usuario ingresado no se encontró", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation());
            }

        }

        private void frm_closing(Object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtContraseña.Text = "";
            this.Show();
        }
    }
}
