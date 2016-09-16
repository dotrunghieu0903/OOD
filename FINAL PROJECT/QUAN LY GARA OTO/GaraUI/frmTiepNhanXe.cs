using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaraBUSSINESS;
using GaraDATA.Info;
using GaraDATA;

namespace GaraUI
{
    public partial class frmTiepNhanXe : MyFormPage
    {
        //Constructor class Tiếp nhận xe
        public frmTiepNhanXe()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;
            dateNgayTiepNhan.Format = DateTimePickerFormat.Custom;
            dateChonXe.Format = DateTimePickerFormat.Custom;
            dateNgayTiepNhan.CustomFormat = "dd/MM/yyyy";
        }
        //Hàm thêm thông tin khách hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KT())//Kiểm tra các textbox có trống không???
            {
                KhachHang kh = new KhachHang();
                try
                {
                    //Nhập thông tin và insert xuống CSDL
                    kh.TenChuXe = txtTenChuXe.Text;
                    kh.BienSo = txtBienSo.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.Email = txtEmail.Text;
                    kh.HieuXe = cbHieuXe.SelectedValue.ToString();
                    kh.DienThoai = int.Parse(txtDienThoai.Text);
                    kh.NgayTiepNhan = dateNgayTiepNhan.Text;
                    kh.TienNo = 0;
                    KhachHangBUS.KhachHang_Insert(kh);
                    MessageBox.Show("Nhập thành công !");
                    LoadDSxeTheoNgay(dateNgayTiepNhan.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SqlDataProvider.connection.Close();
                }
            }
        }
        //Hàm kiểm tra các textbox phải điền đầy dủ thông tin
        private bool KT()
        {
            if (txtTenChuXe.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên chủ xe không được để trống!");
                txtTenChuXe.Focus();
                return false;
            }
            if (txtBienSo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Biển số không được để trống!");
                txtBienSo.Focus();
                return false;
            }
            if (cbHieuXe.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hiệu xe chưa được chọn!");
                cbHieuXe.Focus();
                return false;
            }
            if (cbHieuXe.FindStringExact(cbHieuXe.Text) == -1)
            {
                MessageBox.Show("Hiệu xe không có trong Gara!");
                cbHieuXe.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                txtDiaChi.Focus();
                return false;
            }
            if (txtDienThoai.Text.Trim().Equals(""))
            {
                MessageBox.Show("Điện thoại không được để trống!");
                txtDienThoai.Focus();
                return false;
            }
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Email không được để trống!");
                txtEmail.Focus();
                return false;
            }
            //Tạo Datatable lưu danh sách khách hàng
            DataTable dt = KhachHangBUS.KhachHang_DanhSach();
            //Tạo dataview sắp xếp nó theo Biển Số
            DataView dv = dt.DefaultView;
            dv.Sort = "BienSo";
            
            if (dv.Find(txtBienSo.Text) != -1)
            {
                MessageBox.Show("Biển số đã có!");
                txtBienSo.Focus();
                return false;
            }
            if (KhachHangBUS.KhachHang_CountDStheoNgay(dateNgayTiepNhan.Text) >= KhachHangBUS.SoLuotSuaXe())
            {
                MessageBox.Show("Số xe tiếp nhận đã đủ "+KhachHangBUS.SoLuotSuaXe()+" chiếc", "Thông Báo");
                return false;

            }
            return true;
        }

        //Hàm tiếp nhận xe trong ngày giới hạn số lượng xe sửa chữa trong 1 ngày
        
        private void SoXeTiepNhanTrongNgay(string Ngay)
        {
            int count = KhachHangBUS.KhachHang_CountDStheoNgay(Ngay);
            if (count < KhachHangBUS.SoLuotSuaXe())
            {
                lbSoXeTiepNhan.Text = "Số xe đã tiếp nhận trong ngày: " + count.ToString();
            }
            else
            {
                MessageBox.Show("Số xe tiếp nhận trong ngày đã đủ!");
            }
        }

        //Hàm Load lên form Tiếp nhận xe 
        private void frmTiepNhanXe_Load(object sender, EventArgs e)
        {
            try
            {
                //Load Source tất cả hiệu xe, load theo ngày
                cbHieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();
                cbHieuXe.DisplayMember = "HieuXe";
                cbHieuXe.ValueMember = "HieuXe";
                LoadDSxeTheoNgay(DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlDataProvider.connection.Close();
            }
        }

        //Hàm Load danh sách xe theo ngày 
        private void LoadDSxeTheoNgay(string Ngay)
        {
            try
            {
                tableTiepNhanXe.DataSource = KhachHangBUS.KhachHang_DStheoNgay(Ngay);
                SoXeTiepNhanTrongNgay(Ngay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        //hàm thay đổi giá trị ngày chọn xe
        private void dateChonXe_ValueChanged(object sender, EventArgs e)
        {
            LoadDSxeTheoNgay(dateChonXe.Text);
        }

        //Hàm Nhập lại các textbox
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtBienSo.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtTenChuXe.Text = "";
        }
        //hàm xử lý sự kiện bàn phím không cho điều khiển khác nhận sự kiện bàn phím
        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Hàm xử lý các ký tự trong textbox
        private void DeleteLast(ref TextBox textBox)
        {
            foreach (char i in textBox.Text)
            {
                string j = Convert.ToString(i);
                if (IsNumber(j) == true)
                {
                    MessageBox.Show("Tên không hợp lệ!");
                    textBox.Text = textBox.Text.Substring(0, textBox.TextLength - 1);
                }
            }
        }

        //Hàm kiểm tra số
        private bool IsNumber(string s)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(s);
        }

        //Hàm xử lý thay đổi textbox Tên chủ xe
        private void txtTenChuXe_TextChanged(object sender, EventArgs e)
        {
            DeleteLast(ref txtTenChuXe);
        }
    }
}
