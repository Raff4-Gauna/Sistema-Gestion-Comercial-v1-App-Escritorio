
namespace CapaPresentación.MdVentas.Reportes
{
    partial class frmRPTDetallesVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datosGeneralesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Reportes = new CapaPresentación.MdVentas.Reportes.DS_Reportes();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.datosGeneralesVentaTableAdapter = new CapaPresentación.MdVentas.Reportes.DS_ReportesTableAdapters.datosGeneralesVentaTableAdapter();
            this.detalleVentaTableAdapter = new CapaPresentación.MdVentas.Reportes.DS_ReportesTableAdapters.detalleVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosGeneralesVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datosGeneralesVentaBindingSource
            // 
            this.datosGeneralesVentaBindingSource.DataMember = "datosGeneralesVenta";
            this.datosGeneralesVentaBindingSource.DataSource = this.DS_Reportes;
            // 
            // DS_Reportes
            // 
            this.DS_Reportes.DataSetName = "DS_Reportes";
            this.DS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "detalleVenta";
            this.detalleVentaBindingSource.DataSource = this.DS_Reportes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DS_DatosGeneralesVenta";
            reportDataSource5.Value = this.datosGeneralesVentaBindingSource;
            reportDataSource6.Name = "DS_DetalleVenta";
            reportDataSource6.Value = this.detalleVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentación.MdVentas.Reportes.RPT_DetallesVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(526, 44);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdVenta.TabIndex = 1;
            this.txtIdVenta.Visible = false;
            // 
            // datosGeneralesVentaTableAdapter
            // 
            this.datosGeneralesVentaTableAdapter.ClearBeforeFill = true;
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRPTDetallesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 682);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "frmRPTDetallesVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Detalle Venta";
            this.Load += new System.EventHandler(this.frmRPTDetallesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosGeneralesVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosGeneralesVentaBindingSource;
        private DS_Reportes DS_Reportes;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private DS_ReportesTableAdapters.datosGeneralesVentaTableAdapter datosGeneralesVentaTableAdapter;
        private DS_ReportesTableAdapters.detalleVentaTableAdapter detalleVentaTableAdapter;
        public System.Windows.Forms.TextBox txtIdVenta;
    }
}