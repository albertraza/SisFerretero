namespace SisFerretero
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.pOcultar = new System.Windows.Forms.Panel();
            this.lblOcultar = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.pCerrar.SuspendLayout();
            this.pOcultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnaceptar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 274);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Cliente";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(330, 90);
            this.txtCelular.Mask = "(000) 000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(102, 22);
            this.txtCelular.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Celular:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(365, 206);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 40);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(261, 206);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 40);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(140, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 40);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Busqueda Avanzada";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(46, 206);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 40);
            this.btnaceptar.TabIndex = 11;
            this.btnaceptar.Text = "Registrar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(114, 122);
            this.txtTelefono.Mask = "(000) 000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(102, 22);
            this.txtTelefono.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Location = new System.Drawing.Point(329, 55);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(124, 22);
            this.txtCedula.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.Location = new System.Drawing.Point(107, 155);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(383, 22);
            this.txtdireccion.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapellido.Location = new System.Drawing.Point(96, 89);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(133, 22);
            this.txtapellido.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cedula:";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Location = new System.Drawing.Point(96, 52);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(133, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Clientes";
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(479, 25);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(81, 37);
            this.pCerrar.TabIndex = 15;
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
            this.pOcultar.Location = new System.Drawing.Point(392, 25);
            this.pOcultar.Name = "pOcultar";
            this.pOcultar.Size = new System.Drawing.Size(81, 37);
            this.pOcultar.TabIndex = 14;
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
            // Clientes
            // 
            this.AcceptButton = this.btnaceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.lblCerrar;
            this.ClientSize = new System.Drawing.Size(602, 424);
            this.Controls.Add(this.pCerrar);
            this.Controls.Add(this.pOcultar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.pOcultar.ResumeLayout(false);
            this.pOcultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.Panel pOcultar;
        private System.Windows.Forms.LinkLabel lblOcultar;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
    }
}