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
        // propiedad para saber si se abre desde el menu
        public bool menu { get; set; }

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
            this.Cursor = Cursors.Arrow;
        }

        private void frmConsultaEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousepresionado)
            {
                this.Location = new Point(Cursor.Position.X - posicionactual.X, Cursor.Position.Y - posicionactual.Y);
            }
        }

        // evento que detecta cuando la ventana fue abierta
        private void frmConsultaEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmpleados.DataSource = baseEmpleados.listAllEmpleados();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // evento que detecta el filtro a utlizar y adapta el mask a los diferentes filtros
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFiltro.Text == "Telefono")
            {
                txtBusqueda.Mask = "(000)000-0000";
                txtBusqueda.Focus();
            }
            else if(cbFiltro.Text == "Cedula")
            {
                txtBusqueda.Mask = "000-0000000-0";
                txtBusqueda.Focus();
            }
            else
            {
                txtBusqueda.Mask = "";
                txtBusqueda.Focus();
            }
        }

        // evento del boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.Text != string.Empty)
                {
                    if (cbFiltro.Text == "Telefono")
                    {
                        dgvEmpleados.DataSource = baseEmpleados.searchEmpleados("", "", txtBusqueda.Text);
                    }
                    else if (cbFiltro.Text == "Cedula")
                    {
                        dgvEmpleados.DataSource = baseEmpleados.searchEmpleados("", txtBusqueda.Text, "");
                    }
                    else if (cbFiltro.Text == "Nombre")
                    {
                        dgvEmpleados.DataSource = baseEmpleados.searchEmpleados(txtBusqueda.Text, "", "");
                    }
                    else
                    {
                        MessageBox.Show("El filtro seleccionado es invalido, seleccione otro diferente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // propiedad que guarda la info del empleado
        public Empleados pEmpleado;

        // evento que detecta los clicks en las celdas de la tabla
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // se verifica si la ventana fue abierta desde el menu
            if (!menu)
            {
                if(Empleados.getEmpleadoByNo(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value)) != null)
                {
                    pEmpleado = Empleados.getEmpleadoByNo(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El empleado seleccionado no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvEmpleados.DataSource = baseEmpleados.listAllEmpleados();
                }
            }
        }
    }
}
