using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisFerretero
{
    public partial class Clientes : Form
    {
        // propiedad para guardar la info del cliente
        private baseClientes pClientes;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            txtnombre.Select();
            txtapellido.Focus();
        }

        private void btnaceptar_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = DataBase.connect();
            if (txtnombre.Text == string.Empty || txtapellido.Text == string.Empty || txtCedula.Text == string.Empty || txtdireccion.Text == string.Empty || txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos.");
                txtnombre.Select();
            }
            else
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "registerCliente";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                    cmd.Parameters["@Nombre"].Value = txtnombre.Text;

                    cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                    cmd.Parameters["@Apellido"].Value = txtapellido.Text;

                    cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
                    cmd.Parameters["@Direccion"].Value = txtdireccion.Text;

                    cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
                    cmd.Parameters["@Telefono"].Value = txtTelefono.Text;

                    cmd.Parameters.Add(new SqlParameter("@Cedula", SqlDbType.VarChar));
                    cmd.Parameters["@Cedula"].Value = txtCedula.Text;

                    cmd.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar));
                    cmd.Parameters["@Celular"].Value = txtCelular.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado exitosamente.");
                    con.Close();
                    txtnombre.Clear();
                    txtapellido.Clear();
                    txtCedula.Clear();
                    txtdireccion.Clear();
                    txtTelefono.Clear();
                    txtnombre.Select();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
        }       

        private void lblOcultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void llblbuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == string.Empty || txtapellido.Text == string.Empty || txtCedula.Text == string.Empty || txtdireccion.Text == string.Empty || txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos.");
                txtnombre.Select();
            }
            else if(pClientes == null)
            {
                MessageBox.Show("No se ha cargado un cliente");
            }
            else
            {
                try {
                    SqlConnection con = DataBase.connect();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "updateCliente";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                    cmd.Parameters["@Nombre"].Value = txtnombre.Text;

                    cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                    cmd.Parameters["@Apellido"].Value = txtapellido.Text;

                    cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
                    cmd.Parameters["@Direccion"].Value = txtdireccion.Text;

                    cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
                    cmd.Parameters["@Telefono"].Value = txtdireccion.Text;

                    cmd.Parameters.Add(new SqlParameter("@Cedula", SqlDbType.VarChar));
                    cmd.Parameters["@Cedula"].Value = txtCedula.Text;

                    cmd.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar));
                    cmd.Parameters["@Celular"].Value = txtCelular.Text;

                    cmd.Parameters.Add(new SqlParameter("@NoCliente", SqlDbType.Int));
                    cmd.Parameters["@NoCliente"].Value = pClientes.codigo;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente modificado exitosamente.");
                    con.Close();
                    txtnombre.Clear();
                    txtapellido.Clear();
                    txtCedula.Clear();
                    txtdireccion.Clear();
                    txtTelefono.Clear();
                    txtnombre.Select();
                    pClientes = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == string.Empty || txtapellido.Text == string.Empty || txtCedula.Text == string.Empty || txtdireccion.Text == string.Empty || txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos.");
                txtnombre.Select();
            }
            else if (pClientes == null)
            {
                MessageBox.Show("No se ha cargado un cliente");
            }
            else {
                try {
                    SqlConnection con = DataBase.connect();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "updateCliente";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@NoCliente", SqlDbType.Int));
                    cmd.Parameters["@NoCliente"].Value = pClientes.codigo;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente modificado exitosamente.");
                    con.Close();
                    txtnombre.Clear();
                    txtapellido.Clear();
                    txtCedula.Clear();
                    txtdireccion.Clear();
                    txtTelefono.Clear();
                    txtnombre.Select();
                    pClientes = null;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaClientes pConsulta = new ConsultaClientes();

        }
    }
}
