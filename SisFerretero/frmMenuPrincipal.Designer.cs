namespace SisFerretero
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.pOcultar = new System.Windows.Forms.Panel();
            this.lblMinimizar = new System.Windows.Forms.LinkLabel();
            this.dgvOrdenesPendientes = new System.Windows.Forms.DataGridView();
            this.tReload = new System.Windows.Forms.Timer(this.components);
            this.msMenuPrincipal.SuspendLayout();
            this.pCerrar.SuspendLayout();
            this.pOcultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.BackColor = System.Drawing.Color.Silver;
            this.msMenuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.utilitariosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msMenuPrincipal.Location = new System.Drawing.Point(29, 9);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(644, 24);
            this.msMenuPrincipal.TabIndex = 0;
            this.msMenuPrincipal.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.suplidoresToolStripMenuItem,
            this.almacenToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // suplidoresToolStripMenuItem
            // 
            this.suplidoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("suplidoresToolStripMenuItem.Image")));
            this.suplidoresToolStripMenuItem.Name = "suplidoresToolStripMenuItem";
            this.suplidoresToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.suplidoresToolStripMenuItem.Text = "Suplidores";
            this.suplidoresToolStripMenuItem.Click += new System.EventHandler(this.suplidoresToolStripMenuItem_Click);
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("almacenToolStripMenuItem.Image")));
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.almacenToolStripMenuItem.Text = "Almacen";
            this.almacenToolStripMenuItem.Click += new System.EventHandler(this.almacenToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.empleadosToolStripMenuItem1,
            this.almacenToolStripMenuItem1,
            this.clientesToolStripMenuItem1,
            this.facturasToolStripMenuItem,
            this.suplidoresToolStripMenuItem2});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem1.Image")));
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem1.Image")));
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // almacenToolStripMenuItem1
            // 
            this.almacenToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("almacenToolStripMenuItem1.Image")));
            this.almacenToolStripMenuItem1.Name = "almacenToolStripMenuItem1";
            this.almacenToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.almacenToolStripMenuItem1.Text = "Almacen";
            this.almacenToolStripMenuItem1.Click += new System.EventHandler(this.almacenToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem1.Image")));
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturasToolStripMenuItem.Image")));
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // suplidoresToolStripMenuItem2
            // 
            this.suplidoresToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("suplidoresToolStripMenuItem2.Image")));
            this.suplidoresToolStripMenuItem2.Name = "suplidoresToolStripMenuItem2";
            this.suplidoresToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.suplidoresToolStripMenuItem2.Text = "Suplidores";
            this.suplidoresToolStripMenuItem2.Click += new System.EventHandler(this.suplidoresToolStripMenuItem2_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaDeProductosToolStripMenuItem,
            this.compraDeProductosToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transaccionesToolStripMenuItem.Image")));
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // ventaDeProductosToolStripMenuItem
            // 
            this.ventaDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaDeProductosToolStripMenuItem.Image")));
            this.ventaDeProductosToolStripMenuItem.Name = "ventaDeProductosToolStripMenuItem";
            this.ventaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ventaDeProductosToolStripMenuItem.Text = "Venta de Productos";
            this.ventaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeProductosToolStripMenuItem_Click);
            // 
            // compraDeProductosToolStripMenuItem
            // 
            this.compraDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compraDeProductosToolStripMenuItem.Image")));
            this.compraDeProductosToolStripMenuItem.Name = "compraDeProductosToolStripMenuItem";
            this.compraDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.compraDeProductosToolStripMenuItem.Text = "Compra de Productos";
            this.compraDeProductosToolStripMenuItem.Click += new System.EventHandler(this.compraDeProductosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // utilitariosToolStripMenuItem
            // 
            this.utilitariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.utilitariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("utilitariosToolStripMenuItem.Image")));
            this.utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            this.utilitariosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.utilitariosToolStripMenuItem.Text = "Utilitarios";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calendarioToolStripMenuItem.Image")));
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculadoraToolStripMenuItem.Image")));
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manualDeUsuarioToolStripMenuItem.Image")));
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(849, 9);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(77, 37);
            this.pCerrar.TabIndex = 1;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            this.pCerrar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pCerrar.MouseHover += new System.EventHandler(this.pCerrar_MouseHover);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCerrar.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.Location = new System.Drawing.Point(19, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(37, 15);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.TabStop = true;
            this.lblCerrar.Text = "Salir";
            this.lblCerrar.VisitedLinkColor = System.Drawing.Color.White;
            this.lblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrar_LinkClicked);
            // 
            // pOcultar
            // 
            this.pOcultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pOcultar.Controls.Add(this.lblMinimizar);
            this.pOcultar.Location = new System.Drawing.Point(763, 9);
            this.pOcultar.Name = "pOcultar";
            this.pOcultar.Size = new System.Drawing.Size(90, 37);
            this.pOcultar.TabIndex = 2;
            this.pOcultar.Click += new System.EventHandler(this.pOcultar_Click);
            this.pOcultar.MouseHover += new System.EventHandler(this.pOcultar_MouseHover);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblMinimizar.LinkColor = System.Drawing.Color.Black;
            this.lblMinimizar.Location = new System.Drawing.Point(17, 9);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(53, 15);
            this.lblMinimizar.TabIndex = 0;
            this.lblMinimizar.TabStop = true;
            this.lblMinimizar.Text = "Ocultar";
            this.lblMinimizar.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblMinimizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMinimizar_LinkClicked);
            // 
            // dgvOrdenesPendientes
            // 
            this.dgvOrdenesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesPendientes.Location = new System.Drawing.Point(29, 103);
            this.dgvOrdenesPendientes.Name = "dgvOrdenesPendientes";
            this.dgvOrdenesPendientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrdenesPendientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrdenesPendientes.Size = new System.Drawing.Size(563, 439);
            this.dgvOrdenesPendientes.TabIndex = 3;
            this.dgvOrdenesPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenesPendientes_CellContentClick);
            // 
            // tReload
            // 
            this.tReload.Interval = 1000;
            this.tReload.Tick += new System.EventHandler(this.tReload_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 565);
            this.Controls.Add(this.dgvOrdenesPendientes);
            this.Controls.Add(this.pOcultar);
            this.Controls.Add(this.pCerrar);
            this.Controls.Add(this.msMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuPrincipal;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMenuPrincipal_MouseDown);
            this.MouseHover += new System.EventHandler(this.frmMenuPrincipal_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMenuPrincipal_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMenuPrincipal_MouseUp);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.pOcultar.ResumeLayout(false);
            this.pOcultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.Panel pOcultar;
        private System.Windows.Forms.LinkLabel lblMinimizar;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem compraDeProductosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvOrdenesPendientes;
        private System.Windows.Forms.Timer tReload;
    }
}