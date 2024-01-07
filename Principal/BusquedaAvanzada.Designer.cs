namespace Principal
{
    partial class Busqueda_avanzada
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
            this.lblPrecioBA = new System.Windows.Forms.Label();
            this.lblMarcaBA = new System.Windows.Forms.Label();
            this.lblCategoriaBA = new System.Windows.Forms.Label();
            this.cmbPrecioBA = new System.Windows.Forms.ComboBox();
            this.cmbMarcaBA = new System.Windows.Forms.ComboBox();
            this.txtPrecioBA = new System.Windows.Forms.TextBox();
            this.cmbCategoriaBA = new System.Windows.Forms.ComboBox();
            this.lblNombreBA = new System.Windows.Forms.Label();
            this.cmbNombreBA = new System.Windows.Forms.ComboBox();
            this.txtNombreBA = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrecioBA
            // 
            this.lblPrecioBA.AutoSize = true;
            this.lblPrecioBA.Location = new System.Drawing.Point(12, 71);
            this.lblPrecioBA.Name = "lblPrecioBA";
            this.lblPrecioBA.Size = new System.Drawing.Size(46, 16);
            this.lblPrecioBA.TabIndex = 0;
            this.lblPrecioBA.Text = "Precio";
            // 
            // lblMarcaBA
            // 
            this.lblMarcaBA.AutoSize = true;
            this.lblMarcaBA.Location = new System.Drawing.Point(13, 121);
            this.lblMarcaBA.Name = "lblMarcaBA";
            this.lblMarcaBA.Size = new System.Drawing.Size(45, 16);
            this.lblMarcaBA.TabIndex = 1;
            this.lblMarcaBA.Text = "Marca";
            // 
            // lblCategoriaBA
            // 
            this.lblCategoriaBA.AutoSize = true;
            this.lblCategoriaBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaBA.Location = new System.Drawing.Point(3, 172);
            this.lblCategoriaBA.Name = "lblCategoriaBA";
            this.lblCategoriaBA.Size = new System.Drawing.Size(60, 15);
            this.lblCategoriaBA.TabIndex = 2;
            this.lblCategoriaBA.Text = "Categoria";
            // 
            // cmbPrecioBA
            // 
            this.cmbPrecioBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrecioBA.FormattingEnabled = true;
            this.cmbPrecioBA.Location = new System.Drawing.Point(75, 71);
            this.cmbPrecioBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPrecioBA.Name = "cmbPrecioBA";
            this.cmbPrecioBA.Size = new System.Drawing.Size(103, 24);
            this.cmbPrecioBA.TabIndex = 3;
            // 
            // cmbMarcaBA
            // 
            this.cmbMarcaBA.FormattingEnabled = true;
            this.cmbMarcaBA.Location = new System.Drawing.Point(75, 118);
            this.cmbMarcaBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMarcaBA.Name = "cmbMarcaBA";
            this.cmbMarcaBA.Size = new System.Drawing.Size(220, 24);
            this.cmbMarcaBA.TabIndex = 4;
            // 
            // txtPrecioBA
            // 
            this.txtPrecioBA.Location = new System.Drawing.Point(183, 71);
            this.txtPrecioBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioBA.Name = "txtPrecioBA";
            this.txtPrecioBA.Size = new System.Drawing.Size(111, 22);
            this.txtPrecioBA.TabIndex = 5;
            this.txtPrecioBA.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecioBA_Validating);
            this.txtPrecioBA.Validated += new System.EventHandler(this.txtPrecioBA_Validated);
            // 
            // cmbCategoriaBA
            // 
            this.cmbCategoriaBA.FormattingEnabled = true;
            this.cmbCategoriaBA.Location = new System.Drawing.Point(75, 169);
            this.cmbCategoriaBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoriaBA.Name = "cmbCategoriaBA";
            this.cmbCategoriaBA.Size = new System.Drawing.Size(220, 24);
            this.cmbCategoriaBA.TabIndex = 8;
            // 
            // lblNombreBA
            // 
            this.lblNombreBA.AutoSize = true;
            this.lblNombreBA.Location = new System.Drawing.Point(13, 226);
            this.lblNombreBA.Name = "lblNombreBA";
            this.lblNombreBA.Size = new System.Drawing.Size(56, 16);
            this.lblNombreBA.TabIndex = 9;
            this.lblNombreBA.Text = "Nombre";
            // 
            // cmbNombreBA
            // 
            this.cmbNombreBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreBA.FormattingEnabled = true;
            this.cmbNombreBA.Location = new System.Drawing.Point(75, 220);
            this.cmbNombreBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNombreBA.Name = "cmbNombreBA";
            this.cmbNombreBA.Size = new System.Drawing.Size(103, 24);
            this.cmbNombreBA.TabIndex = 10;
            // 
            // txtNombreBA
            // 
            this.txtNombreBA.Location = new System.Drawing.Point(183, 220);
            this.txtNombreBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreBA.Name = "txtNombreBA";
            this.txtNombreBA.Size = new System.Drawing.Size(112, 22);
            this.txtNombreBA.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(52, 295);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 33);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(175, 295);
            this.btnCancelarBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(107, 33);
            this.btnCancelarBusqueda.TabIndex = 13;
            this.btnCancelarBusqueda.Text = "Cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            // 
            // Busqueda_avanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 358);
            this.Controls.Add(this.btnCancelarBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreBA);
            this.Controls.Add(this.cmbNombreBA);
            this.Controls.Add(this.lblNombreBA);
            this.Controls.Add(this.cmbCategoriaBA);
            this.Controls.Add(this.txtPrecioBA);
            this.Controls.Add(this.cmbMarcaBA);
            this.Controls.Add(this.cmbPrecioBA);
            this.Controls.Add(this.lblCategoriaBA);
            this.Controls.Add(this.lblMarcaBA);
            this.Controls.Add(this.lblPrecioBA);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Busqueda_avanzada";
            this.Text = "Busqueda_avanzada";
            this.Load += new System.EventHandler(this.Busqueda_avanzada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioBA;
        private System.Windows.Forms.Label lblMarcaBA;
        private System.Windows.Forms.Label lblCategoriaBA;
        private System.Windows.Forms.ComboBox cmbPrecioBA;
        private System.Windows.Forms.ComboBox cmbMarcaBA;
        private System.Windows.Forms.TextBox txtPrecioBA;
        private System.Windows.Forms.ComboBox cmbCategoriaBA;
        private System.Windows.Forms.Label lblNombreBA;
        private System.Windows.Forms.ComboBox cmbNombreBA;
        private System.Windows.Forms.TextBox txtNombreBA;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelarBusqueda;
    }
}