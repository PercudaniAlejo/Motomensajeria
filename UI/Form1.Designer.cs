
namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkFragil = new System.Windows.Forms.CheckBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.numPrecioViaje = new System.Windows.Forms.NumericUpDown();
            this.numPrecioFinal = new System.Windows.Forms.NumericUpDown();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblPrecioViaje = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.btnOkEnvio = new System.Windows.Forms.Button();
            this.lblTituloViajes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // checkFragil
            // 
            this.checkFragil.AutoCheck = false;
            this.checkFragil.AutoSize = true;
            this.checkFragil.Location = new System.Drawing.Point(143, 352);
            this.checkFragil.Name = "checkFragil";
            this.checkFragil.Size = new System.Drawing.Size(51, 17);
            this.checkFragil.TabIndex = 8;
            this.checkFragil.Text = "Fragil";
            this.checkFragil.UseVisualStyleBackColor = true;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(112, 104);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(169, 21);
            this.cmbCliente.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(112, 63);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2021, 7, 3, 0, 0, 0, 0);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(112, 146);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(169, 20);
            this.txtDomicilio.TabIndex = 3;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(112, 187);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(169, 20);
            this.txtLocalidad.TabIndex = 4;
            // 
            // numUnidades
            // 
            this.numUnidades.Location = new System.Drawing.Point(112, 233);
            this.numUnidades.Name = "numUnidades";
            this.numUnidades.Size = new System.Drawing.Size(82, 20);
            this.numUnidades.TabIndex = 5;
            this.numUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUnidades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPrecioViaje
            // 
            this.numPrecioViaje.Location = new System.Drawing.Point(112, 269);
            this.numPrecioViaje.Name = "numPrecioViaje";
            this.numPrecioViaje.Size = new System.Drawing.Size(82, 20);
            this.numPrecioViaje.TabIndex = 6;
            this.numPrecioViaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numPrecioFinal
            // 
            this.numPrecioFinal.Location = new System.Drawing.Point(112, 310);
            this.numPrecioFinal.Name = "numPrecioFinal";
            this.numPrecioFinal.Size = new System.Drawing.Size(82, 20);
            this.numPrecioFinal.TabIndex = 7;
            this.numPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 112);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(16, 153);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 11;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(16, 194);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 12;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(16, 240);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(52, 13);
            this.lblUnidades.TabIndex = 13;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblPrecioViaje
            // 
            this.lblPrecioViaje.AutoSize = true;
            this.lblPrecioViaje.Location = new System.Drawing.Point(16, 276);
            this.lblPrecioViaje.Name = "lblPrecioViaje";
            this.lblPrecioViaje.Size = new System.Drawing.Size(80, 13);
            this.lblPrecioViaje.TabIndex = 14;
            this.lblPrecioViaje.Text = "Precio del Viaje";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(16, 317);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(62, 13);
            this.lblPrecioFinal.TabIndex = 15;
            this.lblPrecioFinal.Text = "Precio Final";
            // 
            // btnOkEnvio
            // 
            this.btnOkEnvio.Location = new System.Drawing.Point(143, 385);
            this.btnOkEnvio.Name = "btnOkEnvio";
            this.btnOkEnvio.Size = new System.Drawing.Size(138, 40);
            this.btnOkEnvio.TabIndex = 16;
            this.btnOkEnvio.Text = "Registrar Envio";
            this.btnOkEnvio.UseVisualStyleBackColor = true;
            // 
            // lblTituloViajes
            // 
            this.lblTituloViajes.AutoSize = true;
            this.lblTituloViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloViajes.Location = new System.Drawing.Point(15, 18);
            this.lblTituloViajes.Name = "lblTituloViajes";
            this.lblTituloViajes.Size = new System.Drawing.Size(127, 20);
            this.lblTituloViajes.TabIndex = 17;
            this.lblTituloViajes.Text = "NUEVO VIAJE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 454);
            this.Controls.Add(this.lblTituloViajes);
            this.Controls.Add(this.btnOkEnvio);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblPrecioViaje);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.numPrecioFinal);
            this.Controls.Add(this.numPrecioViaje);
            this.Controls.Add(this.numUnidades);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.checkFragil);
            this.MaximumSize = new System.Drawing.Size(327, 493);
            this.MinimumSize = new System.Drawing.Size(327, 493);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkFragil;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.NumericUpDown numPrecioViaje;
        private System.Windows.Forms.NumericUpDown numPrecioFinal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblPrecioViaje;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Button btnOkEnvio;
        private System.Windows.Forms.Label lblTituloViajes;
    }
}

