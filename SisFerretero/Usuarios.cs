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
    public partial class Usuarios : Form
    {
        // metodo para cargar los departamentos en el combobox
        private void getDepartamentos()
        {
            cbDepartamento.Items.Clear();
            using(SqlConnection con = DataBase.connect())
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
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.txtusuario.Select();
            this.txtcontraseña.Focus();
            try
            {
                getDepartamentos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

        private void btncrear_Click_1(object sender, EventArgs e)
        {
            if (txtusuario.Text == string.Empty)
            {
                MessageBox.Show("Escriba un nombre de usuario.");
                txtusuario.Select();
            }
            else
                if (txtcontraseña.Text == string.Empty)
                {
                    MessageBox.Show("Escriba una clave.");
                    txtcontraseña.Select();
                }
                else
                {
                    try
                    {

                        SqlConnection con = DataBase.connect();

                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "INSERT INTO Usuarios (Usuario, Clave) VALUES ('" + txtusuario.Text + "','" + txtcontraseña.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario creado exitosamente.");                        
                        con.Close();
                        txtusuario.Clear();
                        txtcontraseña.Clear();
                        txtusuario.Select();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtusuario.Clear();
                        txtusuario.Select();
                        txtcontraseña.Clear();
                    }
                }     
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
