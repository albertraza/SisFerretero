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
        public bool menu;
        public baseClientes pCliente;

        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.DataSource = baseClientes.listAllClientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void dbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFiltro.Text == "Telefono" || cbFiltro.Text == "Celular")
            {
                txtBusqueda.Clear();
                txtBusqueda.Mask = "(000) 000-0000";
                txtBusqueda.Select();
            }
            else if(cbFiltro.Text == "Cedula")
            {
                txtBusqueda.Clear();
                txtBusqueda.Mask = "000-0000000-0";
                txtBusqueda.Select();
            }
            else
            {
                txtBusqueda.Clear();
                txtBusqueda.Mask = "";
                txtBusqueda.Select();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if(cbFiltro.Text == "Codigo")
            {
                int comparacion;
                if(!int.TryParse(txtBusqueda.Text, out comparacion))
                {
                    txtBusqueda.Clear();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.Text == "Codigo")
                {
                    dgvClientes.DataSource = baseClientes.searchClientes(txtBusqueda.Text, "", "", "", "");
                }
                else if (cbFiltro.Text == "Telefono")
                {
                    dgvClientes.DataSource = baseClientes.searchClientes("", "", "", txtBusqueda.Text, "");
                }
                else if (cbFiltro.Text == "Cedula")
                {
                    dgvClientes.DataSource = baseClientes.searchClientes("", "", txtBusqueda.Text, "", "");
                }
                else if (cbFiltro.Text == "Celular")
                {
                    dgvClientes.DataSource = baseClientes.searchClientes("", "", "", "", txtBusqueda.Text);
                }
                else if (cbFiltro.Text == "Nombre")
                {
                    dgvClientes.DataSource = baseClientes.searchClientes("", txtBusqueda.Text, "", "", "");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            txtBusqueda.Mask = "";
            cbFiltro.SelectedIndex = -1;
            try
            {
                dgvClientes.DataSource = baseClientes.listAllClientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!menu)
            {
                try
                {
                    if(baseClientes.getClienteInfoCod(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value)) != null)
                    {
                        pCliente = baseClientes.getClienteInfoCod(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El cliente seleccionado no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
