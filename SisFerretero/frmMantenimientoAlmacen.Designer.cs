namespace SisFerretero
{
    partial class frmMantenimientoAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoAlmacen));
            this.pOcultar = new System.Windows.Forms.Panel();
            this.lblOcultar = new System.Windows.Forms.LinkLabel();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.gnInformacionProducto = new System.Windows.Forms.GroupBox();
            this.gbImpuesto = new System.Windows.Forms.GroupBox();
            this.rbNoExonerado = new System.Windows.Forms.RadioButton();
            this.rbExonerado = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.nCantExistente = new System.Windows.Forms.NumericUpDown();
            this.lblCantExistente = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtPrecioUnd = new System.Windows.Forms.TextBox();
            this.lblPrecioUnd = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbSuplidores = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarSuplidor = new System.Windows.Forms.Button();
            this.dgvSuplidores = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pOcultar.SuspendLayout();
            this.pCerrar.SuspendLayout();
            this.gnInformacionProducto.SuspendLayout();
            this.gbImpuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantExistente)).BeginInit();
            this.gbSuplidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuplidores)).BeginInit();
            this.SuspendLayout();
            // 
            // pOcultar
            // 
            this.pOcultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pOcultar.Controls.Add(this.lblOcultar);
            this.pOcultar.Location = new System.Drawing.Point(770, 14);
            this.pOcultar.Name = "pOcultar";
            this.pOcultar.Size = new System.Drawing.Size(79, 43);
            this.pOcultar.TabIndex = 0;
            this.pOcultar.Click += new System.EventHandler(this.pOcultar_Click);
            this.pOcultar.MouseHover += new System.EventHandler(this.pOcultar_MouseHover);
            // 
            // lblOcultar
            // 
            this.lblOcultar.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblOcultar.AutoSize = true;
            this.lblOcultar.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcultar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblOcultar.LinkColor = System.Drawing.Color.Black;
            this.lblOcultar.Location = new System.Drawing.Point(13, 13);
            this.lblOcultar.Name = "lblOcultar";
            this.lblOcultar.Size = new System.Drawing.Size(53, 15);
            this.lblOcultar.TabIndex = 0;
            this.lblOcultar.TabStop = true;
            this.lblOcultar.Text = "Ocultar";
            this.lblOcultar.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblOcultar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOcultar_LinkClicked);
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(855, 14);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(79, 43);
            this.pCerrar.TabIndex = 1;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            this.pCerrar.MouseHover += new System.EventHandler(this.pCerrar_MouseHover);
            // 
            // lblCerrar
            // 
            this.lblCerrar.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCerrar.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.Location = new System.Drawing.Point(15, 13);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(47, 15);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.TabStop = true;
            this.lblCerrar.Text = "Cerrar";
            this.lblCerrar.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrar_LinkClicked);
            // 
            // gnInformacionProducto
            // 
            this.gnInformacionProducto.BackColor = System.Drawing.Color.SandyBrown;
            this.gnInformacionProducto.Controls.Add(this.gbImpuesto);
            this.gnInformacionProducto.Controls.Add(this.txtCodigo);
            this.gnInformacionProducto.Controls.Add(this.lblCodigoProducto);
            this.gnInformacionProducto.Controls.Add(this.nCantExistente);
            this.gnInformacionProducto.Controls.Add(this.lblCantExistente);
            this.gnInformacionProducto.Controls.Add(this.cbDepartamento);
            this.gnInformacionProducto.Controls.Add(this.lblDepartamento);
            this.gnInformacionProducto.Controls.Add(this.txtPrecioUnd);
            this.gnInformacionProducto.Controls.Add(this.lblPrecioUnd);
            this.gnInformacionProducto.Controls.Add(this.txtNombre);
            this.gnInformacionProducto.Controls.Add(this.lblNombre);
            this.gnInformacionProducto.Controls.Add(this.txtDescripcion);
            this.gnInformacionProducto.Controls.Add(this.lblDescripcion);
            this.gnInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnInformacionProducto.ForeColor = System.Drawing.Color.FloralWhite;
            this.gnInformacionProducto.Location = new System.Drawing.Point(28, 66);
            this.gnInformacionProducto.Name = "gnInformacionProducto";
            this.gnInformacionProducto.Size = new System.Drawing.Size(495, 371);
            this.gnInformacionProducto.TabIndex = 2;
            this.gnInformacionProducto.TabStop = false;
            this.gnInformacionProducto.Text = "Informacion del Producto";
            // 
            // gbImpuesto
            // 
            this.gbImpuesto.Controls.Add(this.rbNoExonerado);
            this.gbImpuesto.Controls.Add(this.rbExonerado);
            this.gbImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImpuesto.Location = new System.Drawing.Point(256, 66);
            this.gbImpuesto.Name = "gbImpuesto";
            this.gbImpuesto.Size = new System.Drawing.Size(195, 113);
            this.gbImpuesto.TabIndex = 12;
            this.gbImpuesto.TabStop = false;
            this.gbImpuesto.Text = "ITEBIS";
            // 
            // rbNoExonerado
            // 
            this.rbNoExonerado.AutoSize = true;
            this.rbNoExonerado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbNoExonerado.Location = new System.Drawing.Point(16, 65);
            this.rbNoExonerado.Name = "rbNoExonerado";
            this.rbNoExonerado.Size = new System.Drawing.Size(146, 19);
            this.rbNoExonerado.TabIndex = 1;
            this.rbNoExonerado.TabStop = true;
            this.rbNoExonerado.Text = "No exonerado de Imp.";
            this.rbNoExonerado.UseVisualStyleBackColor = true;
            // 
            // rbExonerado
            // 
            this.rbExonerado.AutoSize = true;
            this.rbExonerado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbExonerado.Location = new System.Drawing.Point(16, 31);
            this.rbExonerado.Name = "rbExonerado";
            this.rbExonerado.Size = new System.Drawing.Size(128, 19);
            this.rbExonerado.TabIndex = 0;
            this.rbExonerado.TabStop = true;
            this.rbExonerado.Text = "Exonerado de Imp.";
            this.rbExonerado.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(327, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(98, 21);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(269, 42);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(56, 15);
            this.lblCodigoProducto.TabIndex = 10;
            this.lblCodigoProducto.Text = "Codigo:";
            // 
            // nCantExistente
            // 
            this.nCantExistente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nCantExistente.ForeColor = System.Drawing.Color.Black;
            this.nCantExistente.Location = new System.Drawing.Point(133, 114);
            this.nCantExistente.Name = "nCantExistente";
            this.nCantExistente.Size = new System.Drawing.Size(97, 22);
            this.nCantExistente.TabIndex = 9;
            // 
            // lblCantExistente
            // 
            this.lblCantExistente.AutoSize = true;
            this.lblCantExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantExistente.Location = new System.Drawing.Point(20, 116);
            this.lblCantExistente.Name = "lblCantExistente";
            this.lblCantExistente.Size = new System.Drawing.Size(107, 15);
            this.lblCantExistente.TabIndex = 8;
            this.lblCantExistente.Text = "Cant. Existente:";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.ForeColor = System.Drawing.Color.Black;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(124, 152);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(106, 23);
            this.cbDepartamento.TabIndex = 7;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(20, 155);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 15);
            this.lblDepartamento.TabIndex = 6;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtPrecioUnd
            // 
            this.txtPrecioUnd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecioUnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnd.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioUnd.Location = new System.Drawing.Point(88, 78);
            this.txtPrecioUnd.Name = "txtPrecioUnd";
            this.txtPrecioUnd.Size = new System.Drawing.Size(98, 21);
            this.txtPrecioUnd.TabIndex = 5;
            // 
            // lblPrecioUnd
            // 
            this.lblPrecioUnd.AutoSize = true;
            this.lblPrecioUnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnd.Location = new System.Drawing.Point(30, 81);
            this.lblPrecioUnd.Name = "lblPrecioUnd";
            this.lblPrecioUnd.Size = new System.Drawing.Size(52, 15);
            this.lblPrecioUnd.TabIndex = 4;
            this.lblPrecioUnd.Text = "Precio:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(88, 42);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 21);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(23, 209);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(454, 145);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 188);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 15);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // gbSuplidores
            // 
            this.gbSuplidores.BackColor = System.Drawing.Color.SandyBrown;
            this.gbSuplidores.Controls.Add(this.btnSeleccionarSuplidor);
            this.gbSuplidores.Controls.Add(this.dgvSuplidores);
            this.gbSuplidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSuplidores.ForeColor = System.Drawing.Color.FloralWhite;
            this.gbSuplidores.Location = new System.Drawing.Point(529, 66);
            this.gbSuplidores.Name = "gbSuplidores";
            this.gbSuplidores.Size = new System.Drawing.Size(388, 371);
            this.gbSuplidores.TabIndex = 3;
            this.gbSuplidores.TabStop = false;
            this.gbSuplidores.Text = "Suplidores";
            // 
            // btnSeleccionarSuplidor
            // 
            this.btnSeleccionarSuplidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarSuplidor.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionarSuplidor.Location = new System.Drawing.Point(107, 342);
            this.btnSeleccionarSuplidor.Name = "btnSeleccionarSuplidor";
            this.btnSeleccionarSuplidor.Size = new System.Drawing.Size(166, 23);
            this.btnSeleccionarSuplidor.TabIndex = 1;
            this.btnSeleccionarSuplidor.Text = "Seleccionar Suplidor";
            this.btnSeleccionarSuplidor.UseVisualStyleBackColor = true;
            // 
            // dgvSuplidores
            // 
            this.dgvSuplidores.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuplidores.Location = new System.Drawing.Point(6, 21);
            this.dgvSuplidores.Name = "dgvSuplidores";
            this.dgvSuplidores.Size = new System.Drawing.Size(376, 304);
            this.dgvSuplidores.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(44, 443);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 35);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(152, 443);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(175, 35);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar Producto";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(348, 443);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 35);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar Producto";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmMantenimientoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(946, 501);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbSuplidores);
            this.Controls.Add(this.gnInformacionProducto);
            this.Controls.Add(this.pCerrar);
            this.Controls.Add(this.pOcultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantenimientoAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoAlmacen";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmMantenimientoAlmacen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMantenimientoAlmacen_MouseDown);
            this.MouseHover += new System.EventHandler(this.frmMantenimientoAlmacen_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMantenimientoAlmacen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMantenimientoAlmacen_MouseUp);
            this.pOcultar.ResumeLayout(false);
            this.pOcultar.PerformLayout();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.gnInformacionProducto.ResumeLayout(false);
            this.gnInformacionProducto.PerformLayout();
            this.gbImpuesto.ResumeLayout(false);
            this.gbImpuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantExistente)).EndInit();
            this.gbSuplidores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuplidores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pOcultar;
        private System.Windows.Forms.LinkLabel lblOcultar;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.GroupBox gnInformacionProducto;
        private System.Windows.Forms.GroupBox gbImpuesto;
        private System.Windows.Forms.RadioButton rbNoExonerado;
        private System.Windows.Forms.RadioButton rbExonerado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.NumericUpDown nCantExistente;
        private System.Windows.Forms.Label lblCantExistente;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtPrecioUnd;
        private System.Windows.Forms.Label lblPrecioUnd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbSuplidores;
        private System.Windows.Forms.DataGridView dgvSuplidores;
        private System.Windows.Forms.Button btnSeleccionarSuplidor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
    }
}