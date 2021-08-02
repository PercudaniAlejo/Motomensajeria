
namespace UI
{
    partial class formDetallesEnvio
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMotoquero = new System.Windows.Forms.ComboBox();
            this.lblMotoquero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblPrecioViaje = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.numPrecioFinal = new System.Windows.Forms.NumericUpDown();
            this.numPrecioViaje = new System.Windows.Forms.NumericUpDown();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.checkFragil = new System.Windows.Forms.CheckBox();
            this.btnOkEnvio = new System.Windows.Forms.Button();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.txtApeCliente = new System.Windows.Forms.TextBox();
            this.lblApeClient = new System.Windows.Forms.Label();
            this.numCelCliente = new System.Windows.Forms.NumericUpDown();
            this.lblCelular = new System.Windows.Forms.Label();
            this.pnlMostrarDatosCliente = new System.Windows.Forms.Panel();
            this.pnlMostrarDatosEnvio = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCelCliente)).BeginInit();
            this.pnlMostrarDatosCliente.SuspendLayout();
            this.pnlMostrarDatosEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Datos del cliente";
            // 
            // cmbMotoquero
            // 
            this.cmbMotoquero.FormattingEnabled = true;
            this.cmbMotoquero.Location = new System.Drawing.Point(113, 177);
            this.cmbMotoquero.Name = "cmbMotoquero";
            this.cmbMotoquero.Size = new System.Drawing.Size(169, 21);
            this.cmbMotoquero.TabIndex = 36;
            // 
            // lblMotoquero
            // 
            this.lblMotoquero.AutoSize = true;
            this.lblMotoquero.BackColor = System.Drawing.Color.Transparent;
            this.lblMotoquero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMotoquero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMotoquero.Location = new System.Drawing.Point(19, 185);
            this.lblMotoquero.Name = "lblMotoquero";
            this.lblMotoquero.Size = new System.Drawing.Size(76, 17);
            this.lblMotoquero.TabIndex = 47;
            this.lblMotoquero.Text = "Motoquero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Datos del envio";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPrecioFinal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioFinal.Location = new System.Drawing.Point(19, 273);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(82, 17);
            this.lblPrecioFinal.TabIndex = 45;
            this.lblPrecioFinal.Text = "Precio Final";
            // 
            // lblPrecioViaje
            // 
            this.lblPrecioViaje.AutoSize = true;
            this.lblPrecioViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPrecioViaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioViaje.Location = new System.Drawing.Point(19, 228);
            this.lblPrecioViaje.Name = "lblPrecioViaje";
            this.lblPrecioViaje.Size = new System.Drawing.Size(106, 17);
            this.lblPrecioViaje.TabIndex = 44;
            this.lblPrecioViaje.Text = "Precio del Viaje";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblUnidades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUnidades.Location = new System.Drawing.Point(17, 143);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(68, 17);
            this.lblUnidades.TabIndex = 43;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocalidad.Location = new System.Drawing.Point(17, 97);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(69, 17);
            this.lblLocalidad.TabIndex = 42;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDomicilio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDomicilio.Location = new System.Drawing.Point(17, 56);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(64, 17);
            this.lblDomicilio.TabIndex = 40;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(19, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Fecha";
            // 
            // numPrecioFinal
            // 
            this.numPrecioFinal.Location = new System.Drawing.Point(128, 269);
            this.numPrecioFinal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPrecioFinal.Name = "numPrecioFinal";
            this.numPrecioFinal.Size = new System.Drawing.Size(91, 20);
            this.numPrecioFinal.TabIndex = 39;
            // 
            // numPrecioViaje
            // 
            this.numPrecioViaje.Location = new System.Drawing.Point(128, 224);
            this.numPrecioViaje.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPrecioViaje.Name = "numPrecioViaje";
            this.numPrecioViaje.Size = new System.Drawing.Size(91, 20);
            this.numPrecioViaje.TabIndex = 38;
            // 
            // numUnidades
            // 
            this.numUnidades.Location = new System.Drawing.Point(113, 136);
            this.numUnidades.Name = "numUnidades";
            this.numUnidades.Size = new System.Drawing.Size(106, 20);
            this.numUnidades.TabIndex = 35;
            this.numUnidades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(113, 90);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(169, 20);
            this.txtLocalidad.TabIndex = 34;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(113, 49);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(169, 20);
            this.txtDomicilio.TabIndex = 33;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(113, 8);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 20);
            this.dtpFecha.TabIndex = 32;
            this.dtpFecha.Value = new System.DateTime(2021, 7, 3, 0, 0, 0, 0);
            // 
            // checkFragil
            // 
            this.checkFragil.AutoSize = true;
            this.checkFragil.BackColor = System.Drawing.Color.Transparent;
            this.checkFragil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkFragil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkFragil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.checkFragil.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkFragil.Location = new System.Drawing.Point(128, 312);
            this.checkFragil.Name = "checkFragil";
            this.checkFragil.Size = new System.Drawing.Size(59, 21);
            this.checkFragil.TabIndex = 41;
            this.checkFragil.Text = "Fragil";
            this.checkFragil.UseVisualStyleBackColor = false;
            // 
            // btnOkEnvio
            // 
            this.btnOkEnvio.BackColor = System.Drawing.Color.Silver;
            this.btnOkEnvio.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOkEnvio.FlatAppearance.BorderSize = 0;
            this.btnOkEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnOkEnvio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOkEnvio.Location = new System.Drawing.Point(226, 601);
            this.btnOkEnvio.Name = "btnOkEnvio";
            this.btnOkEnvio.Size = new System.Drawing.Size(97, 36);
            this.btnOkEnvio.TabIndex = 48;
            this.btnOkEnvio.Text = "Aceptar";
            this.btnOkEnvio.UseVisualStyleBackColor = false;
            this.btnOkEnvio.Click += new System.EventHandler(this.btnOkEnvio_Click);
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(108, 9);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(169, 20);
            this.txtNomCliente.TabIndex = 25;
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNomCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomCliente.Location = new System.Drawing.Point(12, 12);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(58, 17);
            this.lblNomCliente.TabIndex = 29;
            this.lblNomCliente.Text = "Nombre";
            // 
            // txtApeCliente
            // 
            this.txtApeCliente.Location = new System.Drawing.Point(108, 50);
            this.txtApeCliente.Name = "txtApeCliente";
            this.txtApeCliente.Size = new System.Drawing.Size(169, 20);
            this.txtApeCliente.TabIndex = 26;
            // 
            // lblApeClient
            // 
            this.lblApeClient.AutoSize = true;
            this.lblApeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblApeClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApeClient.Location = new System.Drawing.Point(14, 57);
            this.lblApeClient.Name = "lblApeClient";
            this.lblApeClient.Size = new System.Drawing.Size(58, 17);
            this.lblApeClient.TabIndex = 30;
            this.lblApeClient.Text = "Apellido";
            // 
            // numCelCliente
            // 
            this.numCelCliente.Location = new System.Drawing.Point(108, 90);
            this.numCelCliente.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numCelCliente.Name = "numCelCliente";
            this.numCelCliente.Size = new System.Drawing.Size(169, 20);
            this.numCelCliente.TabIndex = 27;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCelular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCelular.Location = new System.Drawing.Point(14, 97);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(52, 17);
            this.lblCelular.TabIndex = 31;
            this.lblCelular.Text = "Celular";
            // 
            // pnlMostrarDatosCliente
            // 
            this.pnlMostrarDatosCliente.Controls.Add(this.lblCelular);
            this.pnlMostrarDatosCliente.Controls.Add(this.numCelCliente);
            this.pnlMostrarDatosCliente.Controls.Add(this.lblApeClient);
            this.pnlMostrarDatosCliente.Controls.Add(this.txtApeCliente);
            this.pnlMostrarDatosCliente.Controls.Add(this.lblNomCliente);
            this.pnlMostrarDatosCliente.Controls.Add(this.txtNomCliente);
            this.pnlMostrarDatosCliente.Enabled = false;
            this.pnlMostrarDatosCliente.Location = new System.Drawing.Point(31, 58);
            this.pnlMostrarDatosCliente.Name = "pnlMostrarDatosCliente";
            this.pnlMostrarDatosCliente.Size = new System.Drawing.Size(292, 122);
            this.pnlMostrarDatosCliente.TabIndex = 49;
            // 
            // pnlMostrarDatosEnvio
            // 
            this.pnlMostrarDatosEnvio.Controls.Add(this.cmbMotoquero);
            this.pnlMostrarDatosEnvio.Controls.Add(this.lblMotoquero);
            this.pnlMostrarDatosEnvio.Controls.Add(this.lblPrecioFinal);
            this.pnlMostrarDatosEnvio.Controls.Add(this.lblPrecioViaje);
            this.pnlMostrarDatosEnvio.Controls.Add(this.lblUnidades);
            this.pnlMostrarDatosEnvio.Controls.Add(this.lblLocalidad);
            this.pnlMostrarDatosEnvio.Controls.Add(this.lblDomicilio);
            this.pnlMostrarDatosEnvio.Controls.Add(this.lblFecha);
            this.pnlMostrarDatosEnvio.Controls.Add(this.numPrecioFinal);
            this.pnlMostrarDatosEnvio.Controls.Add(this.numPrecioViaje);
            this.pnlMostrarDatosEnvio.Controls.Add(this.numUnidades);
            this.pnlMostrarDatosEnvio.Controls.Add(this.txtLocalidad);
            this.pnlMostrarDatosEnvio.Controls.Add(this.txtDomicilio);
            this.pnlMostrarDatosEnvio.Controls.Add(this.dtpFecha);
            this.pnlMostrarDatosEnvio.Controls.Add(this.checkFragil);
            this.pnlMostrarDatosEnvio.Enabled = false;
            this.pnlMostrarDatosEnvio.Location = new System.Drawing.Point(31, 239);
            this.pnlMostrarDatosEnvio.Name = "pnlMostrarDatosEnvio";
            this.pnlMostrarDatosEnvio.Size = new System.Drawing.Size(292, 345);
            this.pnlMostrarDatosEnvio.TabIndex = 50;
            // 
            // formDetallesEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(354, 691);
            this.Controls.Add(this.pnlMostrarDatosEnvio);
            this.Controls.Add(this.pnlMostrarDatosCliente);
            this.Controls.Add(this.btnOkEnvio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(370, 730);
            this.MinimumSize = new System.Drawing.Size(370, 730);
            this.Name = "formDetallesEnvio";
            this.Text = "formDetallesEnvio";
            this.Load += new System.EventHandler(this.formDetallesEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCelCliente)).EndInit();
            this.pnlMostrarDatosCliente.ResumeLayout(false);
            this.pnlMostrarDatosCliente.PerformLayout();
            this.pnlMostrarDatosEnvio.ResumeLayout(false);
            this.pnlMostrarDatosEnvio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMotoquero;
        private System.Windows.Forms.Label lblMotoquero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblPrecioViaje;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.NumericUpDown numPrecioFinal;
        private System.Windows.Forms.NumericUpDown numPrecioViaje;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox checkFragil;
        private System.Windows.Forms.Button btnOkEnvio;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.TextBox txtApeCliente;
        private System.Windows.Forms.Label lblApeClient;
        private System.Windows.Forms.NumericUpDown numCelCliente;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Panel pnlMostrarDatosCliente;
        private System.Windows.Forms.Panel pnlMostrarDatosEnvio;
    }
}