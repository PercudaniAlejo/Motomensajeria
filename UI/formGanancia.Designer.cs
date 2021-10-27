
namespace UI
{
    partial class formGanancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGanancia));
            this.dgvGanancias = new System.Windows.Forms.DataGridView();
            this.lblTituloViajes = new System.Windows.Forms.Label();
            this.btnVisorGanancias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGanancias
            // 
            this.dgvGanancias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGanancias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGanancias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGanancias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.dgvGanancias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGanancias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGanancias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGanancias.ColumnHeadersHeight = 40;
            this.dgvGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGanancias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGanancias.EnableHeadersVisualStyles = false;
            this.dgvGanancias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.dgvGanancias.Location = new System.Drawing.Point(-3, 59);
            this.dgvGanancias.Name = "dgvGanancias";
            this.dgvGanancias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGanancias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGanancias.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGanancias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGanancias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGanancias.Size = new System.Drawing.Size(321, 215);
            this.dgvGanancias.TabIndex = 45;
            // 
            // lblTituloViajes
            // 
            this.lblTituloViajes.AutoSize = true;
            this.lblTituloViajes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloViajes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloViajes.Location = new System.Drawing.Point(8, 20);
            this.lblTituloViajes.Name = "lblTituloViajes";
            this.lblTituloViajes.Size = new System.Drawing.Size(225, 22);
            this.lblTituloViajes.TabIndex = 46;
            this.lblTituloViajes.Text = "CONTROL DE GANANCIAS";
            // 
            // btnVisorGanancias
            // 
            this.btnVisorGanancias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVisorGanancias.BackColor = System.Drawing.Color.Transparent;
            this.btnVisorGanancias.BackgroundImage = global::UI.Properties.Resources.print;
            this.btnVisorGanancias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisorGanancias.FlatAppearance.BorderSize = 0;
            this.btnVisorGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisorGanancias.Location = new System.Drawing.Point(263, 16);
            this.btnVisorGanancias.Name = "btnVisorGanancias";
            this.btnVisorGanancias.Size = new System.Drawing.Size(39, 33);
            this.btnVisorGanancias.TabIndex = 59;
            this.btnVisorGanancias.UseVisualStyleBackColor = false;
            this.btnVisorGanancias.Click += new System.EventHandler(this.btnVisorGanancias_Click);
            // 
            // formGanancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(314, 272);
            this.Controls.Add(this.btnVisorGanancias);
            this.Controls.Add(this.lblTituloViajes);
            this.Controls.Add(this.dgvGanancias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(330, 310);
            this.MinimumSize = new System.Drawing.Size(330, 310);
            this.Name = "formGanancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finanzas";
            this.Load += new System.EventHandler(this.formFinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGanancias;
        private System.Windows.Forms.Label lblTituloViajes;
        private System.Windows.Forms.Button btnVisorGanancias;
    }
}