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
        // metodo para limpiar todos los textboxes de los productos
        private void clearProductos()
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            nCantComprar.Value = 0;
            txtPrecioUnitario.Text = "0.00";
            txtITEBIS.Text = "0.00";
            txtTotalaPagar.Text = "0.00";
            txtTotalNoImp.Text = "0.00";
            txtCantidadExistente.Text = "0";
            txtNombreProducto.Clear();
        }
        // metodo para limpiar todos los texboxes del cliente
        private void clearCliente()
        {
            txtApellidoCli.Clear();
            txtCelularCli.Clear();
            txtDireccionCli.Clear();
            txtNombreCli.Clear();
            txtTelefonoCli.Clear();
            txtCelularCli.Focus();
        }
        // metodo para hacer los texbox disable
        private void DisableTextboxes()
        {
            // productos
            txtCantidadExistente.Enabled = false;
            txtITEBIS.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtPrecioUnitario.Enabled = false;
            txtTotalaPagar.Enabled = false;
            txtTotalNoImp.Enabled = false;
            txtPrecioUnitario.Text = "0.00";
            txtITEBIS.Text = "0.00";
            txtTotalaPagar.Text = "0.00";
            txtTotalNoImp.Text = "0.00";
            txtCantidadExistente.Text = "0";
            // clientes
            txtCelularCli.Enabled = false;
            txtApellidoCli.Enabled = false;
            txtDireccionCli.Enabled = false;
            txtNombreCli.Enabled = false;
            txtTelefonoCli.Enabled = false;
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
                // delete current factura from database
                int codigo = facturacion.getNewFacturaID();
                facturacion.deleteFactura(codigo);
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
            try
            {
                // cada vez que se abre la ventana se creara una factura nueva
                facturacion.registerFactura(0, DateTime.Now, DateTime.Now, 0, 0, 0, 0);
                dgvCarrito.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvCarrito.DataSource = carrito.getCarrito(facturacion.getNewFacturaID());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarProductos_Click(object sender, EventArgs e)
        {
            clearProductos();
        }

        private void btnLimpiarClientes_Click(object sender, EventArgs e)
        {
            clearCliente();
        }

        // evento buscar para poder cargar un producto en la pantalla
        private void lblBuscarProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int sample;
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("El codigo del producto esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else if (!int.TryParse(txtCodigo.Text, out sample))
            {
                MessageBox.Show("El codigo del producto errone, digitelo nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else
            {
                try
                {
                    // se toma el evento get Producto y se valida para saber si es null.
                    productos pProductos = productos.getProducto(int.Parse(txtCodigo.Text));
                    if (pProductos != null)
                    {
                        txtCantidadExistente.Text = pProductos.cantExistente.ToString();
                        txtNombreProducto.Text = pProductos.nombre;
                        txtPrecioUnitario.Text = pProductos.precioUnd.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigo.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }
        // evento que calcula el total a pagar e impuestos
        private void nCantComprar_ValueChanged(object sender, EventArgs e)
        {
            int sample;
            if(txtNombreProducto.Text == string.Empty)
            {
                // no presenta nada ya que cuando se limpian los campos el numeric updown se iguala a 0 y el codigo se elimina
                // causando que aparesca un mensaje cuando se limpian los campos, es lo mismo para las siguientes dos validaciones.
                txtCodigo.Focus();
            }
            else if(txtCodigo.Text == string.Empty)
            {
                // "
                txtCodigo.Focus();
            }
            else if(!int.TryParse(txtCodigo.Text, out sample))
            {
                // "
                clearProductos();
            }
            else
            {
                try {
                    productos pProductos = productos.getProducto(int.Parse(txtCodigo.Text));
                    if (pProductos != null)
                    {
                        if (pProductos.cantExistente >= nCantComprar.Value)
                        {
                            // para saber si el iten esta excento de impuesto.
                            if (pProductos.Imp > 0)
                            {
                                txtTotalNoImp.Text = (pProductos.precioUnd * nCantComprar.Value).ToString("f2");
                                txtITEBIS.Text = ((double.Parse(txtTotalNoImp.Text)) * 0.18).ToString("f2");
                                txtTotalaPagar.Text = (double.Parse(txtTotalNoImp.Text) + double.Parse(txtITEBIS.Text)).ToString("f2");
                            }
                            else
                            {
                                txtTotalNoImp.Text = (pProductos.precioUnd * nCantComprar.Value).ToString("f2");
                                txtITEBIS.Text = "0.00";
                                txtTotalaPagar.Text = (pProductos.precioUnd * nCantComprar.Value).ToString("f2");
                            }
                        }
                        else if (pProductos.cantExistente == 0)
                        {
                            MessageBox.Show("No hay productos disponibles", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("No hay productos suficientes para esta orden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nCantComprar.Value = pProductos.cantExistente;
                        }
                    }
                }
                catch (Exception)
                {
                    // se deja vacio ya que el evento se activara al momento que se limpien los campos
                }
            }
        }
        // este evento añade el producto al carrito
        private void btnAnadirCarrito_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == string.Empty)
            {
                MessageBox.Show("No se ha cargado un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else if (nCantComprar.Value == 0)
            {
                MessageBox.Show("Seleccione la cantidad de productos que se van a añadir al carrito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nCantComprar.Focus();
            }
            else
            {
                try
                {
                    MessageBox.Show(carrito.añadirCarrito(int.Parse(txtCodigo.Text), facturacion.getNewFacturaID(), Convert.ToInt32(nCantComprar.Value), Convert.ToDecimal(txtITEBIS.Text), Convert.ToDecimal(txtTotalaPagar.Text)), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCarrito.DataSource = carrito.getCarrito(facturacion.getNewFacturaID());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
