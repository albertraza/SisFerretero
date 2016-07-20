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
    public partial class frmDetallesFactura : Form
    {
        // propiedades utilizadas para obtener la factura
        public int codigoFactura { get; set; }

        public frmDetallesFactura()
        {
            InitializeComponent();
        }

        // evento que detcta cuando el formulario fue abierto
        private void frmDetallesFactura_Load(object sender, EventArgs e)
        {
            // se cambia el style de la tabla
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Bold);
            dgvProductos.DefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Regular);
            dgvProductos.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;

            try {
                if (codigoFactura > 0)
                {
                    baseFacturacion factura = baseFacturacion.getFactura(codigoFactura);
                    if (factura != null)
                    {
                        // se carga la informacion del cliente
                        baseClientes pCliente = baseClientes.getClienteInfoCod(factura.codigoCliente);
                        if (pCliente != null)
                        {
                            txtCedula.Text = pCliente.cedula;
                            txtApellido.Text = pCliente.apellido;
                            txtDireccion.Text = pCliente.direccion;
                            txtNombre.Text = pCliente.nombre;
                            txtTelefono.Text = pCliente.telefono;

                            // se cargan el total de las ordenes
                            int TotalOrdenes = baseClientes.getTotalOrdenes(pCliente.codigo);
                            if (TotalOrdenes == 1)
                            {
                                lblResulMensaje.Text = "Esta es la primera orden del cliente!";
                            }
                            else if (TotalOrdenes > 1)
                            {
                                lblResulMensaje.Text = "Ver las demas (" + TotalOrdenes.ToString() + ")";
                            }
                            else
                            {
                                lblResulMensaje.Text = "El total de las ordenes no se ha podido cargar, intentelo nuevamente";
                            }

                            // se carga el carrito 
                            dgvProductos.DataSource = carrito.getCarrito(factura.codigo);
                        }
                        else
                        {
                            MessageBox.Show("El cliente no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // se verifica si se ha despachado la orden
                        if (factura.despachado > 0)
                        {
                            lblMensajeEnvio.Text = "Esta Orden ya ha sido entregada!!!!!";
                        }
                        else
                        {
                            lblMensajeEnvio.Text = "Esta no ha sido entregada!!!!!!";
                        }

                        // se carga la fecha de entrega y la fecha de registro
                        txtFechaRegistro.Text = factura.fechaRegistro.ToString("dd/MM/yyyy");
                        txtFechaEntrega.Text = factura.fechaEntrega.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        MessageBox.Show("La factura no existe, seleccione otra factura; esta ventana se cerrara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error, no se ha especificado la factura a cargar, esta ventana se va a cerrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // eventos para cerrar la ventana
        private void pCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
