
namespace CapaPresentación.MdConfiguracion
{
    partial class frmReporteListaUsuarios
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
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVENTASGESTIONDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVENTASGESTIONDataSet = new CapaPresentación.DBVENTASGESTIONDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSUARIOTableAdapter = new CapaPresentación.DBVENTASGESTIONDataSetTableAdapters.USUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVENTASGESTIONDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVENTASGESTIONDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.dBVENTASGESTIONDataSetBindingSource;
            // 
            // dBVENTASGESTIONDataSetBindingSource
            // 
            this.dBVENTASGESTIONDataSetBindingSource.DataSource = this.dBVENTASGESTIONDataSet;
            this.dBVENTASGESTIONDataSetBindingSource.Position = 0;
            // 
            // dBVENTASGESTIONDataSet
            // 
            this.dBVENTASGESTIONDataSet.DataSetName = "DBVENTASGESTIONDataSet";
            this.dBVENTASGESTIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSUARIOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentación.MdConfiguracion.ReporteListaUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(705, 614);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 614);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmReporteListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Usuario";
            this.Load += new System.EventHandler(this.frmReporteListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVENTASGESTIONDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVENTASGESTIONDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dBVENTASGESTIONDataSetBindingSource;
        private DBVENTASGESTIONDataSet dBVENTASGESTIONDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private DBVENTASGESTIONDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
    }
}