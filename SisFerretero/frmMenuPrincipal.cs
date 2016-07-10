using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFerretero
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir del Sistema?", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        // codigo para cerrar y minimizar
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del Sistema?", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void lblMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pOcultar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void frmMenuPrincipal_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del Sistema?", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // final codigo cerrar y minimizar

        /// //////////////////////////////////////
        // Esto es para poder mover la ventana ///
        /////////////////////////////////////////
        private bool mouseAction;
        private Point posicion;
        private void frmMenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            // este codigo detecta si el mouse esta siendo presionado //
            // se captura el punto donde se encuentra el formulario en la pantalla
            // se cambia el valor de la variable mouseAction a true
            posicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }
        private void frmMenuPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            // este codigo detecta si el mouse se ha dejado de presionar
            // se cambia el valor de la variable mouseAction a false
            mouseAction = false;
        }
        private void frmMenuPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            // este codigo mueve la ventana
            // se detecta si el mouse esta siendo presionado
            // se cambia de punto en la pantalla
            if (mouseAction)
            {
                this.Location = new Point(Cursor.Position.X - posicion.X, Cursor.Position.Y - posicion.Y);
            }
        }
        //////////////////////////////////////////////////
        // Final del codigo para poder mover la Ventana //
        //////////////////////////////////////////////////


        private void ventaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFacturacion().Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMantenimientoAlmacen().Show();
        }

        private void almacenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaAlmacen pAlmacen = new frmConsultaAlmacen();
            pAlmacen.menu = true;
            pAlmacen.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Clientes().Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmConsultaUsuarios().Show();
        }
    }
}
