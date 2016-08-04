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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            this.txtcliente.Select();
            this.txtcliente.Focus();
        }

        private void llblbuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void llblcancelar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void llblocultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private bool mousePresionado;
        private Point poscicionActual;
        private void ConsultaClientes_MouseDown(object sender, MouseEventArgs e)
        {
            poscicionActual = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mousePresionado = true;
        }

        private void ConsultaClientes_MouseUp(object sender, MouseEventArgs e)
        {
            mousePresionado = false;
        }

        
        private void ConsultaClientes_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                this.Location = new Point(Cursor.Position.X - poscicionActual.X, Cursor.Position.Y - poscicionActual.Y);
            }
        }
    }
}
