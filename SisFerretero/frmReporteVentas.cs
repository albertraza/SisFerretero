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
    public partial class frmReporteVentas : Form
    {
        // propiedad para insertar la fecha del reporte
        public DateTime fechaReporte { get; set; }

        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void pbCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void frmReporteVentas_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FerreteriaDBDataSet.reportVentas' table. You can move, or remove it, as needed.
            this.reportVentasTableAdapter.Fill(this.FerreteriaDBDataSet.reportVentas, fechaReporte);

            this.reportViewer1.RefreshReport();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
