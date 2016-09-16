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
using GaraDATA;

namespace GaraUI
{
    public partial class frmTimKiemXe : MyFormPage
    {
        //Constructor class Tìm kiếm xe
        public frmTimKiemXe()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;
            //Setup format ngày tiếp nhận xe
            dtpNgayTiepNhanUpdate.Format = DateTimePickerFormat.Custom;
            dtpNgayTiepNhanUpdate.CustomFormat = "MM/dd/yyyy";
            cbTimKiem.SelectedIndex = 0;
        }

        //Hàm load form Tìm kiếm xe
        private void frmTimKiemXe_Load(object sender, EventArgs e)
        {
            cbGiaTri.DataSource = KhachHangBUS.KhachHang_DanhSach();
            cbGiaTri.DisplayMember = "TenChuXe";
            cbGiaTri.ValueMember = "TenChuXe";
            cbHieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();
            cbHieuXe.DisplayMember = "HieuXe";
            cbHieuXe.ValueMember = "HieuXe";
            SqlDataProvider.connection.Close();
        }

        //Hàm thay đổi trường hợp khách hàng
        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimKiem.SelectedIndex == 0)
            {
                cbGiaTri.DataSource = KhachHangBUS.KhachHang_DanhSach();
            }

            if (cbTimKiem.SelectedIndex == 1)
                cbGiaTri.DataSource = KhachHangBUS.KhachHang_DSdaSuaChua();
            if (cbTimKiem.SelectedIndex == 2)
                cbGiaTri.DataSource = KhachHangBUS.KhachHang_DSdaThuTien();


        }
        bool kt = false;//biến cục bộ kiểm tra

        //Hàm Kiểm tra giá trị từ bàn phím
        private void MyKeypress(ComboBox combobox, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Escape)
            {
                combobox.SelectedIndex = -1;
                combobox.Text = "";
                kt = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                kt = true;
            }
            else kt = false;
        }
        //Hàm kiểm tra thay đổi
        private void MyTextChange(ComboBox combobox, EventArgs e)
        {
            if (combobox.Text != "" && !kt)
            {
                string s = combobox.Text;
                int Index = combobox.FindString(s);
                if (Index != -1)
                {
                    combobox.SelectedIndex = Index;
                }

                combobox.SelectionStart = s.Length;
                combobox.SelectionLength = combobox.Text.Length - combobox.SelectionStart;
            }
        }

        //Hàm kiểm tra thay đổi của radiobutton Tên khách hàng
        private void rbtTenKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            cbGiaTri.DisplayMember = "TenChuXe";
            cbGiaTri.ValueMember = "TenChuXe";
        }
        //Hàm click của radiobutton Tên khách hàng
        private void rbtBienSo_Click(object sender, EventArgs e)
        {
            cbGiaTri.DisplayMember = "BienSo";
            cbGiaTri.ValueMember = "BienSo";
        }

        //Hàm nhập giá trị combo box
        private void cbGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyKeypress(cbGiaTri, e);
        }
        //Hàm click của radiobutton Hiệu Xe
        private void rbtHieuXe_Click(object sender, EventArgs e)
        {
            cbGiaTri.DisplayMember = "HieuXe";
            cbGiaTri.ValueMember = "HieuXe";
        }

        //Hàm thay đổi giá trị của combbo box
        private void cbGiaTri_TextChanged(object sender, EventArgs e)
        {
            MyTextChange(cbGiaTri, e);
        }
        //hàm xử lý button Tìm Kiếm
        private void btnTim_Click(object sender, EventArgs e)
        {
            if(cbGiaTri.FindStringExact(cbGiaTri.Text)==-1)
            {
                MessageBox.Show("Tên,Hiệu Xe hoặc Biển số không có !","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                ReLoad();
            }
            
        }
        //Hàm xử lý button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHangBUS.KhachHang_Delete(gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["BienSo"]));
            ReLoad();
        }
        //Hàm kiểm tra textbox không được để trống
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
            if (txtDienthoai.Text.Trim().Equals(""))
            {
                MessageBox.Show("Điện thoại không được để trống!");
                txtDienthoai.Focus();
                return false;
            }
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Email không được để trống!");
                txtEmail.Focus();
                return false;
            }
            if (cbGiaTri.FindStringExact(txtBienSo.Text) != -1)
            {
                MessageBox.Show("Biển số đã có!");
                txtBienSo.Focus();
                return false;
            }
            return true;
        }
        //Hàm xử lý button Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (KT())
            {
                KhachHang kh = new KhachHang();
                try
                {
                    //Cập nhật thông tin chủ xe
                    kh.BienSo = txtBienSo.Text;
                    kh.TenChuXe = txtTenChuXe.Text;
                    kh.TienNo = double.Parse(txtTienNo.Text);
                    kh.DiaChi = txtDiaChi.Text;
                    kh.DienThoai = int.Parse(txtDienthoai.Text);
                    kh.Email = txtEmail.Text;
                    kh.HieuXe = cbHieuXe.Text;
                    kh.NgayTiepNhan = dtpNgayTiepNhanUpdate.Text;
                    KhachHangBUS.KhachHang_Update(kh);
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    ReLoad();}
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Hàm load dữ liệu lên Gridview
        private void LoadDLtuGrid()
        {
            try
            {
                txtTenChuXe.Text = gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["TenChuXe"]);
                txtBienSo.Text = gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["BienSo"]);
                txtDiaChi.Text = gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["DiaChi"]);
                txtDienthoai.Text = gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["DienThoai"]);
                txtEmail.Text = gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["Email"]);
                txtTienNo.Text = gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["SoTienNo"]);
                cbHieuXe.Text = gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["HieuXe"]);
                dtpNgayTiepNhanUpdate.Text = gridView1.GetFocusedRowCellDisplayText(gridView1.Columns["NgayTiepNhan"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm lấy dữ liệu GridView sang bảng danh sách xe
        private void tableDanhSachXe_Click(object sender, EventArgs e)
        {
           LoadDLtuGrid();
            
        }

        //Hàm chỉnh sửa từng dòng trong gridview
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            LoadDLtuGrid();
        }
        //Hàm Refresh DataSource lấy lại các giá trị cập nhật
        private void ReLoad()
        {
            if (rbtBienSo.Checked == true)
                tableDanhSachXe.DataSource = KhachHangBUS.KhachHang_GetByBienSo(cbGiaTri.Text);
            if (rbtTenKhachHang.Checked == true)
                tableDanhSachXe.DataSource = KhachHangBUS.KhachHang_GetByTenChuXe(cbGiaTri.Text);
            if (rbtHieuXe.Checked == true)
                tableDanhSachXe.DataSource = KhachHangBUS.KhachHang_GetByHieuXe(cbGiaTri.Text);
            cbGiaTri.DataSource = KhachHangBUS.KhachHang_DanhSach();
        }


        //Hàm xử lý Sự kiện này được đặt ra cho các phím ký tự trong khi phím được nhấn và sau đó phát hành
        
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
