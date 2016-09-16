namespace GaraUI
{
    partial class frmReportPhieuSuaChua
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rpvPhieuSuaChua = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpPhieuSuaChua = new GaraUI.rpPhieuSuaChua();
            this.sp_CT_PhieuSuaChua_GetByBienSoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_CT_PhieuSuaChua_GetByBienSoTableAdapter = new GaraUI.rpPhieuSuaChuaTableAdapters.sp_CT_PhieuSuaChua_GetByBienSoTableAdapter();
            this.DataTable1TableAdapter = new GaraUI.rpPhieuSuaChuaTableAdapters.DataTable1TableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpPhieuSuaChua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CT_PhieuSuaChua_GetByBienSoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rpvPhieuSuaChua, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 539F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(863, 539);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rpvPhieuSuaChua
            // 
            this.rpvPhieuSuaChua.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rpvPhieuSuaChua.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPhieuSuaChua.LocalReport.ReportEmbeddedResource = "GaraUI.rp_PhieuSuaChua.rdlc";
            this.rpvPhieuSuaChua.Location = new System.Drawing.Point(3, 3);
            this.rpvPhieuSuaChua.Name = "rpvPhieuSuaChua";
            this.rpvPhieuSuaChua.Size = new System.Drawing.Size(857, 533);
            this.rpvPhieuSuaChua.TabIndex = 0;
            this.rpvPhieuSuaChua.Load += new System.EventHandler(this.rpvPhieuSuaChua_Load);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.rpPhieuSuaChua;
            // 
            // rpPhieuSuaChua
            // 
            this.rpPhieuSuaChua.DataSetName = "rpPhieuSuaChua";
            this.rpPhieuSuaChua.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_CT_PhieuSuaChua_GetByBienSoBindingSource
            // 
            this.sp_CT_PhieuSuaChua_GetByBienSoBindingSource.DataMember = "sp_CT_PhieuSuaChua_GetByBienSo";
            this.sp_CT_PhieuSuaChua_GetByBienSoBindingSource.DataSource = this.rpPhieuSuaChua;
            // 
            // sp_CT_PhieuSuaChua_GetByBienSoTableAdapter
            // 
            this.sp_CT_PhieuSuaChua_GetByBienSoTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // frmReportPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 539);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReportPhieuSuaChua";
            this.Text = "Phiếu sửa chữa";
            this.Load += new System.EventHandler(this.frmReportPhieuSuaChua_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpPhieuSuaChua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CT_PhieuSuaChua_GetByBienSoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource sp_CT_PhieuSuaChua_GetByBienSoBindingSource;
        private rpPhieuSuaChua rpPhieuSuaChua;
        private rpPhieuSuaChuaTableAdapters.sp_CT_PhieuSuaChua_GetByBienSoTableAdapter sp_CT_PhieuSuaChua_GetByBienSoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPhieuSuaChua;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private rpPhieuSuaChuaTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;

    }
}