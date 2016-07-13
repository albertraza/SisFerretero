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
        // metodo para cargar todas las categorias
        private void getCategorias()
        {
            txtBusqueda.Items.Clear();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand("select * from categorias where categoria != 'Todos'", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    txtBusqueda.Items.Add(re["categoria"]);
                }
                con.Close();
            }
        }

        // metodo para cargar todos los proveedores
        private void getSuplidores()
        {
            txtBusqueda.Items.Clear();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand("select * from Suplidores where nombre != 'Todos'", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    txtBusqueda.Items.Add(re["nombre"]);
                }
                con.Close();
            }
        }

        // propiedad para detectar si la ventana se esta abriendo desde el registro de productos o desde el menu
        public bool menu { get; set; }

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
                // actualizamos el Style de la tabla para que no choque con la transparencia
                dgvProductos.DefaultCellStyle.BackColor = Color.WhiteSmoke;

                // se llena la tabla con la lista de todos los productos
                dgvProductos.DataSource = productos.listAllProducto();

                // validar el origen de la apertura de la ventana
                if (menu)
                {
                    // si la ventana se abre desde el menu este boton no se mostrara
                    btnSeleccionar.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // esta variable se utilizara para guardar el producto que se tomara de la tabla
        public baseProductos pProducto;

        // evento para seleccionar un producto de la tabla
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // se valida si se ha seleccionado un producto de la tabla
            if(dgvProductos.SelectedRows.Count == 1)
            {
                // si se ha seleccionado un producto
                int codigoProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

                try
                {
                    // se valida la existencia del producto
                    if (productos.getProducto(codigoProducto) != null)
                    {
                        // si el producto existe
                        pProducto = productos.getProducto(codigoProducto);
                        this.Close();
                    }
                    else
                    {
                        // si no existe el producto
                        MessageBox.Show("El Producto no existe, seleccione otro producto de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // sino se ha seleccionado un producto
                MessageBox.Show("No se ha seleccionado un producto de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvProductos.Focus();
            }
        }

        // evento para detectar el tipo de filtro que se usara para la busqueda.
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // se valida el valor de la propiedad text del filtro
                // dependiendo del valor se cargan y se cambia el Style del comboBox
                if (cbFiltro.Text == "Categoria")
                {
                    txtBusqueda.BackColor = Color.WhiteSmoke;
                    txtBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
                    getCategorias();
                }
                else if (cbFiltro.Text == "Proveedor")
                {
                    txtBusqueda.BackColor = Color.WhiteSmoke;
                    txtBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
                    getSuplidores();
                }
                else
                {
                    txtBusqueda.Items.Clear();
                    txtBusqueda.BackColor = Color.WhiteSmoke;
                    txtBusqueda.DropDownStyle = ComboBoxStyle.Simple;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // eventos para buscar un producto
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // se valida el filtro de busqueda.
            try
            {
                // una vez validado se usa el metodo searchProductos con el parametro adecuado
                if (cbFiltro.Text == "Proveedor")
                {
                    dgvProductos.DataSource = productos.searchProductos("", "", txtBusqueda.Text, "");
                }
                else if (cbFiltro.Text == "Categoria")
                {
                    dgvProductos.DataSource = productos.searchProductos("", "", "", txtBusqueda.Text);
                }
                else if (cbFiltro.Text == "Nombre")
                {
                    dgvProductos.DataSource = productos.searchProductos("", txtBusqueda.Text, "", "");
                }
                else if (cbFiltro.Text == "Codigo")
                {
                    dgvProductos.DataSource = productos.searchProductos(txtBusqueda.Text, "", "", "");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // evento para validar la entrada cuando el filtro usado sea el Codigo
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            // se verifica si el filtro es igual al codigo.
            if(cbFiltro.Text == "Codigo")
            {
                // se intenta hacer un parse para verificar si es un INT.
                int comparacion;
                if(!int.TryParse(txtBusqueda.Text, out comparacion))
                {
                    // si es asi se limpia el valor del combobox.
                    txtBusqueda.Text = "";
                }
            }
        }

        // evento para limpiar los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                // se limpian todos los campos
                txtBusqueda.Text = "";
                cbFiltro.Text = "";
                // se cargan todos los datos de los productos en el data grid view
                dgvProductos.DataSource = productos.listAllProducto();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
