
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
            this.btnNuevoViaje = new System.Windows.Forms.Button();
            this.btnNuevaMoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevoViaje
            // 
            this.btnNuevoViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoViaje.Location = new System.Drawing.Point(22, 112);
            this.btnNuevoViaje.Name = "btnNuevoViaje";
            this.btnNuevoViaje.Size = new System.Drawing.Size(187, 55);
            this.btnNuevoViaje.TabIndex = 0;
            this.btnNuevoViaje.Text = "Nuevo viaje";
            this.btnNuevoViaje.UseVisualStyleBackColor = true;
            this.btnNuevoViaje.Click += new System.EventHandler(this.btnNuevoViaje_Click);
            // 
            // btnNuevaMoto
            // 
            this.btnNuevaMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMoto.Location = new System.Drawing.Point(22, 196);
            this.btnNuevaMoto.Name = "btnNuevaMoto";
            this.btnNuevaMoto.Size = new System.Drawing.Size(187, 55);
            this.btnNuevaMoto.TabIndex = 1;
            this.btnNuevaMoto.Text = "Nuevo motoquero";
            this.btnNuevaMoto.UseVisualStyleBackColor = true;
            this.btnNuevaMoto.Click += new System.EventHandler(this.btnNuevaMoto_Click);
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
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevaMoto);
            this.Controls.Add(this.btnNuevoViaje);
            this.MaximumSize = new System.Drawing.Size(250, 320);
            this.MinimumSize = new System.Drawing.Size(250, 320);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoViaje;
        private System.Windows.Forms.Button btnNuevaMoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}