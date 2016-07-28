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
            using (SqlConnection con = DataBase.connect())
            {
                cbCategoria.Items.Clear();
                SqlCommand comand = new SqlCommand("select categoria from categorias where categoria != 'Todos'", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbCategoria.Items.Add(re["categoria"]);
                }
                con.Close();
            }
        }

        // creo un enumerador para guardar los detalles de las exoneracionnes de impuestos
        enum Impuesto
        {
            Exonerado = 0,
            NoExonerado = 1
        };

        // metodo para limpiar todos los campos
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtNombre.Clear();
            txtPrecioUnd.Clear();
            nCantExistente.Value = 0;
            pSuplidor = null;
            codigoCategoria = 0;
            getCategoria();
            dgvSuplidores.DataSource = suplidores.ListSuplidoresCodigoNombre();
            txtNombre.Focus();
            rbExonerado.Checked = false;
            rbNoExonerado.Checked = false;
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
            // se hace la validacion de la entrada de los productos.
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("El Nombre del producto esta vacio, digite un nombre para el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if (txtPrecioUnd.Text == string.Empty)
            {
                MessageBox.Show("El precio del producto esta vacio, digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioUnd.Focus();
            }
            else if (nCantExistente.Value == 0)
            {
                MessageBox.Show("No se ha agregado una cantidad de mercancia existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nCantExistente.Focus();
            }
            else if (cbCategoria.Text == string.Empty || codigoCategoria == 0)
            {
                MessageBox.Show("No se ha seleccionado una categoria para el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategoria.Focus();
            }
            else if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("La descripcion no se ha completado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
            }
            else if (rbExonerado.Checked == false && rbNoExonerado.Checked == false)
            {
                MessageBox.Show("No se ha especificado si el producto estara o no exonerado de impuestos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbImpuesto.Focus();
            }
            else if(pSuplidor == null)
            {
                MessageBox.Show("No se ha seleccionado un Suplidor, seleccione uno de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvSuplidores.Focus();
            }
            else
            {
                // si la validacion es exitosa

                // se verifica si el producto esta exonerado de impuesto
                int DetallesExoneracion;
                if (rbExonerado.Checked)
                {
                    DetallesExoneracion = Convert.ToInt32(Impuesto.Exonerado);
                }
                else
                {
                    DetallesExoneracion = Convert.ToInt32(Impuesto.NoExonerado);
                }

                // se crea una instancia para guardar los datos del producto
                baseProductos pProducto = new baseProductos();

                // se llenan las propiedades con la infomarcion del producto
                pProducto.nombre = txtNombre.Text;
                pProducto.cantExistente = Convert.ToInt32(nCantExistente.Value);
                pProducto.codigoSuplidor = pSuplidor.codigo;
                pProducto.detalles = txtDescripcion.Text;
                pProducto.Imp = DetallesExoneracion;
                pProducto.precioUnd = double.Parse(txtPrecioUnd.Text);
                pProducto.codigoCategoria = codigoCategoria;
                // fin de la instancia en donde guardo la informacion del producto

                try
                {
                    // registro los datos
                    MessageBox.Show(baseProductos.Registrar(pProducto), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // variable que guarda el suplidor
        private baseSuplidores pSuplidor;

        // evento que toma un suplidor de la tabla y lo guarda en una variable
        private void btnSeleccionarSuplidor_Click(object sender, EventArgs e)
        {
            // se valida si se esta seleccionando una fila de la tabla
            if(dgvSuplidores.SelectedRows.Count == 1)
            {
                // si es asi

                // se guarda el codigo del suplidor en la variable codigoSuplidor
                int codigoSuplidor = Convert.ToInt32(dgvSuplidores.CurrentRow.Cells[0].Value);
                try
                {
                    // se verifica que exista en la base de datos
                    if (baseSuplidores.getSuplidores(codigoSuplidor) != null)
                    {
                        // si existe
                        pSuplidor = baseSuplidores.getSuplidores(codigoSuplidor);
                        MessageBox.Show("Suplidor Seleccionado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // sino existe
                        MessageBox.Show("El Suplidor no esxiste, seleccione otro de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvSuplidores.DataSource = suplidores.ListSuplidoresCodigoNombre();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // sino se selecciona una fila de la tabla
                MessageBox.Show("Seleccione un suplidor de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //variable para guardar el codigo de la categoria
        private int codigoCategoria;

        // evento que obtiene el codigo de la categoria
        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // se valida si la propiedad text esta vacia
            if(cbCategoria.Text != string.Empty)
            {
                // sino esta vacia
                try
                {
                    categoria pCategoria = categoria.getCategoria(cbCategoria.Text);
                    codigoCategoria = pCategoria.codigo;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // boton para limpiar todos los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                // se ejecuta el metodo LimpiarCampos
                LimpiarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento para validar la entrada en el TextBox precio Undidad
        private void txtPrecioUnd_TextChanged(object sender, EventArgs e)
        {
            double comparacion;
            if(!double.TryParse(txtPrecioUnd.Text, out comparacion))
            {
                txtPrecioUnd.Clear();
            }
        }

        // propiedad para guardar el Producto
        private baseProductos pProducto;

        // evento para hacer una busqueda avanzada de los productos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try { 
            // se crea una instancia del form consulta almacen
            frmConsultaAlmacen pConsulta = new frmConsultaAlmacen();

            // la propiedad menu se coloca en false ya que se esta llamando desde el mantenimiento de almacen
            pConsulta.menu = false;
            pConsulta.ShowDialog();

                // se valida la propiedad pProducto del form consulta almacen
                if (pConsulta.pProducto != null)
                {
                    // se limpian todos los campos
                    LimpiarCampos();

                    // si no esta vacia se rellenan los campos con las propiedades del form consulta
                    txtCodigo.Text = pConsulta.pProducto.codigo.ToString();
                    txtDescripcion.Text = pConsulta.pProducto.detalles;
                    txtNombre.Text = pConsulta.pProducto.nombre;
                    txtPrecioUnd.Text = pConsulta.pProducto.precioUnd.ToString("f2");
                    nCantExistente.Value = pConsulta.pProducto.cantExistente;
                    cbCategoria.Text = categoria.getCategoriaCodigo(pConsulta.pProducto.codigoCategoria).Categoria;

                    // se valida la exoneracion de impuestos
                    if (Convert.ToInt32(Impuesto.Exonerado) == pConsulta.pProducto.Imp)
                    {
                        rbExonerado.Checked = true;
                    }
                    else if (Convert.ToInt32(Impuesto.NoExonerado) == pConsulta.pProducto.Imp)
                    {
                        rbNoExonerado.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al validar la exoneracion de impuestos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // se guarda el producto en la propiedad
                    pProducto = pConsulta.pProducto;
                    btnRegistrar.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento para modificar el producto
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(pProducto != null)
            {
                pProducto.nombre = txtNombre.Text;
                pProducto.cantExistente = Convert.ToInt32(nCantExistente.Value);

                // se toma el codigo de la categoria seleccionada
                pProducto.codigoCategoria = codigoCategoria;

                // se valida si se ha seleccionado un suplidor diferente al original
                if(pSuplidor != null)
                {
                    pProducto.codigoSuplidor = pSuplidor.codigo;
                }

                pProducto.precioUnd = double.Parse(txtPrecioUnd.Text);
                pProducto.detalles = txtDescripcion.Text;

                // se valida si el producto es exonerado de impuesto
                int DetallesExoneracion;
                if (rbExonerado.Checked)
                {
                    DetallesExoneracion = Convert.ToInt32(Impuesto.Exonerado);
                }
                else
                {
                    DetallesExoneracion = Convert.ToInt32(Impuesto.NoExonerado);
                }
                pProducto.Imp = DetallesExoneracion;
            }
            else
            {
                MessageBox.Show("No se ha cargado un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscar.Focus();
            }
        }
    }
}
