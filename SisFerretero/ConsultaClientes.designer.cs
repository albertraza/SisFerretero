namespace SisFerretero
{
    partial class ConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblbuscar = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.llblcancelar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llblocultar = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.llblbuscar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Cliente";
            // 
            // llblbuscar
            // 
            this.llblbuscar.AutoSize = true;
            this.llblbuscar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblbuscar.LinkColor = System.Drawing.Color.Black;
            this.llblbuscar.Location = new System.Drawing.Point(303, 43);
            this.llblbuscar.Name = "llblbuscar";
            this.llblbuscar.Size = new System.Drawing.Size(56, 16);
            this.llblbuscar.TabIndex = 35;
            this.llblbuscar.TabStop = true;
            this.llblbuscar.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 227);
            this.dataGridView1.TabIndex = 34;
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(147, 42);
            this.txtcliente.MaxLength = 10;
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(137, 20);
            this.txtcliente.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.llblcancelar);
            this.panel2.Location = new System.Drawing.Point(486, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 39);
            this.panel2.TabIndex = 8;
            // 
            // llblcancelar
            // 
            this.llblcancelar.AutoSize = true;
            this.llblcancelar.BackColor = System.Drawing.Color.Transparent;
            this.llblcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblcancelar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblcancelar.LinkColor = System.Drawing.Color.Black;
            this.llblcancelar.Location = new System.Drawing.Point(15, 11);
            this.llblcancelar.Name = "llblcancelar";
            this.llblcancelar.Size = new System.Drawing.Size(51, 16);
            this.llblcancelar.TabIndex = 36;
            this.llblcancelar.TabStop = true;
            this.llblcancelar.Text = "Cerrar";
            this.llblcancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblcancelar_LinkClicked_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.llblocultar);
            this.panel1.Location = new System.Drawing.Point(397, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 39);
            this.panel1.TabIndex = 7;
            // 
            // llblocultar
            // 
            this.llblocultar.AutoSize = true;
            this.llblocultar.BackColor = System.Drawing.Color.Transparent;
            this.llblocultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblocultar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblocultar.LinkColor = System.Drawing.Color.Black;
            this.llblocultar.Location = new System.Drawing.Point(12, 11);
            this.llblocultar.Name = "llblocultar";
            this.llblocultar.Size = new System.Drawing.Size(57, 16);
            this.llblocultar.TabIndex = 0;
            this.llblocultar.TabStop = true;
            this.llblocultar.Text = "Ocultar";
            this.llblocultar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblocultar_LinkClicked);
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaClientes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.ConsultaClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel llblcancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblocultar;

    }
}