
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.numPrecioViaje = new System.Windows.Forms.NumericUpDown();
            this.numPrecioFinal = new System.Windows.Forms.NumericUpDown();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblPrecioViaje = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.chkNuevoCliente = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlNuevoCliente = new System.Windows.Forms.Panel();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.btnAgregarMoto = new System.Windows.Forms.Button();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.checkFragil = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCelCliente)).BeginInit();
            this.pnlNuevoCliente.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(145, 287);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2021, 8, 3, 0, 0, 0, 0);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomicilio.Location = new System.Drawing.Point(145, 325);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(169, 20);
            this.txtDomicilio.TabIndex = 5;
            // 
            // numUnidades
            // 
            this.numUnidades.Location = new System.Drawing.Point(145, 411);
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
            this.numPrecioViaje.Location = new System.Drawing.Point(160, 499);
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
            this.numPrecioFinal.Location = new System.Drawing.Point(160, 541);
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
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(41, 289);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 20);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblDomicilio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDomicilio.Location = new System.Drawing.Point(39, 327);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(74, 20);
            this.lblDomicilio.TabIndex = 11;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocalidad.Location = new System.Drawing.Point(39, 368);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(74, 20);
            this.lblLocalidad.TabIndex = 12;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblUnidades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUnidades.Location = new System.Drawing.Point(39, 414);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(72, 20);
            this.lblUnidades.TabIndex = 13;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblPrecioViaje
            // 
            this.lblPrecioViaje.AutoSize = true;
            this.lblPrecioViaje.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblPrecioViaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioViaje.Location = new System.Drawing.Point(41, 499);
            this.lblPrecioViaje.Name = "lblPrecioViaje";
            this.lblPrecioViaje.Size = new System.Drawing.Size(113, 20);
            this.lblPrecioViaje.TabIndex = 14;
            this.lblPrecioViaje.Text = "Precio del Viaje";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblPrecioFinal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioFinal.Location = new System.Drawing.Point(41, 541);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(87, 20);
            this.lblPrecioFinal.TabIndex = 15;
            this.lblPrecioFinal.Text = "Precio Final";
            // 
            // lblTituloViajes
            // 
            this.lblTituloViajes.AutoSize = true;
            this.lblTituloViajes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloViajes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloViajes.Location = new System.Drawing.Point(18, 9);
            this.lblTituloViajes.Name = "lblTituloViajes";
            this.lblTituloViajes.Size = new System.Drawing.Size(119, 22);
            this.lblTituloViajes.TabIndex = 17;
            this.lblTituloViajes.Text = "NUEVO VIAJE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Datos del cliente";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblNomCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomCliente.Location = new System.Drawing.Point(39, 13);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(64, 20);
            this.lblNomCliente.TabIndex = 20;
            this.lblNomCliente.Text = "Nombre";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomCliente.Location = new System.Drawing.Point(144, 13);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(169, 20);
            this.txtNomCliente.TabIndex = 1;
            // 
            // lblApeClient
            // 
            this.lblApeClient.AutoSize = true;
            this.lblApeClient.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblApeClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApeClient.Location = new System.Drawing.Point(41, 54);
            this.lblApeClient.Name = "lblApeClient";
            this.lblApeClient.Size = new System.Drawing.Size(66, 20);
            this.lblApeClient.TabIndex = 22;
            this.lblApeClient.Text = "Apellido";
            // 
            // txtApeCliente
            // 
            this.txtApeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApeCliente.Location = new System.Drawing.Point(144, 54);
            this.txtApeCliente.Name = "txtApeCliente";
            this.txtApeCliente.Size = new System.Drawing.Size(169, 20);
            this.txtApeCliente.TabIndex = 2;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblCelular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCelular.Location = new System.Drawing.Point(41, 94);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(56, 20);
            this.lblCelular.TabIndex = 24;
            this.lblCelular.Text = "Celular";
            // 
            // numCelCliente
            // 
            this.numCelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCelCliente.Location = new System.Drawing.Point(144, 94);
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
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Datos del envio";
            // 
            // lblMotoquero
            // 
            this.lblMotoquero.AutoSize = true;
            this.lblMotoquero.BackColor = System.Drawing.Color.Transparent;
            this.lblMotoquero.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblMotoquero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMotoquero.Location = new System.Drawing.Point(41, 456);
            this.lblMotoquero.Name = "lblMotoquero";
            this.lblMotoquero.Size = new System.Drawing.Size(86, 20);
            this.lblMotoquero.TabIndex = 26;
            this.lblMotoquero.Text = "Motoquero";
            // 
            // cmbMotoquero
            // 
            this.cmbMotoquero.FormattingEnabled = true;
            this.cmbMotoquero.Location = new System.Drawing.Point(145, 452);
            this.cmbMotoquero.Name = "cmbMotoquero";
            this.cmbMotoquero.Size = new System.Drawing.Size(169, 21);
            this.cmbMotoquero.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(191, 621);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 42);
            this.btnAceptar.TabIndex = 47;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(45, 621);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 42);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(144, 13);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(169, 21);
            this.cmbClientes.TabIndex = 53;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // chkNuevoCliente
            // 
            this.chkNuevoCliente.AutoSize = true;
            this.chkNuevoCliente.Location = new System.Drawing.Point(180, 45);
            this.chkNuevoCliente.Name = "chkNuevoCliente";
            this.chkNuevoCliente.Size = new System.Drawing.Size(112, 17);
            this.chkNuevoCliente.TabIndex = 54;
            this.chkNuevoCliente.Text = "NUEVO CLIENTE";
            this.chkNuevoCliente.UseVisualStyleBackColor = true;
            this.chkNuevoCliente.CheckedChanged += new System.EventHandler(this.chkNuevoCliente_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(41, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cliente";
            // 
            // pnlNuevoCliente
            // 
            this.pnlNuevoCliente.Controls.Add(this.lblCelular);
            this.pnlNuevoCliente.Controls.Add(this.numCelCliente);
            this.pnlNuevoCliente.Controls.Add(this.lblApeClient);
            this.pnlNuevoCliente.Controls.Add(this.txtApeCliente);
            this.pnlNuevoCliente.Controls.Add(this.lblNomCliente);
            this.pnlNuevoCliente.Controls.Add(this.txtNomCliente);
            this.pnlNuevoCliente.Enabled = false;
            this.pnlNuevoCliente.Location = new System.Drawing.Point(0, 113);
            this.pnlNuevoCliente.Name = "pnlNuevoCliente";
            this.pnlNuevoCliente.Size = new System.Drawing.Size(355, 126);
            this.pnlNuevoCliente.TabIndex = 56;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.label3);
            this.pnlCliente.Controls.Add(this.cmbClientes);
            this.pnlCliente.Controls.Add(this.btnNuevoCliente);
            this.pnlCliente.Location = new System.Drawing.Point(0, 70);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(355, 43);
            this.pnlCliente.TabIndex = 57;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoCliente.BackgroundImage = global::UI.Properties.Resources.more;
            this.btnNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Location = new System.Drawing.Point(319, 12);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(20, 20);
            this.btnNuevoCliente.TabIndex = 52;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalidad.BackgroundImage = global::UI.Properties.Resources.more;
            this.btnLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocalidad.FlatAppearance.BorderSize = 0;
            this.btnLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalidad.Location = new System.Drawing.Point(320, 368);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(20, 20);
            this.btnLocalidad.TabIndex = 50;
            this.btnLocalidad.UseVisualStyleBackColor = false;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // btnAgregarMoto
            // 
            this.btnAgregarMoto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMoto.BackgroundImage = global::UI.Properties.Resources.more;
            this.btnAgregarMoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarMoto.FlatAppearance.BorderSize = 0;
            this.btnAgregarMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMoto.Location = new System.Drawing.Point(320, 452);
            this.btnAgregarMoto.Name = "btnAgregarMoto";
            this.btnAgregarMoto.Size = new System.Drawing.Size(20, 20);
            this.btnAgregarMoto.TabIndex = 56;
            this.btnAgregarMoto.UseVisualStyleBackColor = false;
            this.btnAgregarMoto.Click += new System.EventHandler(this.btnAgregarMoto_Click);
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(144, 367);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(169, 21);
            this.cmbLocalidades.TabIndex = 58;
            // 
            // checkFragil
            // 
            this.checkFragil.AutoSize = true;
            this.checkFragil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkFragil.Location = new System.Drawing.Point(160, 577);
            this.checkFragil.Name = "checkFragil";
            this.checkFragil.Size = new System.Drawing.Size(63, 22);
            this.checkFragil.TabIndex = 59;
            this.checkFragil.Text = "Frágil";
            this.checkFragil.UseVisualStyleBackColor = true;
            // 
            // formNuevoViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(354, 692);
            this.Controls.Add(this.checkFragil);
            this.Controls.Add(this.cmbLocalidades);
            this.Controls.Add(this.btnAgregarMoto);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.pnlNuevoCliente);
            this.Controls.Add(this.chkNuevoCliente);
            this.Controls.Add(this.btnLocalidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbMotoquero);
            this.Controls.Add(this.lblMotoquero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloViajes);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblPrecioViaje);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.numPrecioFinal);
            this.Controls.Add(this.numPrecioViaje);
            this.Controls.Add(this.numUnidades);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.dtpFecha);
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
            this.pnlNuevoCliente.ResumeLayout(false);
            this.pnlNuevoCliente.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.NumericUpDown numPrecioViaje;
        private System.Windows.Forms.NumericUpDown numPrecioFinal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblPrecioViaje;
        private System.Windows.Forms.Label lblPrecioFinal;
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
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.CheckBox chkNuevoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlNuevoCliente;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btnAgregarMoto;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.CheckBox checkFragil;
    }
}

