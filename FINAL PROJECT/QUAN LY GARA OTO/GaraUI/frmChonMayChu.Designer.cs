namespace GaraUI
{
    partial class frmChonMayChu
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
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.btnKetNoi = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.lblThongBao = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(56, 38);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(443, 21);
            this.cbServer.TabIndex = 0;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKetNoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKetNoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetNoi.Location = new System.Drawing.Point(153, 206);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(102, 34);
            this.btnKetNoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKetNoi.TabIndex = 1;
            this.btnKetNoi.Text = "Kết Nối";
            this.btnKetNoi.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(329, 206);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 34);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblThongBao
            // 
            // 
            // 
            // 
            this.lblThongBao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Maroon;
            this.lblThongBao.Location = new System.Drawing.Point(56, 81);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(443, 73);
            this.lblThongBao.TabIndex = 3;
            this.lblThongBao.Text = "Chương trình sẽ tự động kết nối đến máy chủ này trong những\r\n lần khởi động về sa" +
    "u.\r\nĐể chọn kết nối tới máy chủ khác: Hệ Thống->Đổi Máy Chủ";
            // 
            // frmChonMayChu
            // 
            this.ClientSize = new System.Drawing.Size(564, 276);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.cbServer);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmChonMayChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Máy Chủ";
            this.Load += new System.EventHandler(this.frmChonMayChu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbServer;
        private DevComponents.DotNetBar.ButtonX btnKetNoi;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.LabelX lblThongBao;

    }
}