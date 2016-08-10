using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisFerretero
{
    public partial class frmMantenimientoEmpleado : Form
    {
        // metodo para limpiar todos los campos
        private void clearAll()
        {
            _pDepartamento = null;
            txtApellido.Clear();
            txtCedula.Clear();
            txtNOmbre.Clear();
            txtTelefono.Clear();
            getDepartamentos();
            txtNOmbre.Focus();
        }
        // metodo para cargar los departamentos en el combobox
        private void getDepartamentos()
        {
            cbDepartamento.Items.Clear();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand("select * from departamentos", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbDepartamento.Items.Add(re["Nombre"]);
                }
                con.Close();
            }
        }

        public frmMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool mousePresionado;
        private Point posicionActual;
        private void frmMantenimientoEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            posicionActual = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mousePresionado = true;
        }

        private void frmMantenimientoEmpleado_MouseUp(object sender, MouseEventArgs e)
        {
            mousePresionado = false;
        }

        private void frmMantenimientoEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                this.Location = new Point(Cursor.Position.X - posicionActual.X, Cursor.Position.Y - posicionActual.Y);
            }
        }

        // evento que detecta cuando la ventana fue abierta.
        private void frmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                getDepartamentos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento para guardar todos los datos del empleado
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cbDepartamento.Text == string.Empty || _pDepartamento == null)
            {
                MessageBox.Show("No se ha seleccionado un departamento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDepartamento.Select();
            }
            else if(txtNOmbre.Text == string.Empty)
            {
                MessageBox.Show("El Nombre esta vacio, Digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNOmbre.Select();
            }
            else if(txtApellido.Text == string.Empty)
            {
                MessageBox.Show("El Apellido esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Select();
            }
            else if (!txtCedula.MaskCompleted)
            {
                MessageBox.Show("La cedula esta vacia o no haa sido completada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Select();
            }
            else if(txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("El telefono esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
            }
            else
            {
                try
                {
                    Empleados pEmpleado = new Empleados();

                    pEmpleado.Nombre = txtNOmbre.Text;
                    pEmpleado.Apellido = txtApellido.Text;
                    pEmpleado.Departamento = _pDepartamento.NoDepartamento;
                    pEmpleado.Telefono = txtTelefono.Text;
                    pEmpleado.Cedula = txtCedula.Text;

                    MessageBox.Show(Empleados.registerEmpleado(pEmpleado), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearAll();
                }
                catch(Exception
                ex)
                {
                    MessageBox.Show(ex.Message, Application
                        .ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // propiedad para guardar la info del departamento
        private departamento _pDepartamento;

        //evento utilizado cuando el combobox cambia de departamento
        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDepartamento.Text != string.Empty)
            {
                _pDepartamento = departamento.getDepartamentoByName(cbDepartamento.Text);
            }
        }
    }
}
