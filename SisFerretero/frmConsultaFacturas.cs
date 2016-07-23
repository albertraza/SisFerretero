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
    public partial class frmConsultaFacturas : Form
    {
        public frmConsultaFacturas()
        {
            InitializeComponent();
        }
        // codigo para cambiar el tipo de cursor
        private void pOcultar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void lblCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void frmConsultaFacturas_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        // fin codigo para cambiar el tipo de cursor

        // codigo para cerrar y minimizar la ventana
        private void pOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblOcultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // fin codigo para minimizar y cerrar la ventana

        // eventos para poder mover la ventana
        private bool mousePresionado;
        private Point posicionActual;
        private void frmConsultaFacturas_MouseDown(object sender, MouseEventArgs e)
        {
            posicionActual = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mousePresionado = true;
        }
        private void frmConsultaFacturas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                this.Location = new Point(Cursor.Position.X - posicionActual.X, Cursor.Position.Y - posicionActual.Y);
            }
        }
        private void frmConsultaFacturas_MouseUp(object sender, MouseEventArgs e)
        {
            mousePresionado = false;
        }
        // fin eventos para poder mover la ventana

        // evento para detectar la mascarilla que se usara en el texbox busqueda.
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Cedula Cliente")
            {
                txtBusqueda.Mask = "000-0000000-0";
            }
            else if (cbFiltro.Text == "Fecha Compra")
            {
                txtBusqueda.Mask = "00/00/0000";
            }
            else
            {
                txtBusqueda.Mask = "";
            }
        }

        // evento para validar la entrada cuando este en diferentes filtros
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            int comparacion;
            if (cbFiltro.Text == "Codigo Factura")
            {
                if (!int.TryParse(txtBusqueda.Text, out comparacion))
                {
                    txtBusqueda.Clear();
                }
            }
            else if (cbFiltro.Text == "Fecha Compra")
            {
                DateTime today;
                if (txtBusqueda.MaskCompleted)
                {
                    if (!DateTime.TryParse(txtBusqueda.Text, out today))
                    {
                        MessageBox.Show("Fecha Incorrecta, Intente nuevamente con el Formato (dia/mes/año)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBusqueda.Clear();
                    }
                }
            }
        }

        // evento para verificar los detalles de una factura
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if(dgvFacturas.SelectedRows.Count == 1)
            {
                int codigo = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[0].Value);
                frmDetallesFactura pDetalles = new frmDetallesFactura();
                pDetalles.codigoFactura = codigo;
                pDetalles.ShowDialog();
            }
        }

        //evento que detecta cuando la ventana se ha abierto.
        private void frmConsultaFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                // le cambio el style al data grid view
                dgvFacturas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Bold);
                dgvFacturas.DefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Regular);
                dgvFacturas.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvFacturas.DefaultCellStyle.ForeColor = Color.Black;
                // se cargn todas las facturas
                dgvFacturas.DataSource = facturacion.listAllFacturas();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento para buscar las facturas
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text == string.Empty || !txtBusqueda.MaskCompleted)
                {
                    MessageBox.Show("No se ha digitado la busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBusqueda.Focus();
                }
                else
                {
                    if (cbFiltro.Text == "Codigo Factura")
                    {
                        dgvFacturas.DataSource = facturacion.searchFacturas(txtBusqueda.Text, "", "", "");
                    }
                    else if (cbFiltro.Text == "Cedula Cliente")
                    {
                        dgvFacturas.DataSource = facturacion.searchFacturas("", txtBusqueda.Text, "", "");
                    }
                    else if (cbFiltro.Text == "Nombre Cliente")
                    {
                        dgvFacturas.DataSource = facturacion.searchFacturas("", "", txtBusqueda.Text, "");
                    }
                    else if (cbFiltro.Text == "Fecha Compra")
                    {
                        dgvFacturas.DataSource = facturacion.searchFacturas("", "", "", txtBusqueda.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // metodo para limpiar la busqueda
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // se limpia el mask texbox y se le cambia el mask
            txtBusqueda.Clear();
            txtBusqueda.Mask = "";

            // se selecciona el item vacio
            cbFiltro.SelectedIndex = -1;

            // se cargan todas las facturass
            try
            {
                dgvFacturas.DataSource = facturacion.listAllFacturas();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
