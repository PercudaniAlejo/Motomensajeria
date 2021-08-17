
namespace UI
{
    partial class formNuevoViaje
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.numPrecioViaje = new System.Windows.Forms.NumericUpDown();
            this.numPrecioFinal = new System.Windows.Forms.NumericUpDown();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblPrecioViaje = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTituloViajes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lblApeClient = new System.Windows.Forms.Label();
            this.txtApeCliente = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.numCelCliente = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMotoquero = new System.Windows.Forms.Label();
            this.cmbMotoquero = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCelCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // checkFragil
            // 
            this.checkFragil.AutoSize = true;
            this.checkFragil.BackColor = System.Drawing.Color.Transparent;
            this.checkFragil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkFragil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkFragil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.checkFragil.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkFragil.Location = new System.Drawing.Point(160, 575);
            this.checkFragil.Name = "checkFragil";
            this.checkFragil.Size = new System.Drawing.Size(59, 21);
            this.checkFragil.TabIndex = 11;
            this.checkFragil.Text = "Fragil";
            this.checkFragil.UseVisualStyleBackColor = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(145, 271);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2021, 8, 3, 0, 0, 0, 0);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(145, 312);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(169, 20);
            this.txtDomicilio.TabIndex = 5;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(145, 353);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(169, 20);
            this.txtLocalidad.TabIndex = 6;
            // 
            // numUnidades
            // 
            this.numUnidades.Location = new System.Drawing.Point(145, 399);
            this.numUnidades.Name = "numUnidades";
            this.numUnidades.Size = new System.Drawing.Size(106, 20);
            this.numUnidades.TabIndex = 7;
            this.numUnidades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPrecioViaje
            // 
            this.numPrecioViaje.Location = new System.Drawing.Point(160, 487);
            this.numPrecioViaje.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPrecioViaje.Name = "numPrecioViaje";
            this.numPrecioViaje.Size = new System.Drawing.Size(91, 20);
            this.numPrecioViaje.TabIndex = 9;
            // 
            // numPrecioFinal
            // 
            this.numPrecioFinal.Location = new System.Drawing.Point(160, 532);
            this.numPrecioFinal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPrecioFinal.Name = "numPrecioFinal";
            this.numPrecioFinal.Size = new System.Drawing.Size(91, 20);
            this.numPrecioFinal.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(51, 278);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDomicilio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDomicilio.Location = new System.Drawing.Point(49, 319);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(64, 17);
            this.lblDomicilio.TabIndex = 11;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocalidad.Location = new System.Drawing.Point(49, 360);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(69, 17);
            this.lblLocalidad.TabIndex = 12;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblUnidades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUnidades.Location = new System.Drawing.Point(49, 406);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(68, 17);
            this.lblUnidades.TabIndex = 13;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblPrecioViaje
            // 
            this.lblPrecioViaje.AutoSize = true;
            this.lblPrecioViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPrecioViaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioViaje.Location = new System.Drawing.Point(51, 491);
            this.lblPrecioViaje.Name = "lblPrecioViaje";
            this.lblPrecioViaje.Size = new System.Drawing.Size(106, 17);
            this.lblPrecioViaje.TabIndex = 14;
            this.lblPrecioViaje.Text = "Precio del Viaje";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPrecioFinal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioFinal.Location = new System.Drawing.Point(51, 536);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(82, 17);
            this.lblPrecioFinal.TabIndex = 15;
            this.lblPrecioFinal.Text = "Precio Final";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(196, 615);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 33);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTituloViajes
            // 
            this.lblTituloViajes.AutoSize = true;
            this.lblTituloViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloViajes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloViajes.Location = new System.Drawing.Point(15, 18);
            this.lblTituloViajes.Name = "lblTituloViajes";
            this.lblTituloViajes.Size = new System.Drawing.Size(127, 20);
            this.lblTituloViajes.TabIndex = 17;
            this.lblTituloViajes.Text = "NUEVO VIAJE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Datos del cliente";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNomCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomCliente.Location = new System.Drawing.Point(49, 106);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(58, 17);
            this.lblNomCliente.TabIndex = 20;
            this.lblNomCliente.Text = "Nombre";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(145, 103);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(169, 20);
            this.txtNomCliente.TabIndex = 1;
            // 
            // lblApeClient
            // 
            this.lblApeClient.AutoSize = true;
            this.lblApeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblApeClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApeClient.Location = new System.Drawing.Point(51, 151);
            this.lblApeClient.Name = "lblApeClient";
            this.lblApeClient.Size = new System.Drawing.Size(58, 17);
            this.lblApeClient.TabIndex = 22;
            this.lblApeClient.Text = "Apellido";
            // 
            // txtApeCliente
            // 
            this.txtApeCliente.Location = new System.Drawing.Point(145, 144);
            this.txtApeCliente.Name = "txtApeCliente";
            this.txtApeCliente.Size = new System.Drawing.Size(169, 20);
            this.txtApeCliente.TabIndex = 2;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCelular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCelular.Location = new System.Drawing.Point(51, 191);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(52, 17);
            this.lblCelular.TabIndex = 24;
            this.lblCelular.Text = "Celular";
            // 
            // numCelCliente
            // 
            this.numCelCliente.Location = new System.Drawing.Point(145, 184);
            this.numCelCliente.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numCelCliente.Name = "numCelCliente";
            this.numCelCliente.Size = new System.Drawing.Size(169, 20);
            this.numCelCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Datos del envio";
            // 
            // lblMotoquero
            // 
            this.lblMotoquero.AutoSize = true;
            this.lblMotoquero.BackColor = System.Drawing.Color.Transparent;
            this.lblMotoquero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMotoquero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMotoquero.Location = new System.Drawing.Point(51, 448);
            this.lblMotoquero.Name = "lblMotoquero";
            this.lblMotoquero.Size = new System.Drawing.Size(76, 17);
            this.lblMotoquero.TabIndex = 26;
            this.lblMotoquero.Text = "Motoquero";
            // 
            // cmbMotoquero
            // 
            this.cmbMotoquero.FormattingEnabled = true;
            this.cmbMotoquero.Location = new System.Drawing.Point(145, 440);
            this.cmbMotoquero.Name = "cmbMotoquero";
            this.cmbMotoquero.Size = new System.Drawing.Size(169, 21);
            this.cmbMotoquero.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(54, 615);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 33);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formNuevoViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(354, 692);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbMotoquero);
            this.Controls.Add(this.lblMotoquero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.numCelCliente);
            this.Controls.Add(this.lblApeClient);
            this.Controls.Add(this.txtApeCliente);
            this.Controls.Add(this.lblNomCliente);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloViajes);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblPrecioViaje);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.numPrecioFinal);
            this.Controls.Add(this.numPrecioViaje);
            this.Controls.Add(this.numUnidades);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.checkFragil);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinimumSize = new System.Drawing.Size(370, 730);
            this.Name = "formNuevoViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo viaje";
            this.Load += new System.EventHandler(this.formNuevoViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCelCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkFragil;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.NumericUpDown numPrecioViaje;
        private System.Windows.Forms.NumericUpDown numPrecioFinal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblPrecioViaje;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTituloViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label lblApeClient;
        private System.Windows.Forms.TextBox txtApeCliente;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.NumericUpDown numCelCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMotoquero;
        private System.Windows.Forms.ComboBox cmbMotoquero;
        private System.Windows.Forms.Button btnCancelar;
    }
}

