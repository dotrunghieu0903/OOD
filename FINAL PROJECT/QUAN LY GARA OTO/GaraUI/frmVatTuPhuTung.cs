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
    public partial class frmVatTuPhuTung : MyFormPage
    {
        //Constructor form Vật tư phụ tùng
        public frmVatTuPhuTung()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;//gán panel với layout panel1
            //định dạng lại format ngày tháng năm
            dtpNgayNhapHang.Format = DateTimePickerFormat.Custom;
            dtpNgayNhapHang.CustomFormat = "MM/dd/yyyy";
        }
        //Kiểm tra số 
        private bool IsNumber(string s)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(s);
        }
        //Hàm thêm mới phiếu vật tư
        private void btnThem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (PhieuNhapVatTuBUS.PhieuNhapVatTu_KiemTra(cbMaPhieuNhap.Text)==0)
                {
                    PhieuNhapVatTu pnvt = new PhieuNhapVatTu();
                    CT_PhieuNhapVatTu ct_pnvt = new CT_PhieuNhapVatTu();
                    pnvt.MaPhieuNhap = cbMaPhieuNhap.Text;
                    pnvt.NgayNhapHang = dtpNgayNhapHang.Text;
                    pnvt.DiaDiem = txtDiaDiem.Text;

                    ct_pnvt.MaPhieuNhap = cbMaPhieuNhap.Text;
                    ct_pnvt.MaVatTu = txtVTPT.Text;
                    ct_pnvt.NhaSX = txtNhaSanXuat.Text;
                    ct_pnvt.SoLuong = int.Parse(txtSoLuong.Text);
                    ct_pnvt.DonGia = double.Parse(txtDonGia.Text);
                    ct_pnvt.ThanhTien = double.Parse(txtThanhTien.Text);

                    PhieuNhapVatTuBUS.PhieuNhapVatTu_Insert(pnvt);
                    CT_PhieuNhapVatTuBUS.CT_PhieuNhapVatTu_Insert(ct_pnvt);
                    MessageBox.Show("Thêm mới phiếu nhập vật tư thành công!");
                    LoadMaPhieuNhap();
                    LoadDSVatTu();

                }
                else
                {
                    MessageBox.Show("Phiếu nhập vật tư đã có. Xin nhập mã phiếu khác hoặc thêm chi tiết!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        //Hàm tính thành tiền
        private void TinhThanhTien()
        {
            if (txtSoLuong.Text != "" && txtDonGia.Text != "") 
            {
                int soluong = int.Parse(txtSoLuong.Text);
                double dongia = double.Parse(txtDonGia.Text);
                double thanhtien = dongia * soluong;
                txtThanhTien.Text = thanhtien.ToString();
            }
            

        }
        //Hàm xử lý button xóa thông tin vật tư
        private void btnXoa2_Click(object sender, EventArgs e)
        {
            try
            {
                CT_PhieuNhapVatTuBUS.CT_PhieuNhapVatTu_Delete(cbMaPhieuNhap.Text, txtVTPT.Text);
                LoadDSVatTu();
                LoadMaPhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        //Hàm xử lý From Load của class vật tư phụ tùng
        private void frmVatTuPhuTung_Load(object sender, EventArgs e)
        {
            try
            {
                this.cT_PhieuSuaChuaTableAdapter.Fill(this.qUAN_LY_GARA_OTODataSet.CT_PhieuSuaChua);
                LoadMaPhieuNhap();
                this.cbMaPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.cbMaPhieuNhap_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);}
            
            
        }
        //Hàm xử lý danh sách vật tư phụ tùng
        private void tableDanhSachVTPT_Click(object sender, EventArgs e)
        {
            try
            {
                cbMaPhieuNhap.DataBindings.Clear();
                cbMaPhieuNhap.DataBindings.Add("text", tableDanhSachVTPT.DataSource, "MaPhieuNhap");
                txtSoLuong.DataBindings.Clear();
                txtSoLuong.DataBindings.Add("text", tableDanhSachVTPT.DataSource, "SoLuong");
                txtDonGia.DataBindings.Clear();
                txtDonGia.DataBindings.Add("text", tableDanhSachVTPT.DataSource, "DonGia");
                txtVTPT.DataBindings.Clear();
                txtVTPT.DataBindings.Add("text", tableDanhSachVTPT.DataSource, "MaVatTu");
                txtDiaDiem.DataBindings.Clear();
                txtDiaDiem.DataBindings.Add("text", tableDanhSachVTPT.DataSource, "DiaDiem");
                txtNhaSanXuat.DataBindings.Clear();
                txtNhaSanXuat.DataBindings.Add("text", tableDanhSachVTPT.DataSource, "NhaSX");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        //hàm thay đổi của đon giá số lượng
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
        //Hàm xử lý button thêm chi tiết
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if(PhieuNhapVatTuBUS.PhieuNhapVatTu_KiemTra(cbMaPhieuNhap.Text)!=0)
                {
                    if (KiemTraMaVatTu(txtVTPT.Text) == true)
                    {
                        CT_PhieuNhapVatTu ct_pnvt = new CT_PhieuNhapVatTu();
                        ct_pnvt.MaPhieuNhap = cbMaPhieuNhap.Text;
                        ct_pnvt.MaVatTu = txtVTPT.Text;
                        ct_pnvt.NhaSX = txtNhaSanXuat.Text;
                        ct_pnvt.SoLuong = int.Parse(txtSoLuong.Text);
                        ct_pnvt.DonGia = double.Parse(txtDonGia.Text);
                        ct_pnvt.ThanhTien = double.Parse(txtThanhTien.Text);

                        CT_PhieuNhapVatTuBUS.CT_PhieuNhapVatTu_Insert(ct_pnvt);
                        MessageBox.Show("Thêm chi tiết phiếu nhập vật tư thành công!");
                        LoadDSVatTu();
                    }
                    else
                        MessageBox.Show("Mã vật tư đã có!");
                }
                else
                {
                    MessageBox.Show("Mã Phiếu Nhập chưa có. Để thêm mới phiếu nhập chọn nút THÊM MỚI!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        //Hàm kiểm tra mã vật tư
        private bool KiemTraMaVatTu(string MVT)
        {
            DataTable dt = CT_PhieuNhapVatTuBUS.CT_PhieuNhapVatTu_GetByPhieuNhap(cbMaPhieuNhap.Text);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                if (MVT == dt.Rows[i][1].ToString())
                    return false;
            }
            return true;
        }
        //Hàm xử lý thay đổi combo box mã phiếu nhập
        private void cbMaPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSVatTu();
        }
        //Hầm load mã phiếu nhập
        private void LoadMaPhieuNhap()
        {
            cbMaPhieuNhap.DataSource = PhieuNhapVatTuBUS.PhieuNhapVatTu_GetPhieuNhap();
            cbMaPhieuNhap.DisplayMember = "MaPhieuNhap";
            cbMaPhieuNhap.ValueMember = "TongTien";
            txtTongTien.Text = cbMaPhieuNhap.SelectedValue.ToString();
        }
        //Hàm load danh sách vật tư
        private void LoadDSVatTu()
        {
            tableDanhSachVTPT.DataSource = CT_PhieuNhapVatTuBUS.CT_PhieuNhapVatTu_GetByPhieuNhap(cbMaPhieuNhap.Text);
            cbMaPhieuNhap.ValueMember = "TongTien";
            txtTongTien.Text = cbMaPhieuNhap.SelectedValue.ToString();
        }

        private void tableDanhSachVTPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Hàm xử lý button kho vật tư
        private void btnKhoVatTu_Click(object sender, EventArgs e)
        {
            frmKhoVatTu f=new frmKhoVatTu();
            f.Show();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

    }
}
