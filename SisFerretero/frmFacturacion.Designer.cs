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
            this.gbInformacionProducto = new System.Windows.Forms.GroupBox();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.gbFacturaTotal = new System.Windows.Forms.GroupBox();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.pCerrar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacionProducto
            // 
            this.gbInformacionProducto.BackColor = System.Drawing.Color.Khaki;
            this.gbInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionProducto.ForeColor = System.Drawing.Color.DimGray;
            this.gbInformacionProducto.Location = new System.Drawing.Point(41, 57);
            this.gbInformacionProducto.Name = "gbInformacionProducto";
            this.gbInformacionProducto.Size = new System.Drawing.Size(494, 242);
            this.gbInformacionProducto.TabIndex = 0;
            this.gbInformacionProducto.TabStop = false;
            this.gbInformacionProducto.Text = "Informacion Producto";
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.BackColor = System.Drawing.Color.Khaki;
            this.gbInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.ForeColor = System.Drawing.Color.DimGray;
            this.gbInformacionCliente.Location = new System.Drawing.Point(553, 57);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(426, 242);
            this.gbInformacionCliente.TabIndex = 1;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Informacion Cliente";
            // 
            // gbCarrito
            // 
            this.gbCarrito.BackColor = System.Drawing.Color.Khaki;
            this.gbCarrito.Controls.Add(this.dgvCarrito);
            this.gbCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarrito.ForeColor = System.Drawing.Color.DimGray;
            this.gbCarrito.Location = new System.Drawing.Point(41, 316);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(672, 242);
            this.gbCarrito.TabIndex = 2;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "Carrito";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCarrito.Location = new System.Drawing.Point(6, 20);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(660, 216);
            this.dgvCarrito.TabIndex = 0;
            // 
            // gbFacturaTotal
            // 
            this.gbFacturaTotal.BackColor = System.Drawing.Color.Khaki;
            this.gbFacturaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFacturaTotal.ForeColor = System.Drawing.Color.DimGray;
            this.gbFacturaTotal.Location = new System.Drawing.Point(737, 316);
            this.gbFacturaTotal.Name = "gbFacturaTotal";
            this.gbFacturaTotal.Size = new System.Drawing.Size(242, 166);
            this.gbFacturaTotal.TabIndex = 3;
            this.gbFacturaTotal.TabStop = false;
            this.gbFacturaTotal.Text = "Total Factura";
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
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(833, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 35);
            this.panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(14, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ocultar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisFerretero.Properties.Resources.fondoFacturacion1;
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFacturacion_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFacturacion_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmFacturacion_MouseUp);
            this.gbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}