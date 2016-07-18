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
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.gbInformacionEnvio = new System.Windows.Forms.GroupBox();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCarrito
            // 
            this.gbCarrito.BackColor = System.Drawing.Color.Gainsboro;
            this.gbCarrito.Controls.Add(this.dataGridView1);
            this.gbCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarrito.Location = new System.Drawing.Point(20, 259);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(776, 266);
            this.gbCarrito.TabIndex = 0;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "Productos comprados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.gbInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.Location = new System.Drawing.Point(20, 21);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(469, 232);
            this.gbInformacionCliente.TabIndex = 1;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Informacion del Cliente";
            // 
            // gbInformacionEnvio
            // 
            this.gbInformacionEnvio.BackColor = System.Drawing.Color.Gainsboro;
            this.gbInformacionEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionEnvio.Location = new System.Drawing.Point(495, 21);
            this.gbInformacionEnvio.Name = "gbInformacionEnvio";
            this.gbInformacionEnvio.Size = new System.Drawing.Size(301, 232);
            this.gbInformacionEnvio.TabIndex = 2;
            this.gbInformacionEnvio.TabStop = false;
            this.gbInformacionEnvio.Text = "Informacion del Envio";
            // 
            // frmDetallesFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 547);
            this.Controls.Add(this.gbInformacionEnvio);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.gbCarrito);
            this.Name = "frmDetallesFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Factura";
            this.gbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarrito;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.GroupBox gbInformacionEnvio;
    }
}