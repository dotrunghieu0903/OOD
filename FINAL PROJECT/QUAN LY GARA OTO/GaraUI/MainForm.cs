using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using GaraDATA;
using GaraBUSSINESS;

namespace GaraUI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        MayChuBUS BusMayChu_Temp;   //Khai báo biến toàn cục
        //Constructor của MainForm
        public MainForm()
        {
            BusMayChu_Temp= new MayChuBUS();
            InitializeComponent();
        }
        //Hàm kiểm tra trả về các Tab
        public bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
            {
                if (superTabControl1.Tabs[i].Text == name)
                {
                    superTabControl1.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        
        //Hàm tiếp nhận xe 
        private void btnTiepNhanXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Tiếp nhận xe sửa chữa"))
            {
                //cài đặt các thuộc tính cho form tiếp nhận xe và tab hiện tại
                SuperTabItem t = superTabControl1.CreateTab("Tiếp nhận xe sửa chữa");
                frmTiepNhanXe frm = new frmTiepNhanXe();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }


        //Hàm phiếu sửa chữa
        private void btnPhieuSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Phiếu sửa chữa"))
            {
                //cài đặt các thuộc tính cho form phiếu sửa chữa và tab hiện tại
                SuperTabItem t = superTabControl1.CreateTab("Phiếu sửa chữa");
                frmPhieuSuaChua frm = new frmPhieuSuaChua();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }
        //Hàm nhập vật tư
        private void btnVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Nhập vật tư phụ tùng"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Nhập vật tư phụ tùng");
                frmVatTuPhuTung frm = new frmVatTuPhuTung();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        //Hàm show form phiếu thu tiền và cài đặt các thuộc tính cho form và tab
        private void btnPhieuThuTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Phiếu thu tiền"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Phiếu thu tiền");
                frmPhieuThuTien frm = new frmPhieuThuTien();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }
        //Hàm báo cáo tồn và các thuộc tính cài đặt
        private void btnBaoCaoTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Báo cáo tồn"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Báo cáo tồn");
                frmBaoCaoTon frm = new frmBaoCaoTon();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }
        //Hàm báo cáo doanh số và các thuộc tính cài đặt
        private void btnDoanhSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Doanh số"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Doanh số");
                frmDoanhSo frm = new frmDoanhSo();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }

        //Hàm tìm kiếm xe với các thuộc tính cài đặt
        private void btnTimKiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Tìm kiếm xe"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Tìm kiếm xe");
                frmTimKiemXe frm = new frmTimKiemXe();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }
        //Hàm chỉnh sửa hiệu xe
        private void btnSoLuongHieuXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Chỉnh sửa hiệu xe"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Chỉnh sửa hiệu xe");
                frmHieuXe frm = new frmHieuXe();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }
        //Hàm quản lý tiền công
        private void btnTienCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Quản lí tiền công"))
            {
                SuperTabItem t = superTabControl1.CreateTab("Quản lí tiền công");
                frmTienCong frm = new frmTienCong();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTabControl1.SelectedTabIndex = superTabControl1.Tabs.Count - 1;
            }
            else
                superTabControl1.TabIndex = superTabControl1.Tabs.Count - 1;
        }
        //Hàm cập nhật số lượng sửa chữa xe mỗi ngày
        private void btnCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SqlDataProvider con = new SqlDataProvider();
            SqlCommand cmd = new SqlCommand("sp_ThayDoiSoLuotSua", con.GetConnection());
            int SoLuotSua = int.Parse(barEditItem1.EditValue.ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SoLuotSuaChua", SoLuotSua));
            cmd.ExecuteNonQuery();
            SqlDataProvider.connection.Close();
            MessageBox.Show("Cập nhật số lượt sửa xe thành công !");

        }

     
        //Hàm kiểm tra đăng nhập nếu chưa đăng nhập thì tất cả các chức năng chính của phần mềm đều không sử dụng được
        public void HamDangNhap(bool dn)
        {
            if (dn == false)
            {
                
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage4.Visible = false;
                ribbonPage5.Visible = false;
                btnDangXuat.Enabled = false;
                superTabControl1.Visible = false;
            }
            else
            {
               
                btnDangNhap.Enabled = false;
                btnDangXuat.Enabled = true;
                if (NguoiDN.ChucVu == "Quan Ly")
                {
                    ribbonPage1.Visible = true;
                    ribbonPage2.Visible = true;
                    ribbonPage3.Visible = true;
                    ribbonPage4.Visible = true;
                    ribbonPage5.Visible = true;
                    superTabControl1.Visible = true;
                    MessageBox.Show("Đăng nhập thành công với tư cách người quản lý","THÔNG BÁO");

                }
                else if (NguoiDN.ChucVu == "Nhan Vien")
                {
                    ribbonPage1.Visible = true;
                    ribbonPage2.Visible = true;
                    ribbonPage3.Visible = true;
                    ribbonPage4.Visible = true;
                    superTabControl1.Visible = true;
                    MessageBox.Show("Đăng nhập thành công với tư cách nhân viên","THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Error","Warning");
                }
                    
            }

        }

        //Hàm đăng nhập
        private void btnDangNhap_Click(object sender, ItemClickEventArgs e)
        {
            //cài đặt form đăng nhập
            frmDangNhap frmDn = new frmDangNhap();
           frmDn.Owner = this;

            frmDn.Show();
            
        }
        //Hàm Load form chính
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Kiểm tra máy chủ tồn tại không và show form chọn máy chủ lên
            if ((BusMayChu_Temp.KiemTraTonTaiCuaMayChu(Properties.Settings.Default.QUAN_LY_GARA_OTOConnectionString.Split(';').First().Split('=').Last()) == false))
            {
                frmChonMayChu m_frmChonMayChu = new frmChonMayChu();
                m_frmChonMayChu.ShowDialog();
            }
            else
            {
                BusMayChu_Temp.LuuChuoiKetNoiMayChu("Server=" + Properties.Settings.Default.QUAN_LY_GARA_OTOConnectionString.Split(';').First().Split('=').Last() + ";Initial Catalog=QUAN LY GARA OTO ;Integrated Security = True");
            }
            //Kiểm tra CSDl có tồn tại không
            if ((BusMayChu_Temp.KiemTraTonTaiCuaCSDL(Properties.Settings.Default.QUAN_LY_GARA_OTOConnectionString.Split(';').First().Split('=').Last()) == false))
            {
                frmChonMayChu m_frmChonMayChu = new frmChonMayChu();
                m_frmChonMayChu.ShowDialog();
            }
            else
            {//File QuanLyGaraOto.mdf có tồn tại không? Nếu không chọn máy chủ nếu có lưu chuỗi kết nối
                if (File.Exists(Application.StartupPath + @"\QUAN LY GARA OTO.mdf") == false)
                {
                    frmChonMayChu m_frmChonMayChu = new frmChonMayChu();
                    m_frmChonMayChu.ShowDialog();
                }
                else
                {
                    BusMayChu_Temp.LuuChuoiKetNoiMayChu("Server=" + Properties.Settings.Default.QUAN_LY_GARA_OTOConnectionString.Split(';').First().Split('=').Last() + ";Initial Catalog=QUAN LY GARA OTO ;Integrated Security = True");
                }
            }
            HamDangNhap(false);//Hàm đăng nhập false thì các chức năng không sử dụng được
           
        }

        //Hàm đăng xuất 
        private void btnDangXuat_Click(object sender, ItemClickEventArgs e)
        {
            HamDangNhap(false);
            MessageBox.Show("Đăng Xuất Thành Công","Thông Báo");

            btnDangNhap.Enabled = true;
        }

        //Sao lưu dữ liệu
        private void btnSaoLuu_Click(object sender, ItemClickEventArgs e)
        {
                BusMayChu_Temp.SaoLuuDuLieuTuMayChu();
                MessageBox.Show("Sao lưu dữ liệu thành công!!!\nĐường dẫn tệp: E:\\HK6\\MAINTANCE\\FINAL PROJECT\\QUAN LY GARA OTO\\GaraUI\\bin\\Debug\\QUAN LY GARA OTO.bak", "Thông Báo");

        }

        //Hàm đổi máy chủ
        private void btnDoiMayChu_Click(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Sau khi đổi máy chủ toàn bộ dữ liệu sẽ bị mất.Hãy sao lưu dữ liệu trước\nBạn có chắc chắn là đã sao lưu và muốn tiếp tục?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmChonMayChu().ShowDialog();
            }
        }
        //Hàm ghi thông tin của nhóm phát triển và nhóm bảo trì
        private void btnThongTin_Click(object sender, ItemClickEventArgs e)
        {
            new frmThongTin().Show();
        }

         


    }
}