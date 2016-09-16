namespace GaraUI
{
    partial class frmTienCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTienCong));
            this.spTienCongGetAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_GARA_OTODataSet = new GaraUI.QUAN_LY_GARA_OTODataSet();
            this.sp_TienCong_GetAllTableAdapter = new GaraUI.QUAN_LY_GARA_OTODataSetTableAdapters.sp_TienCong_GetAllTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableDanhSachTienCong = new System.Windows.Forms.DataGridView();
            this.noiDungSuaChuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.spTienCongGetAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSachTienCong)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spTienCongGetAllBindingSource
            // 
            this.spTienCongGetAllBindingSource.DataMember = "sp_TienCong_GetAll";
            this.spTienCongGetAllBindingSource.DataSource = this.qUAN_LY_GARA_OTODataSet;
            // 
            // qUAN_LY_GARA_OTODataSet
            // 
            this.qUAN_LY_GARA_OTODataSet.DataSetName = "QUAN_LY_GARA_OTODataSet";
            this.qUAN_LY_GARA_OTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_TienCong_GetAllTableAdapter
            // 
            this.sp_TienCong_GetAllTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXoa3);
            this.panelControl1.Controls.Add(this.btnThem3);
            this.panelControl1.Controls.Add(this.btnSua3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 506);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(533, 36);
            this.panelControl1.TabIndex = 3;
            // 
            // btnXoa3
            // 
            this.btnXoa3.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa3.Image")));
            this.btnXoa3.Location = new System.Drawing.Point(306, 3);
            this.btnXoa3.Name = "btnXoa3";
            this.btnXoa3.Size = new System.Drawing.Size(68, 30);
            this.btnXoa3.TabIndex = 12;
            this.btnXoa3.Text = "Xoá";
            this.btnXoa3.Click += new System.EventHandler(this.btnXoa3_Click);
            // 
            // btnThem3
            // 
            this.btnThem3.Image = ((System.Drawing.Image)(resources.GetObject("btnThem3.Image")));
            this.btnThem3.Location = new System.Drawing.Point(158, 3);
            this.btnThem3.Name = "btnThem3";
            this.btnThem3.Size = new System.Drawing.Size(68, 30);
            this.btnThem3.TabIndex = 10;
            this.btnThem3.Text = "Thêm";
            this.btnThem3.Click += new System.EventHandler(this.btnThem3_Click);
            // 
            // btnSua3
            // 
            this.btnSua3.Image = ((System.Drawing.Image)(resources.GetObject("btnSua3.Image")));
            this.btnSua3.Location = new System.Drawing.Point(232, 3);
            this.btnSua3.Name = "btnSua3";
            this.btnSua3.Size = new System.Drawing.Size(68, 30);
            this.btnSua3.TabIndex = 11;
            this.btnSua3.Text = "Sừa";
            this.btnSua3.Click += new System.EventHandler(this.btnSua3_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtNoiDung);
            this.groupPanel1.Controls.Add(this.txtGiaTri);
            this.groupPanel1.Controls.Add(this.labelControl4);
            this.groupPanel1.Controls.Add(this.labelControl6);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 330);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(533, 170);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Nội dung tiền công:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(231, 23);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(136, 64);
            this.txtNoiDung.TabIndex = 10;
            this.txtNoiDung.Text = "";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(231, 106);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(136, 20);
            this.txtGiaTri.TabIndex = 9;
            this.txtGiaTri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTri_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(160, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Giá trị:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(160, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Nội dung:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableDanhSachTienCong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(533, 294);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách tiền công:";
            // 
            // tableDanhSachTienCong
            // 
            this.tableDanhSachTienCong.AutoGenerateColumns = false;
            this.tableDanhSachTienCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDanhSachTienCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDanhSachTienCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noiDungSuaChuaDataGridViewTextBoxColumn,
            this.tienCongDataGridViewTextBoxColumn});
            this.tableDanhSachTienCong.DataSource = this.spTienCongGetAllBindingSource;
            this.tableDanhSachTienCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDanhSachTienCong.Location = new System.Drawing.Point(2, 21);
            this.tableDanhSachTienCong.Name = "tableDanhSachTienCong";
            this.tableDanhSachTienCong.Size = new System.Drawing.Size(529, 271);
            this.tableDanhSachTienCong.TabIndex = 0;
            this.tableDanhSachTienCong.Click += new System.EventHandler(this.tableDanhSachTienCong_Click);
            // 
            // noiDungSuaChuaDataGridViewTextBoxColumn
            // 
            this.noiDungSuaChuaDataGridViewTextBoxColumn.DataPropertyName = "NoiDungSuaChua";
            this.noiDungSuaChuaDataGridViewTextBoxColumn.HeaderText = "Nội dung sửa chữa";
            this.noiDungSuaChuaDataGridViewTextBoxColumn.Name = "noiDungSuaChuaDataGridViewTextBoxColumn";
            // 
            // tienCongDataGridViewTextBoxColumn
            // 
            this.tienCongDataGridViewTextBoxColumn.DataPropertyName = "TienCong";
            this.tienCongDataGridViewTextBoxColumn.HeaderText = "Tiền công";
            this.tienCongDataGridViewTextBoxColumn.Name = "tienCongDataGridViewTextBoxColumn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.39416F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.60584F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmTienCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTienCong";
            this.Text = "Tiền công";
            this.Load += new System.EventHandler(this.frmTienCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spTienCongGetAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSachTienCong)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QUAN_LY_GARA_OTODataSet qUAN_LY_GARA_OTODataSet;
        private System.Windows.Forms.BindingSource spTienCongGetAllBindingSource;
        private QUAN_LY_GARA_OTODataSetTableAdapters.sp_TienCong_GetAllTableAdapter sp_TienCong_GetAllTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa3;
        private DevExpress.XtraEditors.SimpleButton btnThem3;
        private DevExpress.XtraEditors.SimpleButton btnSua3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtGiaTri;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView tableDanhSachTienCong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungSuaChuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienCongDataGridViewTextBoxColumn;
    }
}