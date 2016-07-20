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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.gbInformacionEnvio = new System.Windows.Forms.GroupBox();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.lblCedula = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbInformacionCliente.SuspendLayout();
            this.pCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCarrito
            // 
            this.gbCarrito.BackColor = System.Drawing.Color.Tan;
            this.gbCarrito.Controls.Add(this.dataGridView1);
            this.gbCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarrito.Location = new System.Drawing.Point(21, 272);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(776, 266);
            this.gbCarrito.TabIndex = 0;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "Productos comprados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.BackColor = System.Drawing.Color.Tan;
            this.gbInformacionCliente.Controls.Add(this.textBox1);
            this.gbInformacionCliente.Controls.Add(this.lblCedula);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.Location = new System.Drawing.Point(21, 59);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(469, 207);
            this.gbInformacionCliente.TabIndex = 1;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Informacion del Cliente";
            // 
            // gbInformacionEnvio
            // 
            this.gbInformacionEnvio.BackColor = System.Drawing.Color.Tan;
            this.gbInformacionEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionEnvio.Location = new System.Drawing.Point(496, 59);
            this.gbInformacionEnvio.Name = "gbInformacionEnvio";
            this.gbInformacionEnvio.Size = new System.Drawing.Size(301, 207);
            this.gbInformacionEnvio.TabIndex = 2;
            this.gbInformacionEnvio.TabStop = false;
            this.gbInformacionEnvio.Text = "Informacion del Envio";
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(686, 12);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(105, 34);
            this.pCerrar.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(75, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 4;
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
            this.gbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarrito;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.GroupBox gbInformacionEnvio;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCedula;
    }
}