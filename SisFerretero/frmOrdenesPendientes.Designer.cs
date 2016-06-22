namespace SisFerretero
{
    partial class frmOrdenesPendientes
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalPendientes = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tReloj = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(299, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTotalPendientes
            // 
            this.lblTotalPendientes.AutoSize = true;
            this.lblTotalPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPendientes.Location = new System.Drawing.Point(12, 60);
            this.lblTotalPendientes.Name = "lblTotalPendientes";
            this.lblTotalPendientes.Size = new System.Drawing.Size(165, 16);
            this.lblTotalPendientes.TabIndex = 1;
            this.lblTotalPendientes.Text = "Ordenes Pendientes: ?";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha ?";
            // 
            // tReloj
            // 
            this.tReloj.Tick += new System.EventHandler(this.tReloj_Tick);
            // 
            // frmOrdenesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 570);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTotalPendientes);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdenesPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ordenes Pendientes";
            this.Load += new System.EventHandler(this.frmOrdenesPendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalPendientes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tReloj;
    }
}