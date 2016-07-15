namespace SisFerretero
{
    partial class frmConfirmacionPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmacionPago));
            this.gbModoPago = new System.Windows.Forms.GroupBox();
            this.rbTargeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.gbInformacionPago = new System.Windows.Forms.GroupBox();
            this.txtNOCuenta = new System.Windows.Forms.TextBox();
            this.txtFechaVencTargeta = new System.Windows.Forms.MaskedTextBox();
            this.gbTotalaPagar = new System.Windows.Forms.GroupBox();
            this.lblTotalArticulos = new System.Windows.Forms.Label();
            this.lblCantArticulos = new System.Windows.Forms.Label();
            this.txtCantPagado = new System.Windows.Forms.TextBox();
            this.lblCantPagado = new System.Windows.Forms.Label();
            this.txtTotalPAgar = new System.Windows.Forms.TextBox();
            this.lblTotalaPagar = new System.Windows.Forms.Label();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.txtTotalPagado = new System.Windows.Forms.TextBox();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblVenc = new System.Windows.Forms.Label();
            this.lblNOTargeta = new System.Windows.Forms.Label();
            this.txtNoTargeta = new System.Windows.Forms.MaskedTextBox();
            this.lblTargeta = new System.Windows.Forms.Label();
            this.lblNOCuenta = new System.Windows.Forms.Label();
            this.lblNORuta = new System.Windows.Forms.Label();
            this.txtNORuta = new System.Windows.Forms.MaskedTextBox();
            this.lblCheque = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbModoPago.SuspendLayout();
            this.gbInformacionPago.SuspendLayout();
            this.gbTotalaPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModoPago
            // 
            this.gbModoPago.BackColor = System.Drawing.Color.Gainsboro;
            this.gbModoPago.Controls.Add(this.rbTargeta);
            this.gbModoPago.Controls.Add(this.rbEfectivo);
            this.gbModoPago.Controls.Add(this.rbCheque);
            this.gbModoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModoPago.Location = new System.Drawing.Point(12, 35);
            this.gbModoPago.Name = "gbModoPago";
            this.gbModoPago.Size = new System.Drawing.Size(419, 70);
            this.gbModoPago.TabIndex = 0;
            this.gbModoPago.TabStop = false;
            this.gbModoPago.Text = "Modo de pago";
            // 
            // rbTargeta
            // 
            this.rbTargeta.AutoSize = true;
            this.rbTargeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbTargeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTargeta.Location = new System.Drawing.Point(255, 34);
            this.rbTargeta.Name = "rbTargeta";
            this.rbTargeta.Size = new System.Drawing.Size(130, 17);
            this.rbTargeta.TabIndex = 2;
            this.rbTargeta.TabStop = true;
            this.rbTargeta.Text = "Targeta credito/debito";
            this.rbTargeta.UseVisualStyleBackColor = true;
            this.rbTargeta.CheckedChanged += new System.EventHandler(this.rbTargeta_CheckedChanged);
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.Location = new System.Drawing.Point(142, 34);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(79, 17);
            this.rbEfectivo.TabIndex = 1;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "En Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCheque.Location = new System.Drawing.Point(27, 34);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(83, 17);
            this.rbCheque.TabIndex = 0;
            this.rbCheque.TabStop = true;
            this.rbCheque.Text = "Con Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            this.rbCheque.CheckedChanged += new System.EventHandler(this.rbCheque_CheckedChanged);
            // 
            // gbInformacionPago
            // 
            this.gbInformacionPago.BackColor = System.Drawing.Color.Gainsboro;
            this.gbInformacionPago.Controls.Add(this.txtNOCuenta);
            this.gbInformacionPago.Controls.Add(this.txtFechaVencTargeta);
            this.gbInformacionPago.Controls.Add(this.gbTotalaPagar);
            this.gbInformacionPago.Controls.Add(this.lblTotalPagado);
            this.gbInformacionPago.Controls.Add(this.txtTotalPagado);
            this.gbInformacionPago.Controls.Add(this.lblEfectivo);
            this.gbInformacionPago.Controls.Add(this.lblVenc);
            this.gbInformacionPago.Controls.Add(this.lblNOTargeta);
            this.gbInformacionPago.Controls.Add(this.txtNoTargeta);
            this.gbInformacionPago.Controls.Add(this.lblTargeta);
            this.gbInformacionPago.Controls.Add(this.lblNOCuenta);
            this.gbInformacionPago.Controls.Add(this.lblNORuta);
            this.gbInformacionPago.Controls.Add(this.txtNORuta);
            this.gbInformacionPago.Controls.Add(this.lblCheque);
            this.gbInformacionPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionPago.Location = new System.Drawing.Point(12, 127);
            this.gbInformacionPago.Name = "gbInformacionPago";
            this.gbInformacionPago.Size = new System.Drawing.Size(419, 310);
            this.gbInformacionPago.TabIndex = 1;
            this.gbInformacionPago.TabStop = false;
            this.gbInformacionPago.Text = "Informacion Pago";
            // 
            // txtNOCuenta
            // 
            this.txtNOCuenta.Location = new System.Drawing.Point(260, 42);
            this.txtNOCuenta.Name = "txtNOCuenta";
            this.txtNOCuenta.Size = new System.Drawing.Size(142, 21);
            this.txtNOCuenta.TabIndex = 18;
            this.txtNOCuenta.Leave += new System.EventHandler(this.txtNOCuenta_Leave);
            // 
            // txtFechaVencTargeta
            // 
            this.txtFechaVencTargeta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaVencTargeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaVencTargeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVencTargeta.Location = new System.Drawing.Point(310, 93);
            this.txtFechaVencTargeta.Mask = "00/00";
            this.txtFechaVencTargeta.Name = "txtFechaVencTargeta";
            this.txtFechaVencTargeta.Size = new System.Drawing.Size(92, 20);
            this.txtFechaVencTargeta.TabIndex = 17;
            this.txtFechaVencTargeta.TextChanged += new System.EventHandler(this.txtFechaVencTargeta_TextChanged);
            // 
            // gbTotalaPagar
            // 
            this.gbTotalaPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbTotalaPagar.Controls.Add(this.lblTotalArticulos);
            this.gbTotalaPagar.Controls.Add(this.lblCantArticulos);
            this.gbTotalaPagar.Controls.Add(this.txtCantPagado);
            this.gbTotalaPagar.Controls.Add(this.lblCantPagado);
            this.gbTotalaPagar.Controls.Add(this.txtTotalPAgar);
            this.gbTotalaPagar.Controls.Add(this.lblTotalaPagar);
            this.gbTotalaPagar.Location = new System.Drawing.Point(12, 188);
            this.gbTotalaPagar.Name = "gbTotalaPagar";
            this.gbTotalaPagar.Size = new System.Drawing.Size(390, 100);
            this.gbTotalaPagar.TabIndex = 12;
            this.gbTotalaPagar.TabStop = false;
            this.gbTotalaPagar.Text = "Total Pagar";
            // 
            // lblTotalArticulos
            // 
            this.lblTotalArticulos.AutoSize = true;
            this.lblTotalArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArticulos.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotalArticulos.Location = new System.Drawing.Point(319, 51);
            this.lblTotalArticulos.Name = "lblTotalArticulos";
            this.lblTotalArticulos.Size = new System.Drawing.Size(32, 16);
            this.lblTotalArticulos.TabIndex = 18;
            this.lblTotalArticulos.Text = "???";
            // 
            // lblCantArticulos
            // 
            this.lblCantArticulos.AutoSize = true;
            this.lblCantArticulos.Location = new System.Drawing.Point(285, 30);
            this.lblCantArticulos.Name = "lblCantArticulos";
            this.lblCantArticulos.Size = new System.Drawing.Size(99, 15);
            this.lblCantArticulos.TabIndex = 17;
            this.lblCantArticulos.Text = "Cant. Articulos";
            // 
            // txtCantPagado
            // 
            this.txtCantPagado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCantPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantPagado.Location = new System.Drawing.Point(130, 66);
            this.txtCantPagado.Name = "txtCantPagado";
            this.txtCantPagado.Size = new System.Drawing.Size(148, 20);
            this.txtCantPagado.TabIndex = 16;
            // 
            // lblCantPagado
            // 
            this.lblCantPagado.AutoSize = true;
            this.lblCantPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPagado.Location = new System.Drawing.Point(16, 69);
            this.lblCantPagado.Name = "lblCantPagado";
            this.lblCantPagado.Size = new System.Drawing.Size(108, 13);
            this.lblCantPagado.TabIndex = 15;
            this.lblCantPagado.Text = "Cantidad Pagado:";
            // 
            // txtTotalPAgar
            // 
            this.txtTotalPAgar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalPAgar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPAgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPAgar.Location = new System.Drawing.Point(128, 30);
            this.txtTotalPAgar.Name = "txtTotalPAgar";
            this.txtTotalPAgar.Size = new System.Drawing.Size(150, 20);
            this.txtTotalPAgar.TabIndex = 14;
            // 
            // lblTotalaPagar
            // 
            this.lblTotalaPagar.AutoSize = true;
            this.lblTotalaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalaPagar.Location = new System.Drawing.Point(36, 33);
            this.lblTotalaPagar.Name = "lblTotalaPagar";
            this.lblTotalaPagar.Size = new System.Drawing.Size(88, 13);
            this.lblTotalaPagar.TabIndex = 13;
            this.lblTotalaPagar.Text = "Total a Pagar:";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagado.Location = new System.Drawing.Point(25, 150);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagado.TabIndex = 11;
            this.lblTotalPagado.Text = "Total Pagado:";
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagado.Location = new System.Drawing.Point(105, 147);
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagado.TabIndex = 10;
            this.txtTotalPagado.TextChanged += new System.EventHandler(this.txtTotalPagado_TextChanged);
            this.txtTotalPagado.Leave += new System.EventHandler(this.txtTotalPagado_Leave);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(9, 126);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(54, 13);
            this.lblEfectivo.TabIndex = 9;
            this.lblEfectivo.Text = "Efectivo";
            // 
            // lblVenc
            // 
            this.lblVenc.AutoSize = true;
            this.lblVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenc.Location = new System.Drawing.Point(269, 97);
            this.lblVenc.Name = "lblVenc";
            this.lblVenc.Size = new System.Drawing.Size(35, 13);
            this.lblVenc.TabIndex = 7;
            this.lblVenc.Text = "Venc.";
            // 
            // lblNOTargeta
            // 
            this.lblNOTargeta.AutoSize = true;
            this.lblNOTargeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOTargeta.Location = new System.Drawing.Point(25, 97);
            this.lblNOTargeta.Name = "lblNOTargeta";
            this.lblNOTargeta.Size = new System.Drawing.Size(67, 13);
            this.lblNOTargeta.TabIndex = 6;
            this.lblNOTargeta.Text = "No. Targeta:";
            // 
            // txtNoTargeta
            // 
            this.txtNoTargeta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNoTargeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoTargeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTargeta.Location = new System.Drawing.Point(98, 94);
            this.txtNoTargeta.Mask = "0000-0000-0000-0000";
            this.txtNoTargeta.Name = "txtNoTargeta";
            this.txtNoTargeta.Size = new System.Drawing.Size(164, 20);
            this.txtNoTargeta.TabIndex = 3;
            this.txtNoTargeta.TextChanged += new System.EventHandler(this.txtNoTargeta_TextChanged);
            // 
            // lblTargeta
            // 
            this.lblTargeta.AutoSize = true;
            this.lblTargeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargeta.Location = new System.Drawing.Point(9, 75);
            this.lblTargeta.Name = "lblTargeta";
            this.lblTargeta.Size = new System.Drawing.Size(51, 13);
            this.lblTargeta.TabIndex = 5;
            this.lblTargeta.Text = "Targeta";
            // 
            // lblNOCuenta
            // 
            this.lblNOCuenta.AutoSize = true;
            this.lblNOCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOCuenta.Location = new System.Drawing.Point(190, 47);
            this.lblNOCuenta.Name = "lblNOCuenta";
            this.lblNOCuenta.Size = new System.Drawing.Size(64, 13);
            this.lblNOCuenta.TabIndex = 4;
            this.lblNOCuenta.Text = "No. Cuenta:";
            // 
            // lblNORuta
            // 
            this.lblNORuta.AutoSize = true;
            this.lblNORuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNORuta.Location = new System.Drawing.Point(25, 47);
            this.lblNORuta.Name = "lblNORuta";
            this.lblNORuta.Size = new System.Drawing.Size(53, 13);
            this.lblNORuta.TabIndex = 2;
            this.lblNORuta.Text = "No. Ruta:";
            // 
            // txtNORuta
            // 
            this.txtNORuta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNORuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNORuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNORuta.Location = new System.Drawing.Point(84, 44);
            this.txtNORuta.Mask = "000000000";
            this.txtNORuta.Name = "txtNORuta";
            this.txtNORuta.Size = new System.Drawing.Size(100, 20);
            this.txtNORuta.TabIndex = 1;
            this.txtNORuta.TextChanged += new System.EventHandler(this.txtNORuta_TextChanged);
            // 
            // lblCheque
            // 
            this.lblCheque.AutoSize = true;
            this.lblCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheque.Location = new System.Drawing.Point(9, 26);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(50, 13);
            this.lblCheque.TabIndex = 0;
            this.lblCheque.Text = "Cheque";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(11, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(305, 443);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmConfirmacionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(446, 486);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbInformacionPago);
            this.Controls.Add(this.gbModoPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirmacionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmacionPago";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmConfirmacionPago_Load);
            this.gbModoPago.ResumeLayout(false);
            this.gbModoPago.PerformLayout();
            this.gbInformacionPago.ResumeLayout(false);
            this.gbInformacionPago.PerformLayout();
            this.gbTotalaPagar.ResumeLayout(false);
            this.gbTotalaPagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModoPago;
        private System.Windows.Forms.RadioButton rbTargeta;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.GroupBox gbInformacionPago;
        private System.Windows.Forms.Label lblTargeta;
        private System.Windows.Forms.Label lblNOCuenta;
        private System.Windows.Forms.Label lblNORuta;
        private System.Windows.Forms.MaskedTextBox txtNORuta;
        private System.Windows.Forms.Label lblCheque;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTotalPagado;
        private System.Windows.Forms.TextBox txtTotalPagado;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblVenc;
        private System.Windows.Forms.Label lblNOTargeta;
        private System.Windows.Forms.MaskedTextBox txtNoTargeta;
        private System.Windows.Forms.GroupBox gbTotalaPagar;
        private System.Windows.Forms.TextBox txtCantPagado;
        private System.Windows.Forms.Label lblCantPagado;
        private System.Windows.Forms.TextBox txtTotalPAgar;
        private System.Windows.Forms.Label lblTotalaPagar;
        private System.Windows.Forms.MaskedTextBox txtFechaVencTargeta;
        private System.Windows.Forms.Label lblTotalArticulos;
        private System.Windows.Forms.Label lblCantArticulos;
        private System.Windows.Forms.TextBox txtNOCuenta;
    }
}