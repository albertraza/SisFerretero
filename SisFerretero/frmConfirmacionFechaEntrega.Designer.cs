namespace SisFerretero
{
    partial class frmConfirmacionFechaEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmacionFechaEntrega));
            this.gbEnvioDomicilio = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.gbFechaEntrega = new System.Windows.Forms.GroupBox();
            this.txtFechaEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbEnvioDomicilio.SuspendLayout();
            this.gbFechaEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEnvioDomicilio
            // 
            this.gbEnvioDomicilio.BackColor = System.Drawing.Color.LightGray;
            this.gbEnvioDomicilio.Controls.Add(this.rbNo);
            this.gbEnvioDomicilio.Controls.Add(this.rbSi);
            this.gbEnvioDomicilio.Location = new System.Drawing.Point(249, 33);
            this.gbEnvioDomicilio.Name = "gbEnvioDomicilio";
            this.gbEnvioDomicilio.Size = new System.Drawing.Size(136, 51);
            this.gbEnvioDomicilio.TabIndex = 2;
            this.gbEnvioDomicilio.TabStop = false;
            this.gbEnvioDomicilio.Text = "Se enviara a domicilio?";
            this.gbEnvioDomicilio.Enter += new System.EventHandler(this.gbEnvioDomicilio_Enter);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbNo.Location = new System.Drawing.Point(82, 19);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(38, 17);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSi.Location = new System.Drawing.Point(18, 19);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(33, 17);
            this.rbSi.TabIndex = 0;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // gbFechaEntrega
            // 
            this.gbFechaEntrega.BackColor = System.Drawing.Color.LightGray;
            this.gbFechaEntrega.Controls.Add(this.txtFechaEntrega);
            this.gbFechaEntrega.Controls.Add(this.label1);
            this.gbFechaEntrega.Location = new System.Drawing.Point(23, 33);
            this.gbFechaEntrega.Name = "gbFechaEntrega";
            this.gbFechaEntrega.Size = new System.Drawing.Size(200, 79);
            this.gbFechaEntrega.TabIndex = 2;
            this.gbFechaEntrega.TabStop = false;
            this.gbFechaEntrega.Text = "Fecha Entrega";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaEntrega.Location = new System.Drawing.Point(12, 43);
            this.txtFechaEntrega.Mask = "00/00/0000";
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(180, 20);
            this.txtFechaEntrega.TabIndex = 4;
            this.txtFechaEntrega.TextChanged += new System.EventHandler(this.txtFechaEntrega_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite la fecha de Entrega:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(331, 91);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmConfirmacionFechaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(427, 126);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbFechaEntrega);
            this.Controls.Add(this.gbEnvioDomicilio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirmacionFechaEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmacionFechaEntrega";
            this.TransparencyKey = System.Drawing.Color.White;
            this.gbEnvioDomicilio.ResumeLayout(false);
            this.gbEnvioDomicilio.PerformLayout();
            this.gbFechaEntrega.ResumeLayout(false);
            this.gbFechaEntrega.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEnvioDomicilio;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.GroupBox gbFechaEntrega;
        private System.Windows.Forms.MaskedTextBox txtFechaEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}