using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SisFerretero
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // evento para validar la entrada de los datos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtidusuario.Text == string.Empty)
            {
                MessageBox.Show("El Nombre de usuario esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidusuario.Focus();
            }
            else if (txtcontraseña.Text == string.Empty)
            {
                MessageBox.Show("La contraseña esta vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcontraseña.Focus();
            }
            else
            {
                try
                {
                    if (login.getUservalidation(txtidusuario.Text, txtcontraseña.Text))
                    {
                        new frmMenuPrincipal().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El Nombre de Usuario o Contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // evento para cerrar la ventana
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // fin eventos para cerrar la ventana

        // evento para cambiar el cursor
        private void pbCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void frmLogin_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        // fin eventos para cambiar el cursor
    }
}
