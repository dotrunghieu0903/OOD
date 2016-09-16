using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaraBUSSINESS;
using GaraDATA.Info;

namespace GaraUI
{
    public partial class frmDangNhap : Form
    {
        public bool DangNhap = false;//biến toàn cục kiểm tra đăng nhập 
        NhanVienBUS nv;
        public frmDangNhap()
        {
             nv= new NhanVienBUS();
            InitializeComponent();
        }

        //Hàm xử lý button login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            List<NhanVien> Ds_NhanVien = nv.LayDsNV();

            if (txtUser.TextLength > 0 && txtPass.TextLength > 0)
            {
                foreach(NhanVien dsNv in Ds_NhanVien)
                {
                    if(dsNv.Username==txtUser.Text && dsNv.Password==txtPass.Text)
                    {
                        //MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                        DangNhap = true;
                        NguoiDN.ChucVu = dsNv.ChucVu;
                        NguoiDN.MaNV = dsNv.MaNV;
                        NguoiDN.HoTen = dsNv.HoTen;
                       (this.Owner as MainForm).HamDangNhap(true);
                        this.Close();
                    }
                }
                if (DangNhap == false)
                {
                    if (MessageBox.Show("Đăng nhập thất bại. Bạn có muốn đăng nhập lại ", "Cảnh Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtUser.Focus();
                        txtUser.Clear();
                        txtPass.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không được để trống Username và Password","Thông Báo");
            }
         }

        //Hàm xử lý Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát","Hỏi");
            this.Close();
        }
    }
}
