namespace SisFerretero
{
    partial class frmDetallesFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallesFactura));
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.lblResulMensaje = new System.Windows.Forms.LinkLabel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.gbInformacionEnvio = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensajeEnvio = new System.Windows.Forms.LinkLabel();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.lblTotalSinImp = new System.Windows.Forms.Label();
            this.lblITEBIS = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblInformacionPago = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbInformacionCliente.SuspendLayout();
            this.gbInformacionEnvio.SuspendLayout();
            this.pCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCarrito
            // 
            this.gbCarrito.BackColor = System.Drawing.Color.Tan;
            this.gbCarrito.Controls.Add(this.lblTotalItems);
            this.gbCarrito.Controls.Add(this.lblInformacionPago);
            this.gbCarrito.Controls.Add(this.lblTotalPagar);
            this.gbCarrito.Controls.Add(this.lblITEBIS);
            this.gbCarrito.Controls.Add(this.lblTotalSinImp);
            this.gbCarrito.Controls.Add(this.dgvProductos);
            this.gbCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarrito.Location = new System.Drawing.Point(21, 272);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(788, 266);
            this.gbCarrito.TabIndex = 0;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "Productos comprados";
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 18);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(578, 242);
            this.dgvProductos.TabIndex = 0;
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.BackColor = System.Drawing.Color.Tan;
            this.gbInformacionCliente.Controls.Add(this.lblResulMensaje);
            this.gbInformacionCliente.Controls.Add(this.lblMensaje);
            this.gbInformacionCliente.Controls.Add(this.txtDireccion);
            this.gbInformacionCliente.Controls.Add(this.lblDireccion);
            this.gbInformacionCliente.Controls.Add(this.txtTelefono);
            this.gbInformacionCliente.Controls.Add(this.lblTelefono);
            this.gbInformacionCliente.Controls.Add(this.txtApellido);
            this.gbInformacionCliente.Controls.Add(this.lblApellido);
            this.gbInformacionCliente.Controls.Add(this.txtNombre);
            this.gbInformacionCliente.Controls.Add(this.lblNombre);
            this.gbInformacionCliente.Controls.Add(this.txtCedula);
            this.gbInformacionCliente.Controls.Add(this.lblCedula);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.Location = new System.Drawing.Point(21, 59);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(469, 207);
            this.gbInformacionCliente.TabIndex = 1;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Informacion del Cliente";
            // 
            // lblResulMensaje
            // 
            this.lblResulMensaje.AutoSize = true;
            this.lblResulMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResulMensaje.Location = new System.Drawing.Point(26, 178);
            this.lblResulMensaje.Name = "lblResulMensaje";
            this.lblResulMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblResulMensaje.TabIndex = 14;
            this.lblResulMensaje.TabStop = true;
            this.lblResulMensaje.Text = "Mensaje";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(26, 160);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(167, 15);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "Mensaje sobre el Cliente";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(79, 127);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(313, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(18, 129);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(282, 38);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(101, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(224, 40);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(251, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(105, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(198, 81);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(75, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(102, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(75, 38);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(137, 20);
            this.txtCedula.TabIndex = 4;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(26, 40);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Cedula:";
            // 
            // gbInformacionEnvio
            // 
            this.gbInformacionEnvio.BackColor = System.Drawing.Color.Tan;
            this.gbInformacionEnvio.Controls.Add(this.label1);
            this.gbInformacionEnvio.Controls.Add(this.lblMensajeEnvio);
            this.gbInformacionEnvio.Controls.Add(this.txtFechaEntrega);
            this.gbInformacionEnvio.Controls.Add(this.lblFechaEntrega);
            this.gbInformacionEnvio.Controls.Add(this.txtFechaRegistro);
            this.gbInformacionEnvio.Controls.Add(this.lblFechaRegistro);
            this.gbInformacionEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionEnvio.Location = new System.Drawing.Point(496, 59);
            this.gbInformacionEnvio.Name = "gbInformacionEnvio";
            this.gbInformacionEnvio.Size = new System.Drawing.Size(313, 207);
            this.gbInformacionEnvio.TabIndex = 2;
            this.gbInformacionEnvio.TabStop = false;
            this.gbInformacionEnvio.Text = "Informacion del Envio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mensaje acerca del envio";
            // 
            // lblMensajeEnvio
            // 
            this.lblMensajeEnvio.AutoSize = true;
            this.lblMensajeEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeEnvio.Location = new System.Drawing.Point(42, 160);
            this.lblMensajeEnvio.Name = "lblMensajeEnvio";
            this.lblMensajeEnvio.Size = new System.Drawing.Size(47, 13);
            this.lblMensajeEnvio.TabIndex = 15;
            this.lblMensajeEnvio.TabStop = true;
            this.lblMensajeEnvio.Text = "Mensaje";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrega.Location = new System.Drawing.Point(115, 84);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(129, 20);
            this.txtFechaEntrega.TabIndex = 14;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(29, 86);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(80, 13);
            this.lblFechaEntrega.TabIndex = 13;
            this.lblFechaEntrega.Text = "Fecha Entrega:";
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRegistro.Location = new System.Drawing.Point(115, 38);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(129, 20);
            this.txtFechaRegistro.TabIndex = 12;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(27, 40);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(82, 13);
            this.lblFechaRegistro.TabIndex = 11;
            this.lblFechaRegistro.Text = "Fecha Registro:";
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(686, 12);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(105, 34);
            this.pCerrar.TabIndex = 0;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            this.pCerrar.MouseHover += new System.EventHandler(this.pCerrar_MouseHover);
            // 
            // lblCerrar
            // 
            this.lblCerrar.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCerrar.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.Location = new System.Drawing.Point(26, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(51, 16);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.TabStop = true;
            this.lblCerrar.Text = "Cerrar";
            this.lblCerrar.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrar_LinkClicked);
            // 
            // lblTotalSinImp
            // 
            this.lblTotalSinImp.AutoSize = true;
            this.lblTotalSinImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSinImp.Location = new System.Drawing.Point(607, 90);
            this.lblTotalSinImp.Name = "lblTotalSinImp";
            this.lblTotalSinImp.Size = new System.Drawing.Size(94, 15);
            this.lblTotalSinImp.TabIndex = 1;
            this.lblTotalSinImp.Text = "Total sin Imp:";
            // 
            // lblITEBIS
            // 
            this.lblITEBIS.AutoSize = true;
            this.lblITEBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITEBIS.Location = new System.Drawing.Point(647, 119);
            this.lblITEBIS.Name = "lblITEBIS";
            this.lblITEBIS.Size = new System.Drawing.Size(54, 15);
            this.lblITEBIS.TabIndex = 2;
            this.lblITEBIS.Text = "ITEBIS:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(604, 147);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(97, 15);
            this.lblTotalPagar.TabIndex = 3;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // lblInformacionPago
            // 
            this.lblInformacionPago.AutoSize = true;
            this.lblInformacionPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionPago.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblInformacionPago.Location = new System.Drawing.Point(626, 31);
            this.lblInformacionPago.Name = "lblInformacionPago";
            this.lblInformacionPago.Size = new System.Drawing.Size(120, 15);
            this.lblInformacionPago.TabIndex = 4;
            this.lblInformacionPago.Text = "Informacion Pago";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(590, 63);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(111, 15);
            this.lblTotalItems.TabIndex = 5;
            this.lblTotalItems.Text = "Total Productos:";
            // 
            // frmDetallesFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 547);
            this.Controls.Add(this.pCerrar);
            this.Controls.Add(this.gbInformacionEnvio);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.gbCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetallesFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Factura";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmDetallesFactura_Load);
            this.MouseHover += new System.EventHandler(this.frmDetallesFactura_MouseHover);
            this.gbCarrito.ResumeLayout(false);
            this.gbCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.gbInformacionEnvio.ResumeLayout(false);
            this.gbInformacionEnvio.PerformLayout();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarrito;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.GroupBox gbInformacionEnvio;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.LinkLabel lblResulMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblMensajeEnvio;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblInformacionPago;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblITEBIS;
        private System.Windows.Forms.Label lblTotalSinImp;
        private System.Windows.Forms.Label lblTotalItems;
    }
}