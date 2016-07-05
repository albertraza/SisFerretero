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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private int Contador;

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tContador.Start();
        }

        private void tContador_Tick(object sender, EventArgs e)
        {
            Contador++;
            lblProgreso.Text = "";
            lblProgreso.Text = "Progreso: " + Contador.ToString() + "%";
            if(Contador == 101 || Contador > 100)
            {
                tContador.Stop();
                new frmLogin().Show();
                this.Hide();
            }
            else
            {
                pbProgreso.Value = Contador;
            }
        }
    }
}
