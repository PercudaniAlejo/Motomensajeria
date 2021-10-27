
namespace UI
{
    partial class formVisorViajesHoy
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
            this.rvViajes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSEnvios = new UI.DSEnvios();
            this.DSCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCompletoTableAdapter = new UI.DSEnviosTableAdapters.DSCompletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCompletoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvViajes
            // 
            this.rvViajes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSEnviosCompleto";
            reportDataSource1.Value = this.DSCompletoBindingSource;
            this.rvViajes.LocalReport.DataSources.Add(reportDataSource1);
            this.rvViajes.LocalReport.ReportEmbeddedResource = "UI.reportEnvio.rdlc";
            this.rvViajes.Location = new System.Drawing.Point(0, 0);
            this.rvViajes.Name = "rvViajes";
            this.rvViajes.ServerReport.BearerToken = null;
            this.rvViajes.Size = new System.Drawing.Size(800, 450);
            this.rvViajes.TabIndex = 0;
            // 
            // DSEnvios
            // 
            this.DSEnvios.DataSetName = "DSEnvios";
            this.DSEnvios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DSCompletoBindingSource
            // 
            this.DSCompletoBindingSource.DataMember = "DSCompleto";
            this.DSCompletoBindingSource.DataSource = this.DSEnvios;
            // 
            // DSCompletoTableAdapter
            // 
            this.DSCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // formVisorViajesHoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvViajes);
            this.Name = "formVisorViajesHoy";
            this.Text = "Viajes de hoy";
            this.Load += new System.EventHandler(this.formVisorViajesHoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCompletoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvViajes;
        private System.Windows.Forms.BindingSource DSCompletoBindingSource;
        private DSEnvios DSEnvios;
        private DSEnviosTableAdapters.DSCompletoTableAdapter DSCompletoTableAdapter;
    }
}