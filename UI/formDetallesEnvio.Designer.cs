
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
            this.cmbMotoquero = new System.Windows.Forms.ComboBox();
            this.numPrecioFinal = new System.Windows.Forms.NumericUpDown();
            this.numPrecioViaje = new System.Windows.Forms.NumericUpDown();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.checkFragil = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOkEnvio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCelCliente = new System.Windows.Forms.NumericUpDown();
            this.txtApeCliente = new System.Windows.Forms.TextBox();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.pnlMostrarDatosCliente = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCelCliente)).BeginInit();
            this.pnlMostrarDatosCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMotoquero
            // 
            this.cmbMotoquero.FormattingEnabled = true;
            this.cmbMotoquero.Location = new System.Drawing.Point(8, 177);
            this.cmbMotoquero.Name = "cmbMotoquero";
            this.cmbMotoquero.Size = new System.Drawing.Size(169, 21);
            this.cmbMotoquero.TabIndex = 36;
            // 
            // numPrecioFinal
            // 
            this.numPrecioFinal.Location = new System.Drawing.Point(8, 268);
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
            this.numPrecioViaje.Location = new System.Drawing.Point(8, 223);
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
            this.numUnidades.Location = new System.Drawing.Point(8, 135);
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
            this.txtLocalidad.Location = new System.Drawing.Point(8, 89);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(169, 20);
            this.txtLocalidad.TabIndex = 34;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(8, 48);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(169, 20);
            this.txtDomicilio.TabIndex = 33;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(8, 7);
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
            this.checkFragil.Location = new System.Drawing.Point(8, 310);
            this.checkFragil.Name = "checkFragil";
            this.checkFragil.Size = new System.Drawing.Size(59, 21);
            this.checkFragil.TabIndex = 41;
            this.checkFragil.Text = "Fragil";
            this.checkFragil.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(43, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Motoquero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(42, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Precio Final";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(16, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Precio del Viaje";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(57, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Unidades";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(55, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Localidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(55, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Domicilio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(81, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 51;
            this.label14.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(21, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "Datos del envio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(21, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "Datos del cliente";
            // 
            // btnOkEnvio
            // 
            this.btnOkEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOkEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnOkEnvio.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOkEnvio.FlatAppearance.BorderSize = 0;
            this.btnOkEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkEnvio.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnOkEnvio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOkEnvio.Location = new System.Drawing.Point(190, 623);
            this.btnOkEnvio.Name = "btnOkEnvio";
            this.btnOkEnvio.Size = new System.Drawing.Size(123, 42);
            this.btnOkEnvio.TabIndex = 63;
            this.btnOkEnvio.Text = "Aceptar";
            this.btnOkEnvio.UseVisualStyleBackColor = false;
            this.btnOkEnvio.Click += new System.EventHandler(this.btnOkEnvio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(65, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(71, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(61, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Apellido";
            // 
            // numCelCliente
            // 
            this.numCelCliente.Location = new System.Drawing.Point(11, 90);
            this.numCelCliente.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numCelCliente.Name = "numCelCliente";
            this.numCelCliente.Size = new System.Drawing.Size(169, 20);
            this.numCelCliente.TabIndex = 64;
            // 
            // txtApeCliente
            // 
            this.txtApeCliente.Location = new System.Drawing.Point(11, 48);
            this.txtApeCliente.Name = "txtApeCliente";
            this.txtApeCliente.Size = new System.Drawing.Size(169, 20);
            this.txtApeCliente.TabIndex = 63;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(11, 6);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(169, 20);
            this.txtNomCliente.TabIndex = 62;
            // 
            // pnlMostrarDatosCliente
            // 
            this.pnlMostrarDatosCliente.Controls.Add(this.numCelCliente);
            this.pnlMostrarDatosCliente.Controls.Add(this.txtApeCliente);
            this.pnlMostrarDatosCliente.Controls.Add(this.txtNomCliente);
            this.pnlMostrarDatosCliente.Enabled = false;
            this.pnlMostrarDatosCliente.Location = new System.Drawing.Point(133, 74);
            this.pnlMostrarDatosCliente.Name = "pnlMostrarDatosCliente";
            this.pnlMostrarDatosCliente.Size = new System.Drawing.Size(189, 124);
            this.pnlMostrarDatosCliente.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMotoquero);
            this.panel1.Controls.Add(this.numPrecioFinal);
            this.panel1.Controls.Add(this.numPrecioViaje);
            this.panel1.Controls.Add(this.numUnidades);
            this.panel1.Controls.Add(this.txtLocalidad);
            this.panel1.Controls.Add(this.txtDomicilio);
            this.panel1.Controls.Add(this.checkFragil);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(136, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 341);
            this.panel1.TabIndex = 66;
            // 
            // formDetallesEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(354, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlMostrarDatosCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOkEnvio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.MaximumSize = new System.Drawing.Size(370, 730);
            this.MinimumSize = new System.Drawing.Size(370, 730);
            this.Name = "formDetallesEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del envío";
            this.Load += new System.EventHandler(this.formDetallesEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCelCliente)).EndInit();
            this.pnlMostrarDatosCliente.ResumeLayout(false);
            this.pnlMostrarDatosCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMotoquero;
        private System.Windows.Forms.NumericUpDown numPrecioFinal;
        private System.Windows.Forms.NumericUpDown numPrecioViaje;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox checkFragil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOkEnvio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCelCliente;
        private System.Windows.Forms.TextBox txtApeCliente;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Panel pnlMostrarDatosCliente;
        private System.Windows.Forms.Panel panel1;
    }
}