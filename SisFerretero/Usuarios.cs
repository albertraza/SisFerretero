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
        private void getEmpleados()
        {
            cbEmpleado.Items.Clear();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand("select * from empleados", con);
                SqlDataAdapter da = new SqlDataAdapter(comand);
                DataTable dt = new DataTable("empleados");

                da.Fill(dt);

                cbEmpleado.DataSource = dt;
                cbEmpleado.DisplayMember = "Nombre";
                cbEmpleado.ValueMember = "codigo";
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
                getEmpleados();
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
            else if (cbEmpleado.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un departamento");
                cbEmpleado.Select();
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

                        cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.Int));
                        cmd.Parameters["@Empleado"].Value = cbEmpleado.SelectedValue;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario creado exitosamente.");
                        con.Close();
                        txtusuario.Clear();
                        txtcontraseña.Clear();
                        txtusuario.Select();
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
            // limpo las propiedades
            pUser = null;
            try
            {
                frmConsultaUsuarios pConsulta = new frmConsultaUsuarios();
                pConsulta.menu = false;
                pConsulta.ShowDialog();
                if (pConsulta.pUser != null)
                {
                    pUser = pConsulta.pUser;

                    // valido si el empleado enlazado al usuario existe
                    if (Empleados.getEmpleadoByNo(pUser.codEmpleado) != null)
                    {
                        cbEmpleado.Text = Empleados.getEmpleadoByNo(pUser.codEmpleado).Nombre;
                    }
                    else
                    {
                        MessageBox.Show("El Empleado enlazado a este usuario no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    txtusuario.Text = pConsulta.pUser.Nombre;
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

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
           // none...
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
            else if (cbEmpleado.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un departamento");
                cbEmpleado.Select();
            }
            else
            {
                if(pUser != null)
                {
                    try
                    {
                        pUser.Nombre = txtusuario.Text;
                        MessageBox.Show(baseUsuarios.updateUserInfo(pUser, txtcontraseña.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtusuario.Clear();
                        txtcontraseña.Clear();
                        txtusuario.Select();
                        pUser = null;

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
                    pUser = null;

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

        // cambian la forma del mouse
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void Usuarios_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        // para cerrar la ventana
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
