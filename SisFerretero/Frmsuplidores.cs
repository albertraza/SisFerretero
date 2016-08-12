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
    public partial class Frmsuplidores : Form
    {
        public Frmsuplidores()
        {
            InitializeComponent();
        }

        // evento para cambiar el tipo de mouse
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void Frmsuplidores_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        // eventos para cerrar la ventana
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
