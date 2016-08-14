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
    public partial class Frmsuplidores : Form
    {
        // metodo para limpiar todos los campos
        private void _ClearAll()
        {
            txtDescripcion.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            _pSuplidor = null;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
        }
        public Frmsuplidores()
        {
            InitializeComponent();
        }

        // evento para cambiar el tipo de mouse
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void Frmsuplidores_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        // eventos para cerrar la ventana
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // evento para guardar un suplidor
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado el nombre del suplidor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Select();
            }
            else if (!txtTelefono.MaskCompleted)
            {
                MessageBox.Show("No se ha completado el telefono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Select();
            }
            else if(txtDireccion.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado la direccion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Select();
            }
            else if(txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado la descripcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Select();
            }
            else
            {
                baseSuplidores pSuplidor = new baseSuplidores();
                pSuplidor.nombre = txtNombre.Text;
                pSuplidor.direccion = txtDireccion.Text;
                pSuplidor.descripcion = txtDescripcion.Text;
                pSuplidor.Telefono = txtTelefono.Text;

                try
                {
                    MessageBox.Show(baseSuplidores.registerSuplidor(pSuplidor), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ClearAll();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // propiedad para guardar la info del suplidor
        private baseSuplidores _pSuplidor;

        // evento para buscar los suplidores
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            frmConsultaSuplidores pConsulta = new frmConsultaSuplidores();
            pConsulta.menu = false;
            pConsulta.ShowDialog();
            try
            {
                if(pConsulta.pSuplidor != null)
                {
                    _pSuplidor = pConsulta.pSuplidor;
                    txtDescripcion.Text = _pSuplidor.descripcion;
                    txtDireccion.Text = _pSuplidor.direccion;
                    txtNombre.Text = _pSuplidor.nombre;
                    txtTelefono.Text = _pSuplidor.Telefono;

                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBorrar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un suplidor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento para modificar los suplidores
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(_pSuplidor != null)
            {
                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("No se ha completado el nombre del suplidor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Select();
                }
                else if (!txtTelefono.MaskCompleted)
                {
                    MessageBox.Show("No se ha completado el telefono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Select();
                }
                else if (txtDireccion.Text == string.Empty)
                {
                    MessageBox.Show("No se ha completado la direccion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDireccion.Select();
                }
                else if (txtDescripcion.Text == string.Empty)
                {
                    MessageBox.Show("No se ha completado la descripcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Select();
                }
                else
                {
                    _pSuplidor.nombre = txtNombre.Text;
                    _pSuplidor.direccion = txtDireccion.Text;
                    _pSuplidor.Telefono = txtTelefono.Text;
                    _pSuplidor.descripcion = txtDescripcion.Text;

                    try
                    {
                        MessageBox.Show(baseSuplidores.updateSuplidor(_pSuplidor), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _ClearAll();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha cargado un suplidor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // evento para eliminar un suplidor
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(_pSuplidor != null)
            {
                if(MessageBox.Show("Esta seguro que desea Eliminar el Suplidor", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show(baseSuplidores.deleteSuplidor(_pSuplidor.NoSuplidor), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _ClearAll();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha cargado un suplidor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
