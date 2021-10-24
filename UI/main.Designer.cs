
namespace UI
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevoViaje = new System.Windows.Forms.Button();
            this.btnNuevaMoto = new System.Windows.Forms.Button();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "MOTOMENSAJERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(65, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ONTIME";
            // 
            // btnNuevoViaje
            // 
            this.btnNuevoViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnNuevoViaje.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNuevoViaje.FlatAppearance.BorderSize = 0;
            this.btnNuevoViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnNuevoViaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoViaje.Location = new System.Drawing.Point(22, 105);
            this.btnNuevoViaje.Name = "btnNuevoViaje";
            this.btnNuevoViaje.Size = new System.Drawing.Size(187, 60);
            this.btnNuevoViaje.TabIndex = 36;
            this.btnNuevoViaje.Text = "VIAJES";
            this.btnNuevoViaje.UseVisualStyleBackColor = false;
            this.btnNuevoViaje.Click += new System.EventHandler(this.btnNuevoViaje_Click_1);
            // 
            // btnNuevaMoto
            // 
            this.btnNuevaMoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnNuevaMoto.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNuevaMoto.FlatAppearance.BorderSize = 0;
            this.btnNuevaMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnNuevaMoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevaMoto.Location = new System.Drawing.Point(22, 194);
            this.btnNuevaMoto.Name = "btnNuevaMoto";
            this.btnNuevaMoto.Size = new System.Drawing.Size(187, 60);
            this.btnNuevaMoto.TabIndex = 37;
            this.btnNuevaMoto.Text = "MOTOQUEROS";
            this.btnNuevaMoto.UseVisualStyleBackColor = false;
            this.btnNuevaMoto.Click += new System.EventHandler(this.btnNuevaMoto_Click_1);
            // 
            // btnGanancia
            // 
            this.btnGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnGanancia.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnGanancia.FlatAppearance.BorderSize = 0;
            this.btnGanancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnGanancia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGanancia.Location = new System.Drawing.Point(22, 287);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(187, 60);
            this.btnGanancia.TabIndex = 38;
            this.btnGanancia.Text = "GANANCIAS";
            this.btnGanancia.UseVisualStyleBackColor = false;
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(234, 376);
            this.Controls.Add(this.btnGanancia);
            this.Controls.Add(this.btnNuevaMoto);
            this.Controls.Add(this.btnNuevoViaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(250, 415);
            this.MinimumSize = new System.Drawing.Size(250, 415);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ONTIME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevoViaje;
        private System.Windows.Forms.Button btnNuevaMoto;
        private System.Windows.Forms.Button btnGanancia;
    }
}