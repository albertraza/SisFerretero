namespace SisFerretero
{
    partial class frmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FerreteriaDBDataSet = new SisFerretero.FerreteriaDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportVentasTableAdapter = new SisFerretero.FerreteriaDBDataSetTableAdapters.reportVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // reportVentasBindingSource
            // 
            this.reportVentasBindingSource.DataMember = "reportVentas";
            this.reportVentasBindingSource.DataSource = this.FerreteriaDBDataSet;
            // 
            // FerreteriaDBDataSet
            // 
            this.FerreteriaDBDataSet.DataSetName = "FerreteriaDBDataSet";
            this.FerreteriaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Ventas";
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackColor = System.Drawing.Color.LightYellow;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(819, -1);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 23);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 18;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            this.pbCerrar.MouseHover += new System.EventHandler(this.pbCerrar_MouseHover);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "reporteVentas";
            reportDataSource1.Value = this.reportVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SisFerretero.reporteVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(786, 501);
            this.reportViewer1.TabIndex = 19;
            // 
            // reportVentasTableAdapter
            // 
            this.reportVentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 573);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ventas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            this.MouseHover += new System.EventHandler(this.frmReporteVentas_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.reportVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox pbCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportVentasBindingSource;
        private FerreteriaDBDataSet FerreteriaDBDataSet;
        private FerreteriaDBDataSetTableAdapters.reportVentasTableAdapter reportVentasTableAdapter;
    }
}