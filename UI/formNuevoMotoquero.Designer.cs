
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
            ((System.ComponentModel.ISupportInitialize)(this.numCelMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCelularMoto
            // 
            this.lblCelularMoto.AutoSize = true;
            this.lblCelularMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCelularMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCelularMoto.Location = new System.Drawing.Point(24, 143);
            this.lblCelularMoto.Name = "lblCelularMoto";
            this.lblCelularMoto.Size = new System.Drawing.Size(52, 17);
            this.lblCelularMoto.TabIndex = 31;
            this.lblCelularMoto.Text = "Celular";
            // 
            // numCelMoto
            // 
            this.numCelMoto.Location = new System.Drawing.Point(139, 140);
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
            this.lblApeMoto.AutoSize = true;
            this.lblApeMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblApeMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApeMoto.Location = new System.Drawing.Point(24, 103);
            this.lblApeMoto.Name = "lblApeMoto";
            this.lblApeMoto.Size = new System.Drawing.Size(58, 17);
            this.lblApeMoto.TabIndex = 30;
            this.lblApeMoto.Text = "Apellido";
            // 
            // txtApeMoto
            // 
            this.txtApeMoto.Location = new System.Drawing.Point(139, 100);
            this.txtApeMoto.Name = "txtApeMoto";
            this.txtApeMoto.Size = new System.Drawing.Size(169, 20);
            this.txtApeMoto.TabIndex = 26;
            // 
            // lblNomMoto
            // 
            this.lblNomMoto.AutoSize = true;
            this.lblNomMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNomMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomMoto.Location = new System.Drawing.Point(24, 62);
            this.lblNomMoto.Name = "lblNomMoto";
            this.lblNomMoto.Size = new System.Drawing.Size(58, 17);
            this.lblNomMoto.TabIndex = 29;
            this.lblNomMoto.Text = "Nombre";
            // 
            // txtNomMoto
            // 
            this.txtNomMoto.Location = new System.Drawing.Point(139, 59);
            this.txtNomMoto.Name = "txtNomMoto";
            this.txtNomMoto.Size = new System.Drawing.Size(169, 20);
            this.txtNomMoto.TabIndex = 25;
            // 
            // lblModeloMoto
            // 
            this.lblModeloMoto.AutoSize = true;
            this.lblModeloMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblModeloMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModeloMoto.Location = new System.Drawing.Point(24, 183);
            this.lblModeloMoto.Name = "lblModeloMoto";
            this.lblModeloMoto.Size = new System.Drawing.Size(109, 17);
            this.lblModeloMoto.TabIndex = 32;
            this.lblModeloMoto.Text = "Modelo de Moto";
            // 
            // txtModeloMoto
            // 
            this.txtModeloMoto.Location = new System.Drawing.Point(139, 180);
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
            this.btnAddMoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddMoto.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddMoto.FlatAppearance.BorderSize = 0;
            this.btnAddMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnAddMoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMoto.Location = new System.Drawing.Point(175, 234);
            this.btnAddMoto.Name = "btnAddMoto";
            this.btnAddMoto.Size = new System.Drawing.Size(133, 46);
            this.btnAddMoto.TabIndex = 35;
            this.btnAddMoto.Text = "Agregar";
            this.btnAddMoto.UseVisualStyleBackColor = false;
            this.btnAddMoto.Click += new System.EventHandler(this.btnAddMoto_Click);
            // 
            // formNuevoMotoquero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(354, 311);
            this.Controls.Add(this.btnAddMoto);
            this.Controls.Add(this.txtModeloMoto);
            this.Controls.Add(this.lblModeloMoto);
            this.Controls.Add(this.lblCelularMoto);
            this.Controls.Add(this.numCelMoto);
            this.Controls.Add(this.lblApeMoto);
            this.Controls.Add(this.txtApeMoto);
            this.Controls.Add(this.lblNomMoto);
            this.Controls.Add(this.txtNomMoto);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(370, 350);
            this.MinimumSize = new System.Drawing.Size(370, 350);
            this.Name = "formNuevoMotoquero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo motoquero";
            ((System.ComponentModel.ISupportInitialize)(this.numCelMoto)).EndInit();
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
    }
}