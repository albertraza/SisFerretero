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
    public partial class frmConsultaAlmacen : Form
    {
        // metodo para cargar todos los departamentos
        private void listAllDepartamentos()
        {
            cbDepartamentos.Items.Clear();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand com = new SqlCommand("select departamento from departamentos", con);
                SqlDataReader re = com.ExecuteReader();
                while (re.Read())
                {
                    cbDepartamentos.Items.Add(re["departamento"]);
                }
                con.Close();
            }
        }

        // metodo para cargar todos los suplidores
        private void listAllSuplidores()
        {
            cbSuplidores.Items.Clear();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand("select nombre from Suplidores", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbSuplidores.Items.Add(re["nombre"]);
                }
                con.Close();
            }
        }

        public frmConsultaAlmacen()
        {
            InitializeComponent();
        }

        // eventos para cambiar la forma del mouse cuando pasa por encima de ciertos elementos
        private void frmConsultaAlmacen_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void pOcultar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        // fin codigo para cambiar la forma del mouse

        // eventos para cerrar y minimizar la ventana
        private void pOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblOcultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // fin codigo para cerrar y minimizar

        // codigo para poder mover la ventana
        private bool mousePresionado;
        private Point poscicionActual;
        private void frmConsultaAlmacen_MouseDown(object sender, MouseEventArgs e)
        {
            poscicionActual = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mousePresionado = true;
        }
        private void frmConsultaAlmacen_MouseUp(object sender, MouseEventArgs e)
        {
            mousePresionado = false;
        }
        private void frmConsultaAlmacen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                this.Location = new Point(Cursor.Position.X - poscicionActual.X, Cursor.Position.Y - poscicionActual.Y);
            }
        }
        // fin codigo para mover la ventana

        // evento que detecta cuando la ventana fue abierta
        private void frmConsultaAlmacen_Load(object sender, EventArgs e)
        {
            try
            {
                // se cargan todos los departamentos en le cbDepartamento
                listAllDepartamentos();

                // se cargan todos los suplidores en el cbSuplidor
                listAllSuplidores();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
