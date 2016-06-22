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
    public partial class frmOrdenesPendientes : Form
    {
        public frmOrdenesPendientes()
        {
            InitializeComponent();
        }

        private void tReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "";
            lblFecha.Text = "Fecha: " + DateTime.Today.ToLongDateString() + " " + DateTime.Today.Date.ToLongTimeString();
        }

        private void frmOrdenesPendientes_Load(object sender, EventArgs e)
        {
            tReloj.Start();
        }
    }
}
