using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto2
{
    public partial class Clientes : Form
    {
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
             if (txtnombre.Text == string.Empty || txtapellido.Text == string.Empty || mtbcedula.Text == string.Empty || txtdireccion.Text == string.Empty || mtbtelefono.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos.");
                txtnombre.Select();
            }             
            else
                try
                {
                    SqlConnection con = new SqlConnection(@" ");

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO Clientes (Nombre, Apellido, Cedula, Direccion, Telefono) VALUES ('" + txtnombre.Text + "','" + txtapellido.Text + "','" + mtbcedula.Text + "','" + txtdireccion.Text + "','" + mtbtelefono.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado exitosamente.");
                    con.Close();
                    txtnombre.Clear();
                    txtapellido.Clear();
                    mtbcedula.Clear();
                    txtdireccion.Clear();
                    mtbtelefono.Clear();
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
            try
            {
                SqlConnection con = new SqlConnection(@" ");

                con.Open();
                string buscar = "Select * From Clientes where Cedula='" + mtbcedula.Text + "'";
                SqlCommand cmd = new SqlCommand(buscar, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(buscar, con);
                da.Fill(dt);

                string nombre = dt.Rows[0]["Nombre"].ToString();
                string apellido = dt.Rows[0]["Apellido"].ToString();
                string cedula = dt.Rows[0]["Cedula"].ToString();
                string direccion = dt.Rows[0]["Direccion"].ToString();
                string telefono = dt.Rows[0]["Telefono"].ToString();
                
                
                txtnombre.Text = nombre;
                txtapellido.Text = apellido;
                mtbcedula.Text = cedula;
                txtdireccion.Text = direccion;
                mtbtelefono.Text = telefono;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
