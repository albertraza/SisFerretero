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
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.txtusuario.Select();
            this.txtcontraseña.Focus();
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

                        SqlConnection con = new SqlConnection(@" ");

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
