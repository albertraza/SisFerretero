namespace SisFerretero
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.gbInformacionProducto = new System.Windows.Forms.GroupBox();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btnLimpiarProductos = new System.Windows.Forms.Button();
            this.btnAnadirCarrito = new System.Windows.Forms.Button();
            this.lblBuscarProducto = new System.Windows.Forms.LinkLabel();
            this.txtTotalaPagar = new System.Windows.Forms.TextBox();
            this.lblTotalPagarProducto = new System.Windows.Forms.Label();
            this.txtTotalNoImp = new System.Windows.Forms.TextBox();
            this.lblTotalNoImp = new System.Windows.Forms.Label();
            this.txtITEBIS = new System.Windows.Forms.TextBox();
            this.lblITEBIS = new System.Windows.Forms.Label();
            this.nCantComprar = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadComprar = new System.Windows.Forms.Label();
            this.txtCantidadExistente = new System.Windows.Forms.TextBox();
            this.lblCantidadExistente = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnd = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnLimpiarClientes = new System.Windows.Forms.Button();
            this.txtCelularCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCelularCli = new System.Windows.Forms.Label();
            this.txtTelefonoCli = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefonoCli = new System.Windows.Forms.Label();
            this.txtDireccionCli = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.lblApeliidoCliente = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscarCliente = new System.Windows.Forms.LinkLabel();
            this.lblCedula = new System.Windows.Forms.Label();
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.gbFacturaTotal = new System.Windows.Forms.GroupBox();
            this.lblCantidadArticulos = new System.Windows.Forms.Label();
            this.lblTotalaPagar = new System.Windows.Forms.Label();
            this.lblTotalITEBIS = new System.Windows.Forms.Label();
            this.lblTotalComprado = new System.Windows.Forms.Label();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOcultar = new System.Windows.Forms.LinkLabel();
            this.gbInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantComprar)).BeginInit();
            this.gbInformacionCliente.SuspendLayout();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.gbFacturaTotal.SuspendLayout();
            this.pCerrar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacionProducto
            // 
            this.gbInformacionProducto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbInformacionProducto.Controls.Add(this.btnBusquedaAvanzada);
            this.gbInformacionProducto.Controls.Add(this.btnLimpiarProductos);
            this.gbInformacionProducto.Controls.Add(this.btnAnadirCarrito);
            this.gbInformacionProducto.Controls.Add(this.lblBuscarProducto);
            this.gbInformacionProducto.Controls.Add(this.txtTotalaPagar);
            this.gbInformacionProducto.Controls.Add(this.lblTotalPagarProducto);
            this.gbInformacionProducto.Controls.Add(this.txtTotalNoImp);
            this.gbInformacionProducto.Controls.Add(this.lblTotalNoImp);
            this.gbInformacionProducto.Controls.Add(this.txtITEBIS);
            this.gbInformacionProducto.Controls.Add(this.lblITEBIS);
            this.gbInformacionProducto.Controls.Add(this.nCantComprar);
            this.gbInformacionProducto.Controls.Add(this.lblCantidadComprar);
            this.gbInformacionProducto.Controls.Add(this.txtCantidadExistente);
            this.gbInformacionProducto.Controls.Add(this.lblCantidadExistente);
            this.gbInformacionProducto.Controls.Add(this.txtPrecioUnitario);
            this.gbInformacionProducto.Controls.Add(this.lblPrecioUnd);
            this.gbInformacionProducto.Controls.Add(this.txtNombreProducto);
            this.gbInformacionProducto.Controls.Add(this.lblNombre);
            this.gbInformacionProducto.Controls.Add(this.txtCodigo);
            this.gbInformacionProducto.Controls.Add(this.lblCodigoProducto);
            this.gbInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionProducto.ForeColor = System.Drawing.Color.DimGray;
            this.gbInformacionProducto.Location = new System.Drawing.Point(25, 57);
            this.gbInformacionProducto.Name = "gbInformacionProducto";
            this.gbInformacionProducto.Size = new System.Drawing.Size(494, 253);
            this.gbInformacionProducto.TabIndex = 0;
            this.gbInformacionProducto.TabStop = false;
            this.gbInformacionProducto.Text = "Informacion Producto";
            this.gbInformacionProducto.Enter += new System.EventHandler(this.gbInformacionProducto_Enter);
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(162, 204);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(154, 30);
            this.btnBusquedaAvanzada.TabIndex = 19;
            this.btnBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarProductos
            // 
            this.btnLimpiarProductos.Location = new System.Drawing.Point(22, 204);
            this.btnLimpiarProductos.Name = "btnLimpiarProductos";
            this.btnLimpiarProductos.Size = new System.Drawing.Size(134, 30);
            this.btnLimpiarProductos.TabIndex = 18;
            this.btnLimpiarProductos.Text = "Nueva Busqueda";
            this.btnLimpiarProductos.UseVisualStyleBackColor = true;
            this.btnLimpiarProductos.Click += new System.EventHandler(this.btnLimpiarProductos_Click);
            // 
            // btnAnadirCarrito
            // 
            this.btnAnadirCarrito.Location = new System.Drawing.Point(322, 204);
            this.btnAnadirCarrito.Name = "btnAnadirCarrito";
            this.btnAnadirCarrito.Size = new System.Drawing.Size(137, 30);
            this.btnAnadirCarrito.TabIndex = 17;
            this.btnAnadirCarrito.Text = "Añadir al Carrito";
            this.btnAnadirCarrito.UseVisualStyleBackColor = true;
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblBuscarProducto.LinkColor = System.Drawing.Color.Red;
            this.lblBuscarProducto.Location = new System.Drawing.Point(179, 34);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(51, 15);
            this.lblBuscarProducto.TabIndex = 16;
            this.lblBuscarProducto.TabStop = true;
            this.lblBuscarProducto.Text = "Buscar";
            this.lblBuscarProducto.VisitedLinkColor = System.Drawing.Color.Red;
            this.lblBuscarProducto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscarProducto_LinkClicked);
            // 
            // txtTotalaPagar
            // 
            this.txtTotalaPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalaPagar.Location = new System.Drawing.Point(364, 154);
            this.txtTotalaPagar.Name = "txtTotalaPagar";
            this.txtTotalaPagar.Size = new System.Drawing.Size(87, 21);
            this.txtTotalaPagar.TabIndex = 15;
            // 
            // lblTotalPagarProducto
            // 
            this.lblTotalPagarProducto.AutoSize = true;
            this.lblTotalPagarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagarProducto.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagarProducto.Location = new System.Drawing.Point(278, 157);
            this.lblTotalPagarProducto.Name = "lblTotalPagarProducto";
            this.lblTotalPagarProducto.Size = new System.Drawing.Size(83, 15);
            this.lblTotalPagarProducto.TabIndex = 14;
            this.lblTotalPagarProducto.Text = "Total a Pagar:";
            // 
            // txtTotalNoImp
            // 
            this.txtTotalNoImp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalNoImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNoImp.Location = new System.Drawing.Point(364, 114);
            this.txtTotalNoImp.Name = "txtTotalNoImp";
            this.txtTotalNoImp.Size = new System.Drawing.Size(87, 21);
            this.txtTotalNoImp.TabIndex = 13;
            // 
            // lblTotalNoImp
            // 
            this.lblTotalNoImp.AutoSize = true;
            this.lblTotalNoImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNoImp.ForeColor = System.Drawing.Color.Black;
            this.lblTotalNoImp.Location = new System.Drawing.Point(278, 117);
            this.lblTotalNoImp.Name = "lblTotalNoImp";
            this.lblTotalNoImp.Size = new System.Drawing.Size(80, 15);
            this.lblTotalNoImp.TabIndex = 12;
            this.lblTotalNoImp.Text = "Total sin Imp.";
            // 
            // txtITEBIS
            // 
            this.txtITEBIS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtITEBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITEBIS.Location = new System.Drawing.Point(364, 73);
            this.txtITEBIS.Name = "txtITEBIS";
            this.txtITEBIS.Size = new System.Drawing.Size(87, 21);
            this.txtITEBIS.TabIndex = 11;
            // 
            // lblITEBIS
            // 
            this.lblITEBIS.AutoSize = true;
            this.lblITEBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITEBIS.ForeColor = System.Drawing.Color.Black;
            this.lblITEBIS.Location = new System.Drawing.Point(311, 76);
            this.lblITEBIS.Name = "lblITEBIS";
            this.lblITEBIS.Size = new System.Drawing.Size(47, 15);
            this.lblITEBIS.TabIndex = 10;
            this.lblITEBIS.Text = "ITEBIS:";
            // 
            // nCantComprar
            // 
            this.nCantComprar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nCantComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCantComprar.Location = new System.Drawing.Point(364, 32);
            this.nCantComprar.Name = "nCantComprar";
            this.nCantComprar.Size = new System.Drawing.Size(87, 21);
            this.nCantComprar.TabIndex = 9;
            this.nCantComprar.ValueChanged += new System.EventHandler(this.nCantComprar_ValueChanged);
            // 
            // lblCantidadComprar
            // 
            this.lblCantidadComprar.AutoSize = true;
            this.lblCantidadComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadComprar.ForeColor = System.Drawing.Color.Black;
            this.lblCantidadComprar.Location = new System.Drawing.Point(259, 34);
            this.lblCantidadComprar.Name = "lblCantidadComprar";
            this.lblCantidadComprar.Size = new System.Drawing.Size(99, 15);
            this.lblCantidadComprar.TabIndex = 8;
            this.lblCantidadComprar.Text = "Cant. a Comprar:";
            // 
            // txtCantidadExistente
            // 
            this.txtCantidadExistente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCantidadExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadExistente.Location = new System.Drawing.Point(119, 157);
            this.txtCantidadExistente.Name = "txtCantidadExistente";
            this.txtCantidadExistente.Size = new System.Drawing.Size(80, 21);
            this.txtCantidadExistente.TabIndex = 7;
            // 
            // lblCantidadExistente
            // 
            this.lblCantidadExistente.AutoSize = true;
            this.lblCantidadExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadExistente.ForeColor = System.Drawing.Color.Black;
            this.lblCantidadExistente.Location = new System.Drawing.Point(6, 160);
            this.lblCantidadExistente.Name = "lblCantidadExistente";
            this.lblCantidadExistente.Size = new System.Drawing.Size(112, 15);
            this.lblCantidadExistente.TabIndex = 6;
            this.lblCantidadExistente.Text = "Cantidad Existente:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(119, 114);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(80, 21);
            this.txtPrecioUnitario.TabIndex = 5;
            // 
            // lblPrecioUnd
            // 
            this.lblPrecioUnd.AutoSize = true;
            this.lblPrecioUnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnd.ForeColor = System.Drawing.Color.Black;
            this.lblPrecioUnd.Location = new System.Drawing.Point(22, 117);
            this.lblPrecioUnd.Name = "lblPrecioUnd";
            this.lblPrecioUnd.Size = new System.Drawing.Size(91, 15);
            this.lblPrecioUnd.TabIndex = 4;
            this.lblPrecioUnd.Text = "Precio Unitario:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(77, 70);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(122, 21);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(16, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(77, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoProducto.Location = new System.Drawing.Point(22, 34);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(49, 15);
            this.lblCodigoProducto.TabIndex = 0;
            this.lblCodigoProducto.Text = "Codigo:";
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbInformacionCliente.Controls.Add(this.btnModificarCliente);
            this.gbInformacionCliente.Controls.Add(this.btnLimpiarClientes);
            this.gbInformacionCliente.Controls.Add(this.txtCelularCli);
            this.gbInformacionCliente.Controls.Add(this.lblCelularCli);
            this.gbInformacionCliente.Controls.Add(this.txtTelefonoCli);
            this.gbInformacionCliente.Controls.Add(this.lblTelefonoCli);
            this.gbInformacionCliente.Controls.Add(this.txtDireccionCli);
            this.gbInformacionCliente.Controls.Add(this.lblDireccionCliente);
            this.gbInformacionCliente.Controls.Add(this.txtApellidoCli);
            this.gbInformacionCliente.Controls.Add(this.lblApeliidoCliente);
            this.gbInformacionCliente.Controls.Add(this.txtNombreCli);
            this.gbInformacionCliente.Controls.Add(this.lblNombreCli);
            this.gbInformacionCliente.Controls.Add(this.txtCedulaCliente);
            this.gbInformacionCliente.Controls.Add(this.lblBuscarCliente);
            this.gbInformacionCliente.Controls.Add(this.lblCedula);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.ForeColor = System.Drawing.Color.DimGray;
            this.gbInformacionCliente.Location = new System.Drawing.Point(537, 57);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(448, 253);
            this.gbInformacionCliente.TabIndex = 1;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Informacion Cliente";
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(215, 204);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(163, 30);
            this.btnModificarCliente.TabIndex = 32;
            this.btnModificarCliente.Text = "Actualizar Informacion";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarClientes
            // 
            this.btnLimpiarClientes.Location = new System.Drawing.Point(68, 204);
            this.btnLimpiarClientes.Name = "btnLimpiarClientes";
            this.btnLimpiarClientes.Size = new System.Drawing.Size(134, 30);
            this.btnLimpiarClientes.TabIndex = 31;
            this.btnLimpiarClientes.Text = "Nueva Busqueda";
            this.btnLimpiarClientes.UseVisualStyleBackColor = true;
            this.btnLimpiarClientes.Click += new System.EventHandler(this.btnLimpiarClientes_Click);
            // 
            // txtCelularCli
            // 
            this.txtCelularCli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCelularCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularCli.Location = new System.Drawing.Point(319, 111);
            this.txtCelularCli.Mask = "(999) 000-0000";
            this.txtCelularCli.Name = "txtCelularCli";
            this.txtCelularCli.Size = new System.Drawing.Size(100, 21);
            this.txtCelularCli.TabIndex = 30;
            // 
            // lblCelularCli
            // 
            this.lblCelularCli.AutoSize = true;
            this.lblCelularCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularCli.ForeColor = System.Drawing.Color.Black;
            this.lblCelularCli.Location = new System.Drawing.Point(264, 114);
            this.lblCelularCli.Name = "lblCelularCli";
            this.lblCelularCli.Size = new System.Drawing.Size(49, 15);
            this.lblCelularCli.TabIndex = 29;
            this.lblCelularCli.Text = "Celular:";
            // 
            // txtTelefonoCli
            // 
            this.txtTelefonoCli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefonoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCli.Location = new System.Drawing.Point(319, 73);
            this.txtTelefonoCli.Mask = "(999) 000-0000";
            this.txtTelefonoCli.Name = "txtTelefonoCli";
            this.txtTelefonoCli.Size = new System.Drawing.Size(100, 21);
            this.txtTelefonoCli.TabIndex = 28;
            // 
            // lblTelefonoCli
            // 
            this.lblTelefonoCli.AutoSize = true;
            this.lblTelefonoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCli.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonoCli.Location = new System.Drawing.Point(255, 76);
            this.lblTelefonoCli.Name = "lblTelefonoCli";
            this.lblTelefonoCli.Size = new System.Drawing.Size(58, 15);
            this.lblTelefonoCli.TabIndex = 27;
            this.lblTelefonoCli.Text = "Telefono:";
            // 
            // txtDireccionCli
            // 
            this.txtDireccionCli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccionCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCli.Location = new System.Drawing.Point(137, 151);
            this.txtDireccionCli.Name = "txtDireccionCli";
            this.txtDireccionCli.Size = new System.Drawing.Size(278, 21);
            this.txtDireccionCli.TabIndex = 26;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.ForeColor = System.Drawing.Color.Black;
            this.lblDireccionCliente.Location = new System.Drawing.Point(28, 154);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(103, 15);
            this.lblDireccionCliente.TabIndex = 25;
            this.lblDireccionCliente.Text = "Direccion Cliente:";
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellidoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCli.Location = new System.Drawing.Point(84, 111);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(100, 21);
            this.txtApellidoCli.TabIndex = 24;
            // 
            // lblApeliidoCliente
            // 
            this.lblApeliidoCliente.AutoSize = true;
            this.lblApeliidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeliidoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblApeliidoCliente.Location = new System.Drawing.Point(29, 114);
            this.lblApeliidoCliente.Name = "lblApeliidoCliente";
            this.lblApeliidoCliente.Size = new System.Drawing.Size(54, 15);
            this.lblApeliidoCliente.TabIndex = 23;
            this.lblApeliidoCliente.Text = "Apellido:";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCli.Location = new System.Drawing.Point(84, 76);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(100, 21);
            this.txtNombreCli.TabIndex = 22;
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCli.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCli.Location = new System.Drawing.Point(28, 79);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(55, 15);
            this.lblNombreCli.TabIndex = 21;
            this.lblNombreCli.Text = "Nombre:";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(84, 35);
            this.txtCedulaCliente.Mask = "000-0000000-0";
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(118, 21);
            this.txtCedulaCliente.TabIndex = 20;
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblBuscarCliente.LinkColor = System.Drawing.Color.Red;
            this.lblBuscarCliente.Location = new System.Drawing.Point(208, 38);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(51, 15);
            this.lblBuscarCliente.TabIndex = 19;
            this.lblBuscarCliente.TabStop = true;
            this.lblBuscarCliente.Text = "Buscar";
            this.lblBuscarCliente.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.Black;
            this.lblCedula.Location = new System.Drawing.Point(29, 38);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(49, 15);
            this.lblCedula.TabIndex = 17;
            this.lblCedula.Text = "Cedula:";
            // 
            // gbCarrito
            // 
            this.gbCarrito.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbCarrito.Controls.Add(this.dgvCarrito);
            this.gbCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarrito.ForeColor = System.Drawing.Color.DimGray;
            this.gbCarrito.Location = new System.Drawing.Point(25, 316);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(672, 242);
            this.gbCarrito.TabIndex = 2;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "Carrito";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCarrito.Location = new System.Drawing.Point(6, 20);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(660, 216);
            this.dgvCarrito.TabIndex = 0;
            // 
            // gbFacturaTotal
            // 
            this.gbFacturaTotal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbFacturaTotal.Controls.Add(this.lblCantidadArticulos);
            this.gbFacturaTotal.Controls.Add(this.lblTotalaPagar);
            this.gbFacturaTotal.Controls.Add(this.lblTotalITEBIS);
            this.gbFacturaTotal.Controls.Add(this.lblTotalComprado);
            this.gbFacturaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFacturaTotal.ForeColor = System.Drawing.Color.DimGray;
            this.gbFacturaTotal.Location = new System.Drawing.Point(721, 316);
            this.gbFacturaTotal.Name = "gbFacturaTotal";
            this.gbFacturaTotal.Size = new System.Drawing.Size(264, 166);
            this.gbFacturaTotal.TabIndex = 3;
            this.gbFacturaTotal.TabStop = false;
            this.gbFacturaTotal.Text = "Total Factura";
            // 
            // lblCantidadArticulos
            // 
            this.lblCantidadArticulos.AutoSize = true;
            this.lblCantidadArticulos.ForeColor = System.Drawing.Color.Black;
            this.lblCantidadArticulos.Location = new System.Drawing.Point(6, 38);
            this.lblCantidadArticulos.Name = "lblCantidadArticulos";
            this.lblCantidadArticulos.Size = new System.Drawing.Size(147, 15);
            this.lblCantidadArticulos.TabIndex = 3;
            this.lblCantidadArticulos.Text = "Cantidad de Articulos:";
            // 
            // lblTotalaPagar
            // 
            this.lblTotalaPagar.AutoSize = true;
            this.lblTotalaPagar.ForeColor = System.Drawing.Color.Black;
            this.lblTotalaPagar.Location = new System.Drawing.Point(56, 114);
            this.lblTotalaPagar.Name = "lblTotalaPagar";
            this.lblTotalaPagar.Size = new System.Drawing.Size(97, 15);
            this.lblTotalaPagar.TabIndex = 2;
            this.lblTotalaPagar.Text = "Total a Pagar:";
            // 
            // lblTotalITEBIS
            // 
            this.lblTotalITEBIS.AutoSize = true;
            this.lblTotalITEBIS.ForeColor = System.Drawing.Color.Black;
            this.lblTotalITEBIS.Location = new System.Drawing.Point(99, 90);
            this.lblTotalITEBIS.Name = "lblTotalITEBIS";
            this.lblTotalITEBIS.Size = new System.Drawing.Size(54, 15);
            this.lblTotalITEBIS.TabIndex = 1;
            this.lblTotalITEBIS.Text = "ITEBIS:";
            // 
            // lblTotalComprado
            // 
            this.lblTotalComprado.AutoSize = true;
            this.lblTotalComprado.ForeColor = System.Drawing.Color.Black;
            this.lblTotalComprado.Location = new System.Drawing.Point(40, 63);
            this.lblTotalComprado.Name = "lblTotalComprado";
            this.lblTotalComprado.Size = new System.Drawing.Size(113, 15);
            this.lblTotalComprado.TabIndex = 0;
            this.lblTotalComprado.Text = "Total Comprado:";
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(913, 12);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(66, 35);
            this.pCerrar.TabIndex = 0;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCerrar.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.Location = new System.Drawing.Point(14, 11);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(41, 13);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.TabStop = true;
            this.lblCerrar.Text = "Cerrar";
            this.lblCerrar.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrar_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblOcultar);
            this.panel1.Location = new System.Drawing.Point(833, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 35);
            this.panel1.TabIndex = 4;
            // 
            // lblOcultar
            // 
            this.lblOcultar.AutoSize = true;
            this.lblOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcultar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblOcultar.LinkColor = System.Drawing.Color.Black;
            this.lblOcultar.Location = new System.Drawing.Point(14, 11);
            this.lblOcultar.Name = "lblOcultar";
            this.lblOcultar.Size = new System.Drawing.Size(48, 13);
            this.lblOcultar.TabIndex = 1;
            this.lblOcultar.TabStop = true;
            this.lblOcultar.Text = "Ocultar";
            this.lblOcultar.VisitedLinkColor = System.Drawing.Color.White;
            this.lblOcultar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pCerrar);
            this.Controls.Add(this.gbFacturaTotal);
            this.Controls.Add(this.gbCarrito);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.gbInformacionProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de productos";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFacturacion_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFacturacion_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmFacturacion_MouseUp);
            this.gbInformacionProducto.ResumeLayout(false);
            this.gbInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantComprar)).EndInit();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.gbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.gbFacturaTotal.ResumeLayout(false);
            this.gbFacturaTotal.PerformLayout();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacionProducto;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.GroupBox gbCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.GroupBox gbFacturaTotal;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblOcultar;
        private System.Windows.Forms.TextBox txtTotalaPagar;
        private System.Windows.Forms.Label lblTotalPagarProducto;
        private System.Windows.Forms.TextBox txtTotalNoImp;
        private System.Windows.Forms.Label lblTotalNoImp;
        private System.Windows.Forms.TextBox txtITEBIS;
        private System.Windows.Forms.Label lblITEBIS;
        private System.Windows.Forms.NumericUpDown nCantComprar;
        private System.Windows.Forms.Label lblCantidadComprar;
        private System.Windows.Forms.TextBox txtCantidadExistente;
        private System.Windows.Forms.Label lblCantidadExistente;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnd;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.LinkLabel lblBuscarProducto;
        private System.Windows.Forms.Button btnAnadirCarrito;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Button btnLimpiarProductos;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.MaskedTextBox txtCedulaCliente;
        private System.Windows.Forms.LinkLabel lblBuscarCliente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnLimpiarClientes;
        private System.Windows.Forms.MaskedTextBox txtCelularCli;
        private System.Windows.Forms.Label lblCelularCli;
        private System.Windows.Forms.MaskedTextBox txtTelefonoCli;
        private System.Windows.Forms.Label lblTelefonoCli;
        private System.Windows.Forms.TextBox txtDireccionCli;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.Label lblApeliidoCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Label lblTotalaPagar;
        private System.Windows.Forms.Label lblTotalITEBIS;
        private System.Windows.Forms.Label lblTotalComprado;
        private System.Windows.Forms.Label lblCantidadArticulos;
    }
}