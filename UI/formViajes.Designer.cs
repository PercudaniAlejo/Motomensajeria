
namespace UI
{
    partial class formViajes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formViajes));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxViajesHoy = new System.Windows.Forms.CheckBox();
            this.dgvEnvios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReportViajes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(12, 53);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnDetalles.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnDetalles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetalles.Location = new System.Drawing.Point(603, 362);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(133, 29);
            this.btnDetalles.TabIndex = 17;
            this.btnDetalles.Text = "Más detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "VIAJES";
            // 
            // checkBoxViajesHoy
            // 
            this.checkBoxViajesHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxViajesHoy.AutoSize = true;
            this.checkBoxViajesHoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxViajesHoy.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.checkBoxViajesHoy.ForeColor = System.Drawing.Color.White;
            this.checkBoxViajesHoy.Location = new System.Drawing.Point(601, 48);
            this.checkBoxViajesHoy.Name = "checkBoxViajesHoy";
            this.checkBoxViajesHoy.Size = new System.Drawing.Size(130, 25);
            this.checkBoxViajesHoy.TabIndex = 46;
            this.checkBoxViajesHoy.Text = "Viajes de hoy";
            this.checkBoxViajesHoy.UseVisualStyleBackColor = true;
            this.checkBoxViajesHoy.CheckedChanged += new System.EventHandler(this.checkBoxViajesHoy_CheckedChanged);
            // 
            // dgvEnvios
            // 
            this.dgvEnvios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEnvios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnvios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnvios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.dgvEnvios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEnvios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEnvios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEnvios.ColumnHeadersHeight = 40;
            this.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnvios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEnvios.EnableHeadersVisualStyles = false;
            this.dgvEnvios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.dgvEnvios.Location = new System.Drawing.Point(-1, 89);
            this.dgvEnvios.Name = "dgvEnvios";
            this.dgvEnvios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEnvios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEnvios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEnvios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEnvios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnvios.Size = new System.Drawing.Size(749, 252);
            this.dgvEnvios.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::UI.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(153, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 33);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::UI.Properties.Resources.update;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(80, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 33);
            this.button2.TabIndex = 55;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::UI.Properties.Resources.create;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(7, 358);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(52, 33);
            this.btnAgregar.TabIndex = 54;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::UI.Properties.Resources.search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(224, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(20, 20);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnReportViajes
            // 
            this.btnReportViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReportViajes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportViajes.BackgroundImage = global::UI.Properties.Resources.print;
            this.btnReportViajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReportViajes.FlatAppearance.BorderSize = 0;
            this.btnReportViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportViajes.Location = new System.Drawing.Point(545, 355);
            this.btnReportViajes.Name = "btnReportViajes";
            this.btnReportViajes.Size = new System.Drawing.Size(48, 44);
            this.btnReportViajes.TabIndex = 58;
            this.btnReportViajes.UseVisualStyleBackColor = false;
            this.btnReportViajes.Click += new System.EventHandler(this.btnReportViajes_Click);
            // 
            // formViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(748, 427);
            this.Controls.Add(this.btnReportViajes);
            this.Controls.Add(this.dgvEnvios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.checkBoxViajesHoy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.txtBuscar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(764, 465);
            this.Name = "formViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxViajesHoy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEnvios;
        private System.Windows.Forms.Button btnReportViajes;
    }
}