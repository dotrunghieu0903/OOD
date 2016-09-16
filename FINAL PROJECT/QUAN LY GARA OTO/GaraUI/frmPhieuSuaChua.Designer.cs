namespace GaraUI
{
    partial class frmPhieuSuaChua
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tablePhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.MaSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungSuaChuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maVatTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPhieuSuaChuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_GARA_OTODataSet = new GaraUI.QUAN_LY_GARA_OTODataSet();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtpNgaySuaChua = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbcSoLuongTon = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbNoiDung = new System.Windows.Forms.ComboBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.cbVatTuPhuTung = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTienCong = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaSuaChua = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBienSo = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cT_PhieuSuaChuaTableAdapter = new GaraUI.QUAN_LY_GARA_OTODataSetTableAdapters.CT_PhieuSuaChuaTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuSuaChua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuSuaChuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.24719F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.75281F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.tablePhieuSuaChua);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 95);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(875, 241);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Thông tin phiếu sửa chữa";
            // 
            // tablePhieuSuaChua
            // 
            this.tablePhieuSuaChua.AutoGenerateColumns = false;
            this.tablePhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePhieuSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSuaChua,
            this.noiDungSuaChuaDataGridViewTextBoxColumn,
            this.NgaySuaChua,
            this.tienCongDataGridViewTextBoxColumn,
            this.maVatTuDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.tablePhieuSuaChua.DataSource = this.cTPhieuSuaChuaBindingSource;
            this.tablePhieuSuaChua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePhieuSuaChua.Location = new System.Drawing.Point(0, 0);
            this.tablePhieuSuaChua.Name = "tablePhieuSuaChua";
            this.tablePhieuSuaChua.Size = new System.Drawing.Size(869, 220);
            this.tablePhieuSuaChua.TabIndex = 0;
            this.tablePhieuSuaChua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePhieuSuaChua_CellClick);
            // 
            // MaSuaChua
            // 
            this.MaSuaChua.DataPropertyName = "MaSuaChua";
            this.MaSuaChua.HeaderText = "Mã Sửa Chữa";
            this.MaSuaChua.Name = "MaSuaChua";
            // 
            // noiDungSuaChuaDataGridViewTextBoxColumn
            // 
            this.noiDungSuaChuaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiDungSuaChuaDataGridViewTextBoxColumn.DataPropertyName = "NoiDungSuaChua";
            this.noiDungSuaChuaDataGridViewTextBoxColumn.HeaderText = "Nội dung sửa chữa";
            this.noiDungSuaChuaDataGridViewTextBoxColumn.Name = "noiDungSuaChuaDataGridViewTextBoxColumn";
            // 
            // NgaySuaChua
            // 
            this.NgaySuaChua.DataPropertyName = "NgaySuaChua";
            this.NgaySuaChua.HeaderText = "Ngày Sửa Chữa";
            this.NgaySuaChua.Name = "NgaySuaChua";
            // 
            // tienCongDataGridViewTextBoxColumn
            // 
            this.tienCongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tienCongDataGridViewTextBoxColumn.DataPropertyName = "TienCong";
            this.tienCongDataGridViewTextBoxColumn.HeaderText = "Tiền công";
            this.tienCongDataGridViewTextBoxColumn.Name = "tienCongDataGridViewTextBoxColumn";
            // 
            // maVatTuDataGridViewTextBoxColumn
            // 
            this.maVatTuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maVatTuDataGridViewTextBoxColumn.DataPropertyName = "MaVatTu";
            this.maVatTuDataGridViewTextBoxColumn.HeaderText = "Mã vật tư";
            this.maVatTuDataGridViewTextBoxColumn.Name = "maVatTuDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // cTPhieuSuaChuaBindingSource
            // 
            this.cTPhieuSuaChuaBindingSource.DataMember = "CT_PhieuSuaChua";
            this.cTPhieuSuaChuaBindingSource.DataSource = this.qUAN_LY_GARA_OTODataSet;
            // 
            // qUAN_LY_GARA_OTODataSet
            // 
            this.qUAN_LY_GARA_OTODataSet.DataSetName = "QUAN_LY_GARA_OTODataSet";
            this.qUAN_LY_GARA_OTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dtpNgaySuaChua);
            this.groupPanel2.Controls.Add(this.labelControl3);
            this.groupPanel2.Controls.Add(this.lbcSoLuongTon);
            this.groupPanel2.Controls.Add(this.labelControl10);
            this.groupPanel2.Controls.Add(this.txtThanhTien);
            this.groupPanel2.Controls.Add(this.labelControl4);
            this.groupPanel2.Controls.Add(this.labelControl2);
            this.groupPanel2.Controls.Add(this.cbNoiDung);
            this.groupPanel2.Controls.Add(this.btnXoa);
            this.groupPanel2.Controls.Add(this.btnThemChiTiet);
            this.groupPanel2.Controls.Add(this.btnThemMoi);
            this.groupPanel2.Controls.Add(this.cbVatTuPhuTung);
            this.groupPanel2.Controls.Add(this.txtSoLuong);
            this.groupPanel2.Controls.Add(this.txtDonGia);
            this.groupPanel2.Controls.Add(this.txtTienCong);
            this.groupPanel2.Controls.Add(this.labelControl9);
            this.groupPanel2.Controls.Add(this.labelControl8);
            this.groupPanel2.Controls.Add(this.labelControl7);
            this.groupPanel2.Controls.Add(this.labelControl6);
            this.groupPanel2.Controls.Add(this.labelControl5);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(3, 342);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(875, 165);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "+";
            // 
            // dtpNgaySuaChua
            // 
            this.dtpNgaySuaChua.Location = new System.Drawing.Point(274, 86);
            this.dtpNgaySuaChua.Name = "dtpNgaySuaChua";
            this.dtpNgaySuaChua.Size = new System.Drawing.Size(202, 20);
            this.dtpNgaySuaChua.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl3.Location = new System.Drawing.Point(164, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 16);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Ngày sửa chữa:";
            // 
            // lbcSoLuongTon
            // 
            this.lbcSoLuongTon.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbcSoLuongTon.Location = new System.Drawing.Point(812, 89);
            this.lbcSoLuongTon.Name = "lbcSoLuongTon";
            this.lbcSoLuongTon.Size = new System.Drawing.Size(6, 13);
            this.lbcSoLuongTon.TabIndex = 25;
            this.lbcSoLuongTon.Text = "0";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl10.Location = new System.Drawing.Point(741, 89);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(65, 13);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Số lượng tồn:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtThanhTien.Location = new System.Drawing.Point(731, 118);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(100, 21);
            this.txtThanhTien.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl4.Location = new System.Drawing.Point(660, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 16);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Thành Tiền:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl2.Location = new System.Drawing.Point(837, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "VND";
            // 
            // cbNoiDung
            // 
            this.cbNoiDung.FormattingEnabled = true;
            this.cbNoiDung.Location = new System.Drawing.Point(274, 51);
            this.cbNoiDung.Name = "cbNoiDung";
            this.cbNoiDung.Size = new System.Drawing.Size(202, 21);
            this.cbNoiDung.TabIndex = 19;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(32, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 41);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Location = new System.Drawing.Point(32, 48);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(81, 41);
            this.btnThemChiTiet.TabIndex = 16;
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(32, 4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(81, 41);
            this.btnThemMoi.TabIndex = 16;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbVatTuPhuTung
            // 
            this.cbVatTuPhuTung.FormattingEnabled = true;
            this.cbVatTuPhuTung.Location = new System.Drawing.Point(274, 17);
            this.cbVatTuPhuTung.Name = "cbVatTuPhuTung";
            this.cbVatTuPhuTung.Size = new System.Drawing.Size(202, 21);
            this.cbVatTuPhuTung.TabIndex = 13;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(605, 86);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 20);
            this.txtSoLuong.TabIndex = 12;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(605, 17);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(120, 20);
            this.txtDonGia.TabIndex = 11;
            // 
            // txtTienCong
            // 
            this.txtTienCong.Location = new System.Drawing.Point(605, 52);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.ReadOnly = true;
            this.txtTienCong.Size = new System.Drawing.Size(120, 20);
            this.txtTienCong.TabIndex = 10;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl9.Location = new System.Drawing.Point(506, 89);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Số lượng:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl8.Location = new System.Drawing.Point(504, 20);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Đơn giá:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl7.Location = new System.Drawing.Point(167, 20);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Vật tư phụ tùng:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl6.Location = new System.Drawing.Point(502, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Tiền công:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl5.Location = new System.Drawing.Point(201, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Nội dung:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl11);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.txtMaSuaChua);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbBienSo);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 86);
            this.panel1.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl11.Location = new System.Drawing.Point(244, 37);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(65, 13);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "Mã Sửa Chữa";
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnIn.Location = new System.Drawing.Point(762, 23);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(81, 41);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In hoá đơn";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtMaSuaChua
            // 
            this.txtMaSuaChua.Enabled = false;
            this.txtMaSuaChua.Location = new System.Drawing.Point(328, 34);
            this.txtMaSuaChua.Name = "txtMaSuaChua";
            this.txtMaSuaChua.Size = new System.Drawing.Size(141, 20);
            this.txtMaSuaChua.TabIndex = 11;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(593, 35);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(506, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền:";
            // 
            // cbBienSo
            // 
            this.cbBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cbBienSo.FormattingEnabled = true;
            this.cbBienSo.Location = new System.Drawing.Point(97, 32);
            this.cbBienSo.Name = "cbBienSo";
            this.cbBienSo.Size = new System.Drawing.Size(121, 23);
            this.cbBienSo.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl1.Location = new System.Drawing.Point(45, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Biển số:";
            // 
            // cT_PhieuSuaChuaTableAdapter
            // 
            this.cT_PhieuSuaChuaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPhieuSuaChua";
            this.Text = "Phiếu sửa chữa";
            this.Load += new System.EventHandler(this.frmPhieuSuaChua_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuSuaChua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuSuaChuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView tablePhieuSuaChua;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private System.Windows.Forms.ComboBox cbVatTuPhuTung;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTienCong;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBienSo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QUAN_LY_GARA_OTODataSet qUAN_LY_GARA_OTODataSet;
        private System.Windows.Forms.BindingSource cTPhieuSuaChuaBindingSource;
        private QUAN_LY_GARA_OTODataSetTableAdapters.CT_PhieuSuaChuaTableAdapter cT_PhieuSuaChuaTableAdapter;
        private System.Windows.Forms.ComboBox cbNoiDung;
        private System.Windows.Forms.TextBox txtThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lbcSoLuongTon;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungSuaChuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVatTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThemChiTiet;
        private System.Windows.Forms.DateTimePicker dtpNgaySuaChua;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TextBox txtMaSuaChua;
    }
}