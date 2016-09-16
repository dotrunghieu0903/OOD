namespace GaraUI
{
    partial class frmHieuXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHieuXe));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableDanhSachHieuXe = new System.Windows.Forms.DataGridView();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem1 = new DevExpress.XtraEditors.SimpleButton();
            this.qUAN_LY_GARA_OTODataSet = new GaraUI.QUAN_LY_GARA_OTODataSet();
            this.spHieuXeGetHieuXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_HieuXe_GetHieuXeTableAdapter = new GaraUI.QUAN_LY_GARA_OTODataSetTableAdapters.sp_HieuXe_GetHieuXeTableAdapter();
            this.hieuXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSachHieuXe)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHieuXeGetHieuXeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 508);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableDanhSachHieuXe);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 27);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(554, 260);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách hiệu xe:";
            // 
            // tableDanhSachHieuXe
            // 
            this.tableDanhSachHieuXe.AutoGenerateColumns = false;
            this.tableDanhSachHieuXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDanhSachHieuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDanhSachHieuXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hieuXeDataGridViewTextBoxColumn});
            this.tableDanhSachHieuXe.DataSource = this.spHieuXeGetHieuXeBindingSource;
            this.tableDanhSachHieuXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDanhSachHieuXe.Location = new System.Drawing.Point(2, 21);
            this.tableDanhSachHieuXe.Name = "tableDanhSachHieuXe";
            this.tableDanhSachHieuXe.Size = new System.Drawing.Size(550, 237);
            this.tableDanhSachHieuXe.TabIndex = 0;
            this.tableDanhSachHieuXe.Click += new System.EventHandler(this.tableDanhSachHieuXe_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtHieuXe);
            this.groupPanel1.Controls.Add(this.labelControl11);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 293);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(554, 170);
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
            this.groupPanel1.Text = "Thông tin hiệu xe:";
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtHieuXe.Location = new System.Drawing.Point(191, 72);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(211, 23);
            this.txtHieuXe.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl11.Location = new System.Drawing.Point(200, 49);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(76, 17);
            this.labelControl11.TabIndex = 6;
            this.labelControl11.Text = "Tên hiệu xe:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXoa1);
            this.panelControl1.Controls.Add(this.btnThem1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 469);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(554, 36);
            this.panelControl1.TabIndex = 3;
            // 
            // btnXoa1
            // 
            this.btnXoa1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa1.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa1.Image")));
            this.btnXoa1.Location = new System.Drawing.Point(268, 1);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(68, 30);
            this.btnXoa1.TabIndex = 8;
            this.btnXoa1.Text = "Xoá";
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem1.Image = ((System.Drawing.Image)(resources.GetObject("btnThem1.Image")));
            this.btnThem1.Location = new System.Drawing.Point(194, 1);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(68, 30);
            this.btnThem1.TabIndex = 6;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // qUAN_LY_GARA_OTODataSet
            // 
            this.qUAN_LY_GARA_OTODataSet.DataSetName = "QUAN_LY_GARA_OTODataSet";
            this.qUAN_LY_GARA_OTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spHieuXeGetHieuXeBindingSource
            // 
            this.spHieuXeGetHieuXeBindingSource.DataMember = "sp_HieuXe_GetHieuXe";
            this.spHieuXeGetHieuXeBindingSource.DataSource = this.qUAN_LY_GARA_OTODataSet;
            // 
            // sp_HieuXe_GetHieuXeTableAdapter
            // 
            this.sp_HieuXe_GetHieuXeTableAdapter.ClearBeforeFill = true;
            // 
            // hieuXeDataGridViewTextBoxColumn
            // 
            this.hieuXeDataGridViewTextBoxColumn.DataPropertyName = "HieuXe";
            this.hieuXeDataGridViewTextBoxColumn.HeaderText = "HieuXe";
            this.hieuXeDataGridViewTextBoxColumn.Name = "hieuXeDataGridViewTextBoxColumn";
            // 
            // frmHieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmHieuXe";
            this.Text = "Hiệu xe";
            this.Load += new System.EventHandler(this.frmHieuXe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSachHieuXe)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_GARA_OTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHieuXeGetHieuXeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView tableDanhSachHieuXe;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtHieuXe;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnXoa1;
        private DevExpress.XtraEditors.SimpleButton btnThem1;
        private QUAN_LY_GARA_OTODataSet qUAN_LY_GARA_OTODataSet;
        private System.Windows.Forms.BindingSource spHieuXeGetHieuXeBindingSource;
        private QUAN_LY_GARA_OTODataSetTableAdapters.sp_HieuXe_GetHieuXeTableAdapter sp_HieuXe_GetHieuXeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hieuXeDataGridViewTextBoxColumn;
    }
}