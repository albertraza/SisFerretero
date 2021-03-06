﻿using System;
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
    public partial class frmConsultaUsuarios : Form
    {
        public frmConsultaUsuarios()
        {
            InitializeComponent();
        }

        // eventos para cambiar la forma del puntero
        private void pOcultar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void frmConsultaUsuarios_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        // fin eventos para cambiar la forma del puntero

        // eventos para cerrar y minimizar la ventana
        private void lblOcultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void pOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // fin eventos para cerrar y minimizar la ventana


        // eventos para mover la ventana
        private bool mousePresionado;
        private Point posicionActual;
        private void frmConsultaUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            posicionActual = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mousePresionado = true;
        }
        private void frmConsultaUsuarios_MouseUp(object sender, MouseEventArgs e)
        {
            mousePresionado = false;
        }
        private void frmConsultaUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                this.Location = new Point(Cursor.Position.X - posicionActual.X, Cursor.Position.Y - posicionActual.Y);
            }
        }
        // fin eventos para mover la ventana

        // evento para validar la entrada en el texbox busqueda cuando el filtro sea "Codigo"
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            int comparacion;
            if(cbFiltro.Text == "Codigo")
            {
                if(!int.TryParse(txtBusqueda.Text, out comparacion))
                {
                    txtBusqueda.Clear();
                }
            }
        }

        // evento para buscar los usuarios
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.Text == "Codigo")
                {
                    dgvUsuarios.DataSource = cUsuarios.searchUsuarios(txtBusqueda.Text, "");
                }
                else if (cbFiltro.Text == "Nombre Usuario")
                {
                    dgvUsuarios.DataSource = cUsuarios.searchUsuarios("", txtBusqueda.Text);
                }
                else
                {
                    MessageBox.Show("Seleccione un filtro para la busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbFiltro.Select();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // evento para limpiar los campos
        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                cbFiltro.SelectedIndex = -1;
                txtBusqueda.Clear();
                txtBusqueda.Select();
                dgvUsuarios.DataSource = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // propiedad para evaluar si la ventana se abrio desde el menu.
        public bool menu;
        // evento que detecta cuando la ventana fue abierta.
        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            // se le cambia el style a la tabla de los usuarios
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Bold);
            dgvUsuarios.DefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Regular);
            dgvUsuarios.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.Black;

            if (!menu)
            {
                try
                {
                    dgvUsuarios.DataSource = cUsuarios.listAllUsuarios();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtBusqueda.Select();
            }
        }

        // propiedad para guardar la info del usuario
        public baseUsuarios pUser;
        // evento para seleccionar los usuarios.
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!menu)
            {
                if(baseUsuarios.getUserInfo(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value)) != null)
                {
                    pUser = baseUsuarios.getUserInfo(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Usuario no Existe, Digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
