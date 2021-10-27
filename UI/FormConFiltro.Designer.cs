
namespace UI
{
    partial class FormConFiltro
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
            this.DSFiltradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSEnvios = new UI.DSEnvios();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbMotoqueros = new System.Windows.Forms.ComboBox();
            this.DSFiltradoTableAdapter = new UI.DSEnviosTableAdapters.DSFiltradoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSFiltradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // DSFiltradoBindingSource
            // 
            this.DSFiltradoBindingSource.DataMember = "DSFiltrado";
            this.DSFiltradoBindingSource.DataSource = this.DSEnvios;
            // 
            // DSEnvios
            // 
            this.DSEnvios.DataSetName = "DSEnvios";
            this.DSEnvios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv
            // 
            this.rv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DS";
            reportDataSource1.Value = this.DSFiltradoBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "UI.reportEnviosPorMoto.rdlc";
            this.rv.Location = new System.Drawing.Point(-1, 68);
            this.rv.Name = "rv";
            this.rv.ServerReport.BearerToken = null;
            this.rv.Size = new System.Drawing.Size(802, 385);
            this.rv.TabIndex = 0;
            // 
            // cmbMotoqueros
            // 
            this.cmbMotoqueros.FormattingEnabled = true;
            this.cmbMotoqueros.Location = new System.Drawing.Point(45, 27);
            this.cmbMotoqueros.Name = "cmbMotoqueros";
            this.cmbMotoqueros.Size = new System.Drawing.Size(202, 21);
            this.cmbMotoqueros.TabIndex = 1;
            this.cmbMotoqueros.SelectedIndexChanged += new System.EventHandler(this.cmbMotoqueros_SelectedIndexChanged);
            // 
            // DSFiltradoTableAdapter
            // 
            this.DSFiltradoTableAdapter.ClearBeforeFill = true;
            // 
            // FormConFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMotoqueros);
            this.Controls.Add(this.rv);
            this.Name = "FormConFiltro";
            this.Text = "FormConFiltro";
            this.Load += new System.EventHandler(this.FormConFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSFiltradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEnvios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.ComboBox cmbMotoqueros;
      //  private DataSet1 DataSet1;
      //  private DataSet1TableAdapters.DTEnviosPorMotoTableAdapter DTEnviosPorMotoTableAdapter;
        private System.Windows.Forms.BindingSource DSFiltradoBindingSource;
        private DSEnvios DSEnvios;
        private DSEnviosTableAdapters.DSFiltradoTableAdapter DSFiltradoTableAdapter;
    }
}