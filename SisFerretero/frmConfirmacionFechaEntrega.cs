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
    public partial class frmConfirmacionFechaEntrega : Form
    {
        // metodo para validar el despacho
        private void validateDespacho()
        {
            if (rbNo.Checked)
            {
                txtFechaEntrega.Clear();
                txtFechaEntrega.Text = DateTime.Today.Date.ToString("MM/dd/yyyy");
                txtFechaEntrega.Enabled = false;
            }
            else
            {
                txtFechaEntrega.Clear();
                txtFechaEntrega.Enabled = true;
                txtFechaEntrega.Focus();
            }
        }
        // propiedades para indicar los resultados
        public DateTime fechaEntrega { get; set; }
        public bool Despachado { get; set; }

        public frmConfirmacionFechaEntrega()
        {
            InitializeComponent();
        }

        private void gbEnvioDomicilio_Enter(object sender, EventArgs e)
        {

        }

        // evento boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // evento para validar la fecha digitada
        private void txtFechaEntrega_TextChanged(object sender, EventArgs e)
        {
            DateTime comparacion;
            if (txtFechaEntrega.MaskCompleted)
            {
                if (!DateTime.TryParse(txtFechaEntrega.Text, out comparacion))
                {
                    MessageBox.Show("Error al validar la fecha, Intente Nuevamente con el formato (Mes/Dia/Año)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFechaEntrega.Clear();
                    txtFechaEntrega.Focus();
                }
            }
        }

        // evento del boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!txtFechaEntrega.MaskCompleted)
            {
                MessageBox.Show("No se ha digitado una fecha de entrega, digite una valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFechaEntrega.Focus();
            }
            else if(rbNo.Checked == false && rbSi.Checked == false)
            {
                MessageBox.Show("No se ha especificado si la orden se enviara a domicilio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbEnvioDomicilio.Focus();
            }
            else
            {
                fechaEntrega = Convert.ToDateTime(DateTime.Parse(txtFechaEntrega.Text).ToString("MM/dd/yyyy"));
                if (rbSi.Checked)
                {
                    Despachado = true;
                }
                else
                {
                    Despachado = false;
                }
                this.Close();
            }
        }

        // eventos para validar el despacho
        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            validateDespacho();
        }
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            validateDespacho();
        }
        // fin eventos para validar el despacho
    }
}
