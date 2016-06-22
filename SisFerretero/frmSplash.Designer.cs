namespace SisFerretero
{
    partial class frmSplash
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
            this.tContador = new System.Windows.Forms.Timer(this.components);
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tContador
            // 
            this.tContador.Tick += new System.EventHandler(this.tContador_Tick);
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(-1, 252);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(666, 10);
            this.pbProgreso.TabIndex = 0;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 261);
            this.Controls.Add(this.pbProgreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tContador;
        private System.Windows.Forms.ProgressBar pbProgreso;
    }
}