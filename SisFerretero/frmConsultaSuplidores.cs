using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SisFerretero
{
    public partial class frmConsultaSuplidores : Form
    {
        // propiedad para detectar si se ha abierto desde el menu principal
        public bool menu { get; set; }

        public frmConsultaSuplidores()
        {
            InitializeComponent();
        }

        // evento para buscar los suplidores
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.Text == "Codigo")
                {
                    dgvSuplidores.DataSource = baseSuplidores.searchSuplidores(txtBusqueda.Text, "", "");
                }
                else if (cbFiltro.Text == "Nombre")
                {
                    dgvSuplidores.DataSource = baseSuplidores.searchSuplidores("", txtBusqueda.Text, "");
                }
                else if (cbFiltro.Text == "Telefono")
                {
                    dgvSuplidores.DataSource = baseSuplidores.searchSuplidores("", "", txtBusqueda.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Consultaempleados_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSuplidores.DataSource = baseSuplidores.listAllSuplidores();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento para cambiar el tipo de mouse a utilizar
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void frmConsultaSuplidores_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        // evento que valida la entrada en el recuadro busqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if(cbFiltro.Text == "Codigo")
            {
                int compare;
                if(!int.TryParse(txtBusqueda.Text, out compare))
                {
                    txtBusqueda.Clear();
                }
            }
        }

        // evento para limpiar la busqueda
        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            cbFiltro.SelectedIndex = -1;
            txtBusqueda.Mask = "";
            txtBusqueda.Clear();
            txtBusqueda.Select();
            try
            {
                dgvSuplidores.DataSource = baseSuplidores.listAllSuplidores();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento para validar la entrada de texto
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFiltro.Text == "Telefono")
            {
                txtBusqueda.Mask = "(000)000-0000";
                txtBusqueda.Clear();
                txtBusqueda.Select();
            }
            else
            {
                txtBusqueda.Mask = "";
                txtBusqueda.Clear();
                txtBusqueda.Select();
            }
        }

        // eventos para cerrar la ventana
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cerrar la ventana", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la ventana", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // propiedad para guardar la info del suplidor
        public baseSuplidores pSuplidor;

        // evento que obtiene la info del suplidor
        private void dgvSuplidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!menu)
            {
                if(baseSuplidores.getSuplidores(Convert.ToInt32(dgvSuplidores.CurrentRow.Cells[0].Value)) != null)
                {
                    pSuplidor = baseSuplidores.getSuplidores(Convert.ToInt32(dgvSuplidores.CurrentRow.Cells[0].Value));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Suplidor seleccionado no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
