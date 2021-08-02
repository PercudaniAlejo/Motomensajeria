
namespace UI
{
    partial class formNuevoMotoquero
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
            this.lblCelularMoto = new System.Windows.Forms.Label();
            this.numCelMoto = new System.Windows.Forms.NumericUpDown();
            this.lblApeMoto = new System.Windows.Forms.Label();
            this.txtApeMoto = new System.Windows.Forms.TextBox();
            this.lblNomMoto = new System.Windows.Forms.Label();
            this.txtNomMoto = new System.Windows.Forms.TextBox();
            this.lblModeloMoto = new System.Windows.Forms.Label();
            this.txtModeloMoto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvMotoqueros = new System.Windows.Forms.DataGridView();
            this.pnlAddMoto = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCelMoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoqueros)).BeginInit();
            this.pnlAddMoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCelularMoto
            // 
            this.lblCelularMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCelularMoto.AutoSize = true;
            this.lblCelularMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCelularMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCelularMoto.Location = new System.Drawing.Point(14, 62);
            this.lblCelularMoto.Name = "lblCelularMoto";
            this.lblCelularMoto.Size = new System.Drawing.Size(52, 17);
            this.lblCelularMoto.TabIndex = 31;
            this.lblCelularMoto.Text = "Celular";
            // 
            // numCelMoto
            // 
            this.numCelMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numCelMoto.Location = new System.Drawing.Point(17, 82);
            this.numCelMoto.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numCelMoto.Name = "numCelMoto";
            this.numCelMoto.Size = new System.Drawing.Size(169, 20);
            this.numCelMoto.TabIndex = 27;
            this.numCelMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblApeMoto
            // 
            this.lblApeMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblApeMoto.AutoSize = true;
            this.lblApeMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblApeMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApeMoto.Location = new System.Drawing.Point(253, 10);
            this.lblApeMoto.Name = "lblApeMoto";
            this.lblApeMoto.Size = new System.Drawing.Size(58, 17);
            this.lblApeMoto.TabIndex = 30;
            this.lblApeMoto.Text = "Apellido";
            // 
            // txtApeMoto
            // 
            this.txtApeMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtApeMoto.Location = new System.Drawing.Point(256, 30);
            this.txtApeMoto.Name = "txtApeMoto";
            this.txtApeMoto.Size = new System.Drawing.Size(169, 20);
            this.txtApeMoto.TabIndex = 26;
            // 
            // lblNomMoto
            // 
            this.lblNomMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNomMoto.AutoSize = true;
            this.lblNomMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNomMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomMoto.Location = new System.Drawing.Point(14, 10);
            this.lblNomMoto.Name = "lblNomMoto";
            this.lblNomMoto.Size = new System.Drawing.Size(58, 17);
            this.lblNomMoto.TabIndex = 29;
            this.lblNomMoto.Text = "Nombre";
            // 
            // txtNomMoto
            // 
            this.txtNomMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomMoto.Location = new System.Drawing.Point(17, 30);
            this.txtNomMoto.Name = "txtNomMoto";
            this.txtNomMoto.Size = new System.Drawing.Size(169, 20);
            this.txtNomMoto.TabIndex = 25;
            // 
            // lblModeloMoto
            // 
            this.lblModeloMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModeloMoto.AutoSize = true;
            this.lblModeloMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblModeloMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModeloMoto.Location = new System.Drawing.Point(253, 62);
            this.lblModeloMoto.Name = "lblModeloMoto";
            this.lblModeloMoto.Size = new System.Drawing.Size(109, 17);
            this.lblModeloMoto.TabIndex = 32;
            this.lblModeloMoto.Text = "Modelo de Moto";
            // 
            // txtModeloMoto
            // 
            this.txtModeloMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtModeloMoto.Location = new System.Drawing.Point(256, 81);
            this.txtModeloMoto.Name = "txtModeloMoto";
            this.txtModeloMoto.Size = new System.Drawing.Size(169, 20);
            this.txtModeloMoto.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nuevo motoquero";
            // 
            // btnAddMoto
            // 
            this.btnAddMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMoto.BackColor = System.Drawing.Color.Silver;
            this.btnAddMoto.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddMoto.FlatAppearance.BorderSize = 0;
            this.btnAddMoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnAddMoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMoto.Location = new System.Drawing.Point(479, 17);
            this.btnAddMoto.Name = "btnAddMoto";
            this.btnAddMoto.Size = new System.Drawing.Size(80, 33);
            this.btnAddMoto.TabIndex = 35;
            this.btnAddMoto.Text = "Aceptar";
            this.btnAddMoto.UseVisualStyleBackColor = false;
            this.btnAddMoto.Click += new System.EventHandler(this.btnAddMoto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(479, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 33);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvMotoqueros
            // 
            this.dgvMotoqueros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMotoqueros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotoqueros.Location = new System.Drawing.Point(15, 48);
            this.dgvMotoqueros.Name = "dgvMotoqueros";
            this.dgvMotoqueros.Size = new System.Drawing.Size(544, 235);
            this.dgvMotoqueros.TabIndex = 37;
            // 
            // pnlAddMoto
            // 
            this.pnlAddMoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddMoto.Controls.Add(this.btnCancelar);
            this.pnlAddMoto.Controls.Add(this.btnAddMoto);
            this.pnlAddMoto.Controls.Add(this.txtModeloMoto);
            this.pnlAddMoto.Controls.Add(this.lblModeloMoto);
            this.pnlAddMoto.Controls.Add(this.lblCelularMoto);
            this.pnlAddMoto.Controls.Add(this.numCelMoto);
            this.pnlAddMoto.Controls.Add(this.lblApeMoto);
            this.pnlAddMoto.Controls.Add(this.txtApeMoto);
            this.pnlAddMoto.Controls.Add(this.lblNomMoto);
            this.pnlAddMoto.Controls.Add(this.txtNomMoto);
            this.pnlAddMoto.Enabled = false;
            this.pnlAddMoto.Location = new System.Drawing.Point(0, 337);
            this.pnlAddMoto.Name = "pnlAddMoto";
            this.pnlAddMoto.Size = new System.Drawing.Size(571, 121);
            this.pnlAddMoto.TabIndex = 38;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.BackColor = System.Drawing.Color.Silver;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Location = new System.Drawing.Point(15, 289);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 33);
            this.btnNuevo.TabIndex = 37;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(105, 289);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 33);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(191, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 33);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(390, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(169, 20);
            this.txtBuscar.TabIndex = 37;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(304, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 20);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // formNuevoMotoquero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(571, 458);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlAddMoto);
            this.Controls.Add(this.dgvMotoqueros);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(587, 497);
            this.Name = "formNuevoMotoquero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo motoquero";
            ((System.ComponentModel.ISupportInitialize)(this.numCelMoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoqueros)).EndInit();
            this.pnlAddMoto.ResumeLayout(false);
            this.pnlAddMoto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelularMoto;
        private System.Windows.Forms.NumericUpDown numCelMoto;
        private System.Windows.Forms.Label lblApeMoto;
        private System.Windows.Forms.TextBox txtApeMoto;
        private System.Windows.Forms.Label lblNomMoto;
        private System.Windows.Forms.TextBox txtNomMoto;
        private System.Windows.Forms.Label lblModeloMoto;
        private System.Windows.Forms.TextBox txtModeloMoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMotoqueros;
        private System.Windows.Forms.Panel pnlAddMoto;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}