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
    public partial class frmConsultaEmpleado : Form
    {
        public frmConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaEmpleado_MouseUp(object sender, MouseEventArgs e)
        {
            mousepresionado = false;
        }
        private bool mousepresionado;
        private Point posicionactual;
        private void frmConsultaEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            posicionactual = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mousepresionado = true;
        }

        private void frmConsultaEmpleado_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void frmConsultaEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousepresionado)
            {
                this.Location = new Point(Cursor.Position.X - posicionactual.X, Cursor.Position.Y - posicionactual.Y);
            }
        }
    }
}
