
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevoViaje = new System.Windows.Forms.Button();
            this.btnNuevaMoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "MOTOMENSAJERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ONTIME";
            // 
            // btnNuevoViaje
            // 
            this.btnNuevoViaje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNuevoViaje.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNuevoViaje.FlatAppearance.BorderSize = 0;
            this.btnNuevoViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnNuevoViaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoViaje.Location = new System.Drawing.Point(22, 105);
            this.btnNuevoViaje.Name = "btnNuevoViaje";
            this.btnNuevoViaje.Size = new System.Drawing.Size(187, 60);
            this.btnNuevoViaje.TabIndex = 36;
            this.btnNuevoViaje.Text = "Nuevo Viaje";
            this.btnNuevoViaje.UseVisualStyleBackColor = false;
            // 
            // btnNuevaMoto
            // 
            this.btnNuevaMoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNuevaMoto.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNuevaMoto.FlatAppearance.BorderSize = 0;
            this.btnNuevaMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.99F);
            this.btnNuevaMoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevaMoto.Location = new System.Drawing.Point(22, 194);
            this.btnNuevaMoto.Name = "btnNuevaMoto";
            this.btnNuevaMoto.Size = new System.Drawing.Size(187, 60);
            this.btnNuevaMoto.TabIndex = 37;
            this.btnNuevaMoto.Text = "Nuevo Motoquero";
            this.btnNuevaMoto.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(234, 281);
            this.Controls.Add(this.btnNuevaMoto);
            this.Controls.Add(this.btnNuevoViaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(250, 320);
            this.MinimumSize = new System.Drawing.Size(250, 320);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevoViaje;
        private System.Windows.Forms.Button btnNuevaMoto;
    }
}