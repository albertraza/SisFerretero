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
    public partial class frmMantenimientoAlmacen : Form
    {
        // metodo para rellenar el combobox del categoria
        private void getCategoria()
        {
            using(SqlConnection con = DataBase.connect())
            {
                cbCategoria.Items.Clear();
                SqlCommand comand = new SqlCommand("select categorias from categorias where categoria != 'Todos'", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbCategoria.Items.Add(re["departamento"]);
                }
                con.Close();
            }
        }

        public frmMantenimientoAlmacen()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////////////
        ///////////// codigo para mover la ventana /////////////
        ////////////////////////////////////////////////////////
        private bool mouseAction;
        private Point LocationW;
        private void frmMantenimientoAlmacen_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }
        private void frmMantenimientoAlmacen_MouseDown(object sender, MouseEventArgs e)
        {
            LocationW = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }
        private void frmMantenimientoAlmacen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction)
            {
                this.Location = new Point(Cursor.Position.X - LocationW.X, Cursor.Position.Y - LocationW.Y);
            }
        }
        ////////////////////////////////////////////////////////
        ///////////// final codigo para mover la ventana ///////
        ////////////////////////////////////////////////////////

        ////////////////// codigo para ocultar y cerrar la ventana ///////
        private void lblOcultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void pOcultar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        ////////////////// fin codigo para ocultar o cerrar la ventana ///

        private void frmMantenimientoAlmacen_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        // este evento detecta cuando la ventana es abierta
        private void frmMantenimientoAlmacen_Load(object sender, EventArgs e)
        {
            try
            {
                // se cargan los departamentos en el combobox
                getCategoria();
                // se le cambia el Style a la tabla de los suplidores
                dgvSuplidores.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Bold);
                dgvSuplidores.DefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Regular);
                dgvSuplidores.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvSuplidores.DefaultCellStyle.ForeColor = Color.Black;
                // se llena la tabla con los suplidores
                dgvSuplidores.DataSource = suplidores.ListSuplidoresCodigoNombre();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento para detectar si la entrada es numerica
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            int comparacion;
            if(!int.TryParse(txtCodigo.Text, out comparacion))
            {
                txtCodigo.Clear();
            }
        }

        // evento para registrar un nuevo producto al almacen
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
