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
    public partial class frmConfirmacionPago : Form
    {
        // propiedad que se utilizara para confirmar si el pago realizado es exitoso
        public bool pago { get; set; }

        // propiedad que se utilizara para recivir el total a pagar y el codigo del cliente junto con el codigo de la factura
        public double TPagar { get; set; }
        public int codigoCliente { get; set; }
        public int codigoFactura { get; set; }
        public int CantArticulos { get; set; }
        public double DEVUELTA { get; set; }

        // metodo para hacer disable false todos los inputs
        private void disableTodosInputs()
        {
            txtFechaVencTargeta.Enabled = false;
            txtNOCuenta.Enabled = false;
            txtNORuta.Enabled = false;
            txtNoTargeta.Enabled = false;
            txtTotalPAgar.Enabled = false;
            txtTotalPagado.Enabled = false;
            rbCheque.Checked = false;
            rbEfectivo.Checked = false;
            rbTargeta.Checked = false;
            lblNORuta.ForeColor = Color.Black;
            lblNOCuenta.ForeColor = Color.Black;
            lblNOTargeta.ForeColor = Color.Black;
            lblTotalPagado.ForeColor = Color.Black;
            lblVenc.ForeColor = Color.Black;
            lblCantPagado.ForeColor = Color.Black;
        }

        //metodo para validar el modo de pago
        private void validationEnablingInputs()
        {
            if (rbCheque.Checked)
            {
                disableTodosInputs();
                txtNOCuenta.Enabled = true;
                lblNORuta.ForeColor = Color.Red;
                txtNORuta.Enabled = true;
                txtNORuta.Focus();
            }
            else if (rbEfectivo.Checked)
            {
                disableTodosInputs();
                txtTotalPagado.Enabled = true;
                lblTotalPagado.ForeColor = Color.Red;
                txtTotalPagado.Focus();
            }
            else if (rbTargeta.Checked)
            {
                disableTodosInputs();
                txtNoTargeta.Enabled = true;
                lblNOTargeta.ForeColor = Color.Red;
                txtFechaVencTargeta.Enabled = true;
                txtNoTargeta.Focus();
            }
        }

        public frmConfirmacionPago()
        {
            InitializeComponent();
        }

        //evento que detecta cuando la ventana sea abierta
        private void frmConfirmacionPago_Load(object sender, EventArgs e)
        {
            disableTodosInputs();
            if(CantArticulos > 0)
            {
                lblTotalArticulos.Text = CantArticulos.ToString();
            }
            if(TPagar > 0)
            {
                txtTotalPAgar.Text = TPagar.ToString("f2");
            }
        }

        // evento para cerrar la ventana
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            pago = false;
        }


        // eventos para detectar la manera de pago que se utilizara
        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            validationEnablingInputs();
        }
        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            validationEnablingInputs();
        }
        private void rbTargeta_CheckedChanged(object sender, EventArgs e)
        {
            validationEnablingInputs();
        }
        // fin eventos para detevtar la manera de pago que se utilizara

        // detecta si el mask fue completado
        private void txtNORuta_TextChanged(object sender, EventArgs e)
        {
            if (txtNORuta.MaskCompleted)
            {
                txtNOCuenta.Focus();
                lblNORuta.ForeColor = Color.Black;
                lblNOCuenta.ForeColor = Color.Red;
            }
        }
        private void txtNoTargeta_TextChanged(object sender, EventArgs e)
        {
            if (txtNoTargeta.MaskCompleted)
            {
                lblNOTargeta.ForeColor = Color.Black;
                lblVenc.ForeColor = Color.Red;
                txtFechaVencTargeta.Focus();
            }
        }
        private void txtFechaVencTargeta_TextChanged(object sender, EventArgs e)
        {
            if (txtFechaVencTargeta.MaskCompleted)
            {
                DateTime comparacion;
                if(!DateTime.TryParse(txtFechaVencTargeta.Text, out comparacion))
                {
                    MessageBox.Show("La fecha seleccionada no es valida, intentelo nuevamente con el formato (Mes/Año)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblVenc.ForeColor = Color.Black;
                    lblCantPagado.ForeColor = Color.Red;
                    txtCantPagado.Focus();
                }
            }
        }
        // fin eventos para detectar si los masks fueron completados

        // evento para confirmar el pago
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtCantPagado.Text == string.Empty || double.Parse(txtCantPagado.Text) <= 0)
            {
                MessageBox.Show("No se ha digitado una cantidad a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double cantPagar = double.Parse(txtCantPagado.Text), devuelta = 0;
                if(cantPagar < TPagar)
                {
                    MessageBox.Show("La cantidad a pagar no es suficiente para cubrir el pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantPagado.Focus();
                }
                else
                {
                    devuelta = TPagar - cantPagar;
                    if(devuelta <= 0)
                    {
                        devuelta *= -1;
                        DEVUELTA = devuelta;
                        pago = true;
                        this.Close();
                    }
                }
            }
        }

        // validacion para cuando el pago sea en efectivo
        private void txtTotalPagado_TextChanged(object sender, EventArgs e)
        {
            txtCantPagado.Text = txtTotalPagado.Text;
        }

        // validar cuando ya se halla escrito el numero de cuenta
        private void txtNOCuenta_Leave(object sender, EventArgs e)
        {
            if(txtNOCuenta.Text != string.Empty)
            {
                lblCantPagado.ForeColor = Color.Red;
                lblNOCuenta.ForeColor = Color.Black;
                txtTotalPagado.Focus();
            }
        }

        // valida cuando el focus se le halla quitado
        private void txtTotalPagado_Leave(object sender, EventArgs e)
        {
            lblTotalPagado.ForeColor = Color.Black;
            lblCantPagado.ForeColor = Color.Red;
        }
    }
}
