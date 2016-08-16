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
    public partial class frmChooseDates : Form
    {
        // propiedad para guardar la fecha seleccionada.
        public DateTime fechaSeleccionada { get; set; }
        public bool selecion { get; set; }

        public frmChooseDates()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            fechaSeleccionada = Convert.ToDateTime(dtpFecha.Value.ToString("MM-dd-yyyy"));
            selecion = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            selecion = false;
            this.Close();
        }
    }
}
