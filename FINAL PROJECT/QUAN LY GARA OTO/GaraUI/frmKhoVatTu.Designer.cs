namespace GaraUI
{
    partial class frmKhoVatTu
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableDanhSachVTPT = new System.Windows.Forms.DataGridView();
            this.qUAN_LY_GARA_OTODataSet = new GaraUI.QUAN_LY_GARA_OTODataSet();
            this.spVatTuPhuTungGetAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_VatTuPhuTung_GetAllTableAdapter = new GaraUI.QUAN_LY_GARA_OTODataSetTableAdapters.sp_VatTuPhuTung_GetAllTableAdapter();
            this.maVatTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSachVTPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVatTuPhuTungGetAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableDanhSachVTPT);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(603, 275);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh sách vật tư phụ tùng:";
            // 
            // tableDanhSachVTPT
            // 
            this.tableDanhSachVTPT.AutoGenerateColumns = false;
            this.tableDanhSachVTPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDanhSachVTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDanhSachVTPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVatTuDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn});
            this.tableDanhSachVTPT.DataSource = this.spVatTuPhuTungGetAllBindingSource;
            this.tableDanhSachVTPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDanhSachVTPT.Location = new System.Drawing.Point(2, 21);
            this.tableDanhSachVTPT.Name = "tableDanhSachVTPT";
            this.tableDanhSachVTPT.Size = new System.Drawing.Size(599, 252);
            this.tableDanhSachVTPT.TabIndex = 0;
            // 
            // qUAN_LY_GARA_OTODataSet
            // 
            this.qUAN_LY_GARA_OTODataSet.DataSetName = "QUAN_LY_GARA_OTODataSet";
            this.qUAN_LY_GARA_OTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spVatTuPhuTungGetAllBindingSource
            // 
            this.spVatTuPhuTungGetAllBindingSource.DataMember = "sp_VatTuPhuTung_GetAll";
            this.spVatTuPhuTungGetAllBindingSource.DataSource = this.qUAN_LY_GARA_OTODataSet;
            // 
            // sp_VatTuPhuTung_GetAllTableAdapter
            // 
            this.sp_VatTuPhuTung_GetAllTableAdapter.ClearBeforeFill = true;
            // 
            // maVatTuDataGridViewTextBoxColumn
            // 
            this.maVatTuDataGridViewTextBoxColumn.DataPropertyName = "MaVatTu";
            this.maVatTuDataGridViewTextBoxColumn.HeaderText = "Mã Vật Tư";
            this.maVatTuDataGridViewTextBoxColumn.Name = "maVatTuDataGridViewTextBoxColumn";
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "Số Lượng Tồn";
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // frmKhoVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 275);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKhoVatTu";
            this.Text = "Kho Vật Tư";
            this.Load += new System.EventHandler(this.frmKhoVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSachVTPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVatTuPhuTungGetAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView tableDanhSachVTPT;
        private QUAN_LY_GARA_OTODataSet qUAN_LY_GARA_OTODataSet;
        private System.Windows.Forms.BindingSource spVatTuPhuTungGetAllBindingSource;
        private QUAN_LY_GARA_OTODataSetTableAdapters.sp_VatTuPhuTung_GetAllTableAdapter sp_VatTuPhuTung_GetAllTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVatTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;

    }
}