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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.llblcancelar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llblocultar = new System.Windows.Forms.LinkLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFiltro);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Cliente";
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(20, 71);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dgvClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.Size = new System.Drawing.Size(516, 227);
            this.dgvClientes.TabIndex = 34;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Digite su Busqueda:";
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
            this.llblcancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.llblcancelar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblcancelar.LinkColor = System.Drawing.Color.WhiteSmoke;
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
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(419, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(419, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 23);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Nueva Busqueda";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Cedula",
            "Telefono",
            "Celular"});
            this.cbFiltro.Location = new System.Drawing.Point(28, 39);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 23);
            this.cbFiltro.TabIndex = 37;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.dbFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Filtrar por";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(177, 39);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(236, 21);
            this.txtBusqueda.TabIndex = 39;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConsultaClientes_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConsultaClientes_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConsultaClientes_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel llblcancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblocultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txtBusqueda;
    }
}