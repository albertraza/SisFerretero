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
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }
        // metodo para hacer los texbox disable
        private void DisableTextboxes()
        {
            txtCantidadExistente.Enabled = false;
            txtITEBIS.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtPrecioUnitario.Enabled = false;
            txtTotalaPagar.Enabled = false;
            txtTotalNoImp.Enabled = false;
        }
        //////////////////////////////////////////
        // codigo para poder mover la ventana ///
        ////////////////////////////////////////
        private Point posicion;
        private bool mouseAction;
        private void frmFacturacion_MouseDown(object sender, MouseEventArgs e)
        {
            // este evento detecta si el mouse se esta presionando
            // se obtiene la pocision de la ventana
            // se cambia el valor de la variable mouseAction a true
            posicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }
        private void frmFacturacion_MouseUp(object sender, MouseEventArgs e)
        {
            // este evento detecta si el mouse no esta presionado
            // se cambia el valor de la variable mouseAction a false
            mouseAction = false;
        }
        private void frmFacturacion_MouseMove(object sender, MouseEventArgs e)
        {
            // este evento mueve la ventana
            // se evalua si el mouse esta siendo presionado
            // en caso de, se cambia la posicion de acuerdo al movimiento del mouse
            if (mouseAction)
            {
                this.Location = new Point(Cursor.Position.X - posicion.X, Cursor.Position.Y - posicion.Y);
            }
        }
        /////////////////////////////////////////////
        // final del codigo para mover la ventana///
        ////////////////////////////////////////////
        

        // codigo para cerrar y minimizar
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir?", "Venta de productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void gbInformacionProducto_Enter(object sender, EventArgs e)
        {

        }
        // Final Codigo cerrar y minimizar

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            DisableTextboxes();
        }
    }
}
