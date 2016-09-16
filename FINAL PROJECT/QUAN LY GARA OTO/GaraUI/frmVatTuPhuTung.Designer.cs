namespace GaraUI
{
    partial class frmVatTuPhuTung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTuPhuTung));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableDanhSachVTPT = new System.Windows.Forms.DataGridView();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANLYGARAOTODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_GARA_OTODataSet = new GaraUI.QUAN_LY_GARA_OTODataSet();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnKhoVatTu = new DevComponents.DotNetBar.ButtonX();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhaSanXuat = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVTPT = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaPhieuNhap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.spVatTuPhuTungGetAllBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cTPhieuSuaChuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PhieuSuaChuaTableAdapter = new GaraUI.QUAN_LY_GARA_OTODataSetTableAdapters.CT_PhieuSuaChuaTableAdapter();
            this.spVatTuPhuTungGetAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_VatTuPhuTung_GetAllTableAdapter = new GaraUI.QUAN_LY_GARA_OTODataSetTableAdapters.sp_VatTuPhuTung_GetAllTableAdapter();
            this.cTPhieuSuaChuaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSachVTPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGARAOTODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spVatTuPhuTungGetAllBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuSuaChuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVatTuPhuTungGetAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuSuaChuaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.58242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.41758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 491);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableDanhSachVTPT);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(766, 219);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách vật tư phụ tùng:";
            // 
            // tableDanhSachVTPT
            // 
            this.tableDanhSachVTPT.AutoGenerateColumns = false;
            this.tableDanhSachVTPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDanhSachVTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDanhSachVTPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuNhap,
            this.MaVatTu,
            this.NhaSX,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien,
            this.DiaDiem,
            this.NgayNhapHang});
            this.tableDanhSachVTPT.DataSource = this.qUANLYGARAOTODataSetBindingSource;
            this.tableDanhSachVTPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDanhSachVTPT.Location = new System.Drawing.Point(2, 21);
            this.tableDanhSachVTPT.Name = "tableDanhSachVTPT";
            this.tableDanhSachVTPT.Size = new System.Drawing.Size(762, 196);
            this.tableDanhSachVTPT.TabIndex = 0;
            this.tableDanhSachVTPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDanhSachVTPT_CellContentClick);
            this.tableDanhSachVTPT.Click += new System.EventHandler(this.tableDanhSachVTPT_Click);
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.FillWeight = 120F;
            this.MaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaVatTu
            // 
            this.MaVatTu.DataPropertyName = "MaVatTu";
            this.MaVatTu.HeaderText = "Mã Vật Tư";
            this.MaVatTu.Name = "MaVatTu";
            // 
            // NhaSX
            // 
            this.NhaSX.DataPropertyName = "NhaSX";
            this.NhaSX.HeaderText = "Nhà sản xuất";
            this.NhaSX.Name = "NhaSX";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.Name = "DiaDiem";
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.DataPropertyName = "NgayNhapHang";
            this.NgayNhapHang.HeaderText = "Ngày Nhập Hàng";
            this.NgayNhapHang.Name = "NgayNhapHang";
            // 
            // qUANLYGARAOTODataSetBindingSource
            // 
            this.qUANLYGARAOTODataSetBindingSource.DataSource = this.qUAN_LY_GARA_OTODataSet;
            this.qUANLYGARAOTODataSetBindingSource.Position = 0;
            // 
            // qUAN_LY_GARA_OTODataSet
            // 
            this.qUAN_LY_GARA_OTODataSet.DataSetName = "QUAN_LY_GARA_OTODataSet";
            this.qUAN_LY_GARA_OTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnKhoVatTu);
            this.groupPanel1.Controls.Add(this.txtTongTien);
            this.groupPanel1.Controls.Add(this.txtDiaDiem);
            this.groupPanel1.Controls.Add(this.txtThanhTien);
            this.groupPanel1.Controls.Add(this.labelControl7);
            this.groupPanel1.Controls.Add(this.txtNhaSanXuat);
            this.groupPanel1.Controls.Add(this.labelControl8);
            this.groupPanel1.Controls.Add(this.labelControl5);
            this.groupPanel1.Controls.Add(this.labelControl3);
            this.groupPanel1.Controls.Add(this.txtSoLuong);
            this.groupPanel1.Controls.Add(this.txtDonGia);
            this.groupPanel1.Controls.Add(this.labelControl2);
            this.groupPanel1.Controls.Add(this.labelControl1);
            this.groupPanel1.Controls.Add(this.txtVTPT);
            this.groupPanel1.Controls.Add(this.labelControl11);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 276);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(766, 170);
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
            this.groupPanel1.Text = "Thông tin VTPT:";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // btnKhoVatTu
            // 
            this.btnKhoVatTu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKhoVatTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoVatTu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKhoVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnKhoVatTu.Location = new System.Drawing.Point(623, 93);
            this.btnKhoVatTu.Name = "btnKhoVatTu";
            this.btnKhoVatTu.Size = new System.Drawing.Size(100, 39);
            this.btnKhoVatTu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKhoVatTu.TabIndex = 25;
            this.btnKhoVatTu.Text = "Kho Vật Tư";
            this.btnKhoVatTu.Click += new System.EventHandler(this.btnKhoVatTu_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTongTien.Location = new System.Drawing.Point(612, 18);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(137, 20);
            this.txtTongTien.TabIndex = 24;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDiaDiem.Location = new System.Drawing.Point(344, 18);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(137, 20);
            this.txtDiaDiem.TabIndex = 23;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtThanhTien.Location = new System.Drawing.Point(612, 53);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(137, 20);
            this.txtThanhTien.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl7.Location = new System.Drawing.Point(530, 21);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Tổng tiền:";
            // 
            // txtNhaSanXuat
            // 
            this.txtNhaSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNhaSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNhaSanXuat.Location = new System.Drawing.Point(343, 57);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(137, 20);
            this.txtNhaSanXuat.TabIndex = 20;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl8.Location = new System.Drawing.Point(249, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Địa điểm:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl5.Location = new System.Drawing.Point(524, 56);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Thành tiền:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Location = new System.Drawing.Point(249, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Nhà sản xuất:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSoLuong.Location = new System.Drawing.Point(79, 93);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(137, 20);
            this.txtSoLuong.TabIndex = 11;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongTon_KeyPress);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDonGia.Location = new System.Drawing.Point(79, 57);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(137, 20);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Location = new System.Drawing.Point(16, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Đơn giá:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Location = new System.Drawing.Point(16, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Số lượng:";
            // 
            // txtVTPT
            // 
            this.txtVTPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtVTPT.Location = new System.Drawing.Point(79, 18);
            this.txtVTPT.Name = "txtVTPT";
            this.txtVTPT.Size = new System.Drawing.Size(137, 20);
            this.txtVTPT.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl11.Location = new System.Drawing.Point(17, 18);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 13);
            this.labelControl11.TabIndex = 6;
            this.labelControl11.Text = "Mã VTPT:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXoa2);
            this.panelControl1.Controls.Add(this.btnThem2);
            this.panelControl1.Controls.Add(this.btnThemChiTiet);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 452);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(766, 36);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXoa2.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa2.Image")));
            this.btnXoa2.Location = new System.Drawing.Point(441, 1);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(131, 30);
            this.btnXoa2.TabIndex = 8;
            this.btnXoa2.Text = "Xoá";
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnThem2
            // 
            this.btnThem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThem2.Image = ((System.Drawing.Image)(resources.GetObject("btnThem2.Image")));
            this.btnThem2.Location = new System.Drawing.Point(169, 1);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(131, 30);
            this.btnThem2.TabIndex = 6;
            this.btnThem2.Text = "Thêm Mới";
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThemChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnThemChiTiet.Image")));
            this.btnThemChiTiet.Location = new System.Drawing.Point(305, 1);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(131, 30);
            this.btnThemChiTiet.TabIndex = 7;
            this.btnThemChiTiet.Text = "Thêm Chi Tiết";
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbMaPhieuNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpNgayNhapHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 42);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã Phiếu Nhập:";
            // 
            // cbMaPhieuNhap
            // 
            this.cbMaPhieuNhap.FormattingEnabled = true;
            this.cbMaPhieuNhap.Location = new System.Drawing.Point(118, 9);
            this.cbMaPhieuNhap.Name = "cbMaPhieuNhap";
            this.cbMaPhieuNhap.Size = new System.Drawing.Size(121, 21);
            this.cbMaPhieuNhap.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày nhập hàng:";
            // 
            // dtpNgayNhapHang
            // 
            this.dtpNgayNhapHang.Location = new System.Drawing.Point(382, 10);
            this.dtpNgayNhapHang.Name = "dtpNgayNhapHang";
            this.dtpNgayNhapHang.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayNhapHang.TabIndex = 0;
            // 
            // spVatTuPhuTungGetAllBindingSource1
            // 
            this.spVatTuPhuTungGetAllBindingSource1.DataMember = "sp_VatTuPhuTung_GetAll";
            this.spVatTuPhuTungGetAllBindingSource1.DataSource = this.qUANLYGARAOTODataSetBindingSource;
            // 
            // cTPhieuSuaChuaBindingSource
            // 
            this.cTPhieuSuaChuaBindingSource.DataMember = "CT_PhieuSuaChua";
            this.cTPhieuSuaChuaBindingSource.DataSource = this.qUANLYGARAOTODataSetBindingSource;
            // 
            // cT_PhieuSuaChuaTableAdapter
            // 
            this.cT_PhieuSuaChuaTableAdapter.ClearBeforeFill = true;
            // 
            // spVatTuPhuTungGetAllBindingSource
            // 
            this.spVatTuPhuTungGetAllBindingSource.DataMember = "sp_VatTuPhuTung_GetAll";
            this.spVatTuPhuTungGetAllBindingSource.DataSource = this.qUANLYGARAOTODataSetBindingSource;
            // 
            // sp_VatTuPhuTung_GetAllTableAdapter
            // 
            this.sp_VatTuPhuTung_GetAllTableAdapter.ClearBeforeFill = true;
            // 
            // cTPhieuSuaChuaBindingSource1
            // 
            this.cTPhieuSuaChuaBindingSource1.DataMember = "CT_PhieuSuaChua";
            this.cTPhieuSuaChuaBindingSource1.DataSource = this.qUANLYGARAOTODataSetBindingSource;
            // 
            // frmVatTuPhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmVatTuPhuTung";
            this.Text = "Vật tư phụ tùng";
            this.Load += new System.EventHandler(this.frmVatTuPhuTung_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSachVTPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGARAOTODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spVatTuPhuTungGetAllBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuSuaChuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVatTuPhuTungGetAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuSuaChuaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtVTPT;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa2;
        private DevExpress.XtraEditors.SimpleButton btnThem2;
        private DevExpress.XtraEditors.SimpleButton btnThemChiTiet;
        private System.Windows.Forms.BindingSource qUANLYGARAOTODataSetBindingSource;
        private QUAN_LY_GARA_OTODataSet qUAN_LY_GARA_OTODataSet;
        private System.Windows.Forms.BindingSource cTPhieuSuaChuaBindingSource;
        private QUAN_LY_GARA_OTODataSetTableAdapters.CT_PhieuSuaChuaTableAdapter cT_PhieuSuaChuaTableAdapter;
        private System.Windows.Forms.BindingSource spVatTuPhuTungGetAllBindingSource;
        private QUAN_LY_GARA_OTODataSetTableAdapters.sp_VatTuPhuTung_GetAllTableAdapter sp_VatTuPhuTung_GetAllTableAdapter;
        private System.Windows.Forms.BindingSource spVatTuPhuTungGetAllBindingSource1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtNhaSanXuat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapHang;
        private System.Windows.Forms.BindingSource cTPhieuSuaChuaBindingSource1;
        private System.Windows.Forms.DataGridView tableDanhSachVTPT;
        private System.Windows.Forms.ComboBox cbMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapHang;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnKhoVatTu;

    }
}