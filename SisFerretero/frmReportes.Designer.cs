namespace SisFerretero
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.label1 = new System.Windows.Forms.Label();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.pOcultar = new System.Windows.Forms.Panel();
            this.lblOcultar = new System.Windows.Forms.LinkLabel();
            this.btnReporteVentas = new System.Windows.Forms.Button();
            this.btnReporteCompras = new System.Windows.Forms.Button();
            this.btnReporteUsuarios = new System.Windows.Forms.Button();
            this.btnReorteProductos = new System.Windows.Forms.Button();
            this.pCerrar.SuspendLayout();
            this.pOcultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(655, 12);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(81, 37);
            this.pCerrar.TabIndex = 3;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            this.pCerrar.MouseHover += new System.EventHandler(this.pCerrar_MouseHover);
            // 
            // lblCerrar
            // 
            this.lblCerrar.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Red;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCerrar.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.Location = new System.Drawing.Point(16, 11);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(47, 15);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.TabStop = true;
            this.lblCerrar.Text = "Cerrar";
            this.lblCerrar.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrar_LinkClicked);
            // 
            // pOcultar
            // 
            this.pOcultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pOcultar.Controls.Add(this.lblOcultar);
            this.pOcultar.Location = new System.Drawing.Point(568, 12);
            this.pOcultar.Name = "pOcultar";
            this.pOcultar.Size = new System.Drawing.Size(81, 37);
            this.pOcultar.TabIndex = 2;
            this.pOcultar.Click += new System.EventHandler(this.pOcultar_Click);
            this.pOcultar.MouseHover += new System.EventHandler(this.pOcultar_MouseHover);
            // 
            // lblOcultar
            // 
            this.lblOcultar.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblOcultar.AutoSize = true;
            this.lblOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcultar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblOcultar.LinkColor = System.Drawing.Color.Black;
            this.lblOcultar.Location = new System.Drawing.Point(13, 11);
            this.lblOcultar.Name = "lblOcultar";
            this.lblOcultar.Size = new System.Drawing.Size(53, 15);
            this.lblOcultar.TabIndex = 0;
            this.lblOcultar.TabStop = true;
            this.lblOcultar.Text = "Ocultar";
            this.lblOcultar.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblOcultar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOcultar_LinkClicked);
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentas.Location = new System.Drawing.Point(88, 102);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Size = new System.Drawing.Size(245, 58);
            this.btnReporteVentas.TabIndex = 4;
            this.btnReporteVentas.Text = "Reporte de Ventas";
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // btnReporteCompras
            // 
            this.btnReporteCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCompras.Location = new System.Drawing.Point(88, 209);
            this.btnReporteCompras.Name = "btnReporteCompras";
            this.btnReporteCompras.Size = new System.Drawing.Size(245, 58);
            this.btnReporteCompras.TabIndex = 5;
            this.btnReporteCompras.Text = "Reporte Entrada Productos";
            this.btnReporteCompras.UseVisualStyleBackColor = true;
            // 
            // btnReporteUsuarios
            // 
            this.btnReporteUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteUsuarios.Location = new System.Drawing.Point(421, 102);
            this.btnReporteUsuarios.Name = "btnReporteUsuarios";
            this.btnReporteUsuarios.Size = new System.Drawing.Size(245, 58);
            this.btnReporteUsuarios.TabIndex = 6;
            this.btnReporteUsuarios.Text = "Reporte Usuarios";
            this.btnReporteUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnReorteProductos
            // 
            this.btnReorteProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReorteProductos.Location = new System.Drawing.Point(421, 209);
            this.btnReorteProductos.Name = "btnReorteProductos";
            this.btnReorteProductos.Size = new System.Drawing.Size(245, 58);
            this.btnReorteProductos.TabIndex = 7;
            this.btnReorteProductos.Text = "Reporte de Productos";
            this.btnReorteProductos.UseVisualStyleBackColor = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(757, 343);
            this.Controls.Add(this.btnReorteProductos);
            this.Controls.Add(this.btnReporteUsuarios);
            this.Controls.Add(this.btnReporteCompras);
            this.Controls.Add(this.btnReporteVentas);
            this.Controls.Add(this.pCerrar);
            this.Controls.Add(this.pOcultar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseHover += new System.EventHandler(this.frmReportes_MouseHover);
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.pOcultar.ResumeLayout(false);
            this.pOcultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.Panel pOcultar;
        private System.Windows.Forms.LinkLabel lblOcultar;
        private System.Windows.Forms.Button btnReporteVentas;
        private System.Windows.Forms.Button btnReporteCompras;
        private System.Windows.Forms.Button btnReporteUsuarios;
        private System.Windows.Forms.Button btnReorteProductos;
    }
}