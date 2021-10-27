
namespace UI
{
    partial class formVisorGanancias
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DSGananciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSEnvios = new UI.DSEnvios();
            this.rvGanancias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSGananciaTableAdapter = new UI.DSEnviosTableAdapters.DSGananciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSGananciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // DSGananciaBindingSource
            // 
            this.DSGananciaBindingSource.DataMember = "DSGanancia";
            this.DSGananciaBindingSource.DataSource = this.DSEnvios;
            // 
            // DSEnvios
            // 
            this.DSEnvios.DataSetName = "DSEnvios";
            this.DSEnvios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvGanancias
            // 
            this.rvGanancias.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSGanancia";
            reportDataSource1.Value = this.DSGananciaBindingSource;
            this.rvGanancias.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGanancias.LocalReport.ReportEmbeddedResource = "UI.reportGanancias.rdlc";
            this.rvGanancias.Location = new System.Drawing.Point(0, 0);
            this.rvGanancias.Name = "rvGanancias";
            this.rvGanancias.ServerReport.BearerToken = null;
            this.rvGanancias.Size = new System.Drawing.Size(647, 341);
            this.rvGanancias.TabIndex = 0;
            // 
            // DSGananciaTableAdapter
            // 
            this.DSGananciaTableAdapter.ClearBeforeFill = true;
            // 
            // formVisorGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 341);
            this.Controls.Add(this.rvGanancias);
            this.Name = "formVisorGanancias";
            this.Text = "Ganancias";
            this.Load += new System.EventHandler(this.formVisorGanancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSGananciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEnvios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvGanancias;
        private System.Windows.Forms.BindingSource DSGananciaBindingSource;
        private DSEnvios DSEnvios;
        private DSEnviosTableAdapters.DSGananciaTableAdapter DSGananciaTableAdapter;
    }
}