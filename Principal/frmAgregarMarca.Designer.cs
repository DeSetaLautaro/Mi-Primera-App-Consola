namespace Principal
{
    partial class frmAgregarMarca
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
            this.lblAgregarMarcaAM = new System.Windows.Forms.Label();
            this.txtNuevaMarca = new System.Windows.Forms.TextBox();
            this.btnAceptarAM = new System.Windows.Forms.Button();
            this.btnCancelarAM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregarMarcaAM
            // 
            this.lblAgregarMarcaAM.AutoSize = true;
            this.lblAgregarMarcaAM.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarMarcaAM.Location = new System.Drawing.Point(10, 40);
            this.lblAgregarMarcaAM.Name = "lblAgregarMarcaAM";
            this.lblAgregarMarcaAM.Size = new System.Drawing.Size(92, 16);
            this.lblAgregarMarcaAM.TabIndex = 0;
            this.lblAgregarMarcaAM.Text = "Agregar Marca";
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.Location = new System.Drawing.Point(119, 37);
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(244, 22);
            this.txtNuevaMarca.TabIndex = 1;
            // 
            // btnAceptarAM
            // 
            this.btnAceptarAM.Location = new System.Drawing.Point(105, 80);
            this.btnAceptarAM.Name = "btnAceptarAM";
            this.btnAceptarAM.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAM.TabIndex = 2;
            this.btnAceptarAM.Text = "Aceptar";
            this.btnAceptarAM.UseVisualStyleBackColor = true;
            this.btnAceptarAM.Click += new System.EventHandler(this.btnAceptarAM_Click);
            // 
            // btnCancelarAM
            // 
            this.btnCancelarAM.Location = new System.Drawing.Point(203, 80);
            this.btnCancelarAM.Name = "btnCancelarAM";
            this.btnCancelarAM.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAM.TabIndex = 3;
            this.btnCancelarAM.Text = "Cancelar";
            this.btnCancelarAM.UseVisualStyleBackColor = true;
            this.btnCancelarAM.Click += new System.EventHandler(this.btnCancelarAM_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 107);
            this.Controls.Add(this.btnCancelarAM);
            this.Controls.Add(this.btnAceptarAM);
            this.Controls.Add(this.txtNuevaMarca);
            this.Controls.Add(this.lblAgregarMarcaAM);
            this.Name = "frmAgregarMarca";
            this.Text = "frmAgregarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarMarcaAM;
        private System.Windows.Forms.TextBox txtNuevaMarca;
        private System.Windows.Forms.Button btnAceptarAM;
        private System.Windows.Forms.Button btnCancelarAM;
    }
}