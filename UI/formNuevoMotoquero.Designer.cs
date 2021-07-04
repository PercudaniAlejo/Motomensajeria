
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
            this.btnOkEnvio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCelMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCelularMoto
            // 
            this.lblCelularMoto.AutoSize = true;
            this.lblCelularMoto.Location = new System.Drawing.Point(45, 147);
            this.lblCelularMoto.Name = "lblCelularMoto";
            this.lblCelularMoto.Size = new System.Drawing.Size(39, 13);
            this.lblCelularMoto.TabIndex = 31;
            this.lblCelularMoto.Text = "Celular";
            // 
            // numCelMoto
            // 
            this.numCelMoto.Location = new System.Drawing.Point(139, 140);
            this.numCelMoto.Name = "numCelMoto";
            this.numCelMoto.Size = new System.Drawing.Size(169, 20);
            this.numCelMoto.TabIndex = 27;
            this.numCelMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblApeMoto
            // 
            this.lblApeMoto.AutoSize = true;
            this.lblApeMoto.Location = new System.Drawing.Point(45, 107);
            this.lblApeMoto.Name = "lblApeMoto";
            this.lblApeMoto.Size = new System.Drawing.Size(44, 13);
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
            this.lblNomMoto.Location = new System.Drawing.Point(45, 66);
            this.lblNomMoto.Name = "lblNomMoto";
            this.lblNomMoto.Size = new System.Drawing.Size(44, 13);
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
            this.lblModeloMoto.Location = new System.Drawing.Point(45, 187);
            this.lblModeloMoto.Name = "lblModeloMoto";
            this.lblModeloMoto.Size = new System.Drawing.Size(84, 13);
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
            // btnOkEnvio
            // 
            this.btnOkEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkEnvio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOkEnvio.Location = new System.Drawing.Point(174, 220);
            this.btnOkEnvio.Name = "btnOkEnvio";
            this.btnOkEnvio.Size = new System.Drawing.Size(134, 40);
            this.btnOkEnvio.TabIndex = 34;
            this.btnOkEnvio.Text = "Agregar ";
            this.btnOkEnvio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nuevo motoquero";
            // 
            // formNuevoMotoquero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 311);
            this.Controls.Add(this.btnOkEnvio);
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
            this.Text = "formNuevoMotoquero";
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
        private System.Windows.Forms.Button btnOkEnvio;
        private System.Windows.Forms.Label label1;
    }
}