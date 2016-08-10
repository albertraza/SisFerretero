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
                    if (!baseUsuarios.validateUser(txtusuario.Text))
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
                        pDepartamento = null;
                    }
                    else
                    {
                        MessageBox.Show("El Usuario ya existe, digite otro nombre de usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtusuario.Select();
                    }
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

        // propiedad para guardar los usuarios
        private baseUsuarios pUser;
        // evento para buscar los usuarios
        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmConsultaUsuarios pConsulta = new frmConsultaUsuarios();
                pConsulta.menu = false;
                pConsulta.ShowDialog();
                if (pConsulta.pUser != null)
                {
                    pUser = pConsulta.pUser;
                    txtusuario.Text = pConsulta.pUser.Nombre;
                    cbDepartamento.Text = departamento.getDepartamentoInfoByNumber(pConsulta.pUser.codDepartamento).Nombre;
                    btncrear.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se selecciono un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBuscar.Select();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        // evento para modificar el usuario
        private void btnModificar_Click(object sender, EventArgs e)
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
            else
            {
                if(pUser != null)
                {
                    try
                    {
                        pUser.Nombre = txtusuario.Text;
                        pUser.codDepartamento = pDepartamento.NoDepartamento;
                        MessageBox.Show(baseUsuarios.updateUserInfo(pUser, txtcontraseña.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtusuario.Clear();
                        txtcontraseña.Clear();
                        txtusuario.Select();
                        getDepartamentos();
                        pUser = null;
                        pDepartamento = null;

                        btncrear.Enabled = true;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // evento para eliminar un usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(pUser != null)
            {
                if(MessageBox.Show("Esta seguro que desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(baseUsuarios.deleteUsuario(pUser.codigo), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusuario.Clear();
                    txtcontraseña.Clear();
                    txtusuario.Select();
                    getDepartamentos();
                    pUser = null;
                    pDepartamento = null;

                    btncrear.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No se ha cargado un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
