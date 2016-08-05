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
            else if (cbDepartamento.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un departamento");
                cbDepartamento.Select();
            }
            else {
                try
                {

                    SqlConnection con = DataBase.connect();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "registerUsuario";
                    cmd.Connection = con;

                    cmd.Parameters.Add(new SqlParameter("@NombreUsuario", SqlDbType.VarChar));
                    cmd.Parameters["@NombreUsuario"].Value = txtusuario.Text;

                    cmd.Parameters.Add(new SqlParameter("@Contrasena", SqlDbType.VarChar));
                    cmd.Parameters["@Contrasena"].Value = txtcontraseña.Text;

                    cmd.Parameters.Add(new SqlParameter("@Nivel", SqlDbType.Int));
                    cmd.Parameters["@Nivel"].Value = 10;

                    cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.Int));
                    cmd.Parameters["@Departamento"].Value = pDepartamento.NoDepartamento;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario creado exitosamente.");
                    con.Close();
                    txtusuario.Clear();
                    txtcontraseña.Clear();
                    txtusuario.Select();
                    getDepartamentos();

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

        // propiedad para almacenar el departamento del usuario
        private departamento pDepartamento;

        // evento que detecta si se ha seleccionado un departamento
        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // se limpia la propiedad donde se almacenara el departamento
            pDepartamento = null;

            if(cbDepartamento.Text != string.Empty)
            {
                try
                {
                    if (departamento.getDepartamentoByName(cbDepartamento.Text) != null)
                    {
                        pDepartamento = departamento.getDepartamentoByName(cbDepartamento.Text);
                    }
                    else
                    {
                        MessageBox.Show("El Departamento no Existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
