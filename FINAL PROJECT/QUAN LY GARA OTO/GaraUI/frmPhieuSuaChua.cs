using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaraDATA.Info;
using GaraBUSSINESS;
using GaraDATA;
using System.Data.SqlClient;

namespace GaraUI
{
    public partial class frmPhieuSuaChua : MyFormPage
    {
        //Constructor class Phiếu sửa chữa
        public frmPhieuSuaChua()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;
            dtpNgaySuaChua.Format = DateTimePickerFormat.Custom;
        }

        //Hàm xử lý xuất báo cáo phiếu sửa chữa
        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReportPhieuSuaChua frm = new frmReportPhieuSuaChua(cbBienSo.Text);
            frm.Show();
        }

        //Hàm kiểm tra nhập xuất các textbox
        private bool KTNhapXuat()
        {

            if (txtMaSuaChua.Text == "")
            {
                MessageBox.Show("Không để trống Mã Sửa Chữa");
                txtMaSuaChua.Focus();
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Chọn số lượng vật tư");
                txtSoLuong.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Chọn sử dụng loại vật tư nào");
                cbVatTuPhuTung.Focus();
                return false;
            }
            if (txtTienCong.Text == "")
            {
                MessageBox.Show("Chọn nội dung sửa chữa");
                cbNoiDung.Focus();
                return false;
            }
            return true;
        }
        //Hàm xử lý button Thêm mới phiếu sử chữa
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KTMaSuaChua(txtMaSuaChua.Text))//Gọi hàm kiểm tra Mã sửa chữa
                {
                    if (KTNhapXuat())//Gọi hàm kiểm tra nhập xuất
                    {
                        PhieuSuaChua psc = new PhieuSuaChua();
                        CT_PhieuSuaChua ct_psc = new CT_PhieuSuaChua();

                        //Tạo mới phiếu sửa chữa
                        psc.MaSuaChua = txtMaSuaChua.Text;
                        psc.NgaySuaChua = dtpNgaySuaChua.Text;
                        psc.BienSo = cbBienSo.Text;
                        psc.TongTien = double.Parse(txtThanhTien.Text);
                        PhieuSuaChuaBUS.PhieuSuaChua_Insert(psc);
                        
                        //Thêm chi tiết vào phiếu sửa chữa
                        ct_psc.MaSuaChua = txtMaSuaChua.Text;
                        ct_psc.MaVatTu = cbVatTuPhuTung.Text;
                        ct_psc.NoiDungSuaChua = cbNoiDung.Text;
                        ct_psc.SoLuong = int.Parse(txtSoLuong.Text);
                        ct_psc.DonGia = double.Parse(txtDonGia.Text);
                        ct_psc.TienCong = double.Parse(txtTienCong.Text);
                        ct_psc.ThanhTien = TinhTien();
                        CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_Insert(ct_psc);

                        MessageBox.Show("Thêm phiếu mới thành công!");
                        LoadDSxeTheoBienSo(cbBienSo.Text);
                        lbcSoLuongTon.Text = VatTuPhuTungBUS.VatTuPhuTung_GetSoLuongTon(cbVatTuPhuTung.Text).ToString();
                        DoanhSo_Insert();}
                }
                else
                    MessageBox.Show("Mã sửa chữa đã có");
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

        //Hàm load các thành phần lên form Phiếu sửa chữa
        private void frmPhieuSuaChua_Load(object sender, EventArgs e)
        {

            try
            {
                //Load danh sách khách hàng
                cbBienSo.DataSource = KhachHangBUS.KhachHang_DanhSach();
                cbBienSo.DisplayMember = "BienSo";
                cbBienSo.ValueMember = "BienSo";
                
                //Load Tiền Công
                cbNoiDung.DataSource = TienCongBUS.TienCong_GetAll();
                cbNoiDung.DisplayMember = "NoiDungSuaChua";
                cbNoiDung.ValueMember = "TienCong";
                
                //Load vật tư phụ tùng
                cbVatTuPhuTung.DataSource = VatTuPhuTungBUS.VatTuPhuTung_GetAll();
                cbVatTuPhuTung.DisplayMember = "MaVatTu";
                cbVatTuPhuTung.ValueMember = "DonGia";
                
                groupPanel2.Enabled = false;
                
               
                
                this.cbBienSo.SelectedIndexChanged += new System.EventHandler(this.cbBienSo_SelectedIndexChanged);
                
                this.cbNoiDung.SelectedIndexChanged += new System.EventHandler(this.cbNoiDung_SelectedIndexChanged);
                
                this.cbVatTuPhuTung.SelectedIndexChanged += new System.EventHandler(this.cbVatTuPhuTung_SelectedIndexChanged);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Hàm xử lý load danh sách xe lên theo biển số
        private void LoadDSxeTheoBienSo(string BienSo)
        {
            try
            {
                tablePhieuSuaChua.DataSource = CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_GetByBienSo(BienSo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Hàm xử lý lựa chọn thay đổi của biển số
        private void cbBienSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnXoa.Enabled = false;
                LoadDSxeTheoBienSo(cbBienSo.Text);
                TongTien(txtMaSuaChua.Text, cbBienSo.Text);
                txtMaSuaChua.Enabled = true;
                groupPanel2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        //Hàm tính tiền theo mã sửa chữa và biển số 
        private void TongTien(string MSC, string BienSo)
        {
            try
            {
                if (MSC != "")
                {
                    DataTable dt = new DataTable();
                    dt = PhieuSuaChuaBUS.PhieuSuaChua_GetTongTien(MSC, BienSo);
                    foreach (DataRow r in dt.Rows)
                    {
                        txtTongTien.Text = r["TongTien"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm xử lý combo box nội dung
        private void cbNoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTienCong.Text = cbNoiDung.SelectedValue.ToString();
            txtThanhTien.Text = TinhTien().ToString();
        }

        //Hàm xử lý combo box vật tư phụ tùng
        private void cbVatTuPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = cbVatTuPhuTung.SelectedValue.ToString();
            lbcSoLuongTon.Text = VatTuPhuTungBUS.VatTuPhuTung_GetSoLuongTon(cbVatTuPhuTung.Text).ToString();
            txtThanhTien.Text = TinhTien().ToString();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Stop the character from being entered into the control since it is non-numerical
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Hàm tình tiền
        private double TinhTien()
        {
            try
            {
                if (txtTienCong.Text != "" && KiemTraSoLuongTon() == true)
                {
                    if (txtDonGia.Text != "" && txtSoLuong.Text != "")
                    {
                        double dongia = double.Parse(txtDonGia.Text);
                        double tiencong = double.Parse(txtTienCong.Text);
                        int soluong = int.Parse(txtSoLuong.Text);
                        double thanhtien = dongia * soluong + tiencong;
                        return thanhtien;
                    }
                    else
                    {
                        txtSoLuong.Text = "0";
                        txtDonGia.Text = "0";
                        return double.Parse(txtTienCong.Text);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        //Hàm xử lý phiếu sửa chữa
        private void tablePhieuSuaChua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tablePhieuSuaChua.CurrentCell.RowIndex;
            txtMaSuaChua.Text = tablePhieuSuaChua.Rows[index].Cells[0].Value.ToString();
            TongTien(txtMaSuaChua.Text, cbBienSo.Text);
            btnXoa.Enabled = true;
        }

        //Hàm xử lý thay đổi số lượng
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                txtThanhTien.Text = TinhTien().ToString();
            }
        }

        //Hàm xử lý button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = tablePhieuSuaChua.CurrentRow.Index;
                string msc = tablePhieuSuaChua.Rows[r].Cells[0].Value.ToString();
                string noidung = tablePhieuSuaChua.Rows[r].Cells[1].Value.ToString();
                CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_Delete(msc, noidung);
                LoadDSxeTheoBienSo(cbBienSo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Hàm kiểm tra số lượng tồn
        private bool KiemTraSoLuongTon()
        {
            bool kt = false;
            if (txtSoLuong.Text != "")
            {
                int sl = int.Parse(txtSoLuong.Text);
                int slt = VatTuPhuTungBUS.VatTuPhuTung_GetSoLuongTon(cbVatTuPhuTung.Text);
                if (sl <= slt)
                    kt = true;
                else
                {
                    kt = false;
                    MessageBox.Show("Số lượng phải nhỏ hơn số lượng vật tư phụ tùng tồn trong kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.Clear();
                    txtSoLuong.Focus();
                }

            }
            return kt;
        }

        //Hàm kiểm tra Mã sửa chữa
        private bool KTMaSuaChua(string masuachua)
        {
            bool kt = true;
            try
            {
                SqlDataReader dr = PhieuSuaChuaBUS.PhieuSuaChua_KTMaSuaChua();
                while (dr.Read())
                {
                    string msc = "";
                    msc = dr[0].ToString();
                    if (msc == masuachua)
                    {
                        kt = false;

                        return kt;
                    }
                    else if (msc != masuachua)
                    {
                        kt = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlDataProvider.connection.Close();
            }

            return kt;
        }

        //hàm kiểm tra nội dung sửa chữa
        private bool KTnoidungsuachua(string msc, string noidung){
            bool kt = false;
            if (CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_KiemTra(msc, noidung).Rows.Count == 0)
            {
                kt = true;
                SqlDataProvider.connection.Close();
            }
            else
            {
                kt = false;
            }
            return kt;
        }
        //
        //Thêm vào doanh số
        //
        private void DoanhSo_Insert()
        {

            DateTime z = new DateTime();
            z = Convert.ToDateTime(dtpNgaySuaChua.Text);
            int year = z.Year;
            int month = z.Month;
            string s = "DS" + year.ToString() + "-" + month.ToString();
            double SumAll = 0;
            DataTable dt = BaoCaoDoanhSoBUS.BaoCaoDoanhSo_GetDuLieu(month, year);
            foreach (DataRow r in dt.Rows)
            {
                SumAll += double.Parse(r["TongTien"].ToString());
                //MessageBox.Show(r["TongTien"].ToString());
            }
            BaoCaoDoanhSoBUS.BaoCaoDoanhSo_Insert(month, year, s, SumAll);
            foreach (DataRow r in dt.Rows)
            {
                float f = ((float.Parse(r["TongTien"].ToString())) * 100 / ((float)SumAll));
                string hx = r["HieuXe"].ToString();
                int count = int.Parse(r["SoLuotSua"].ToString());
                double tt = double.Parse(r["TongTien"].ToString());
                //kiem tra
                //int kt = BaoCaoDoanhSoBUS.BaoCaoDoanhSo_Kiemtra(s, r["HieuXe"].ToString());
                //if (kt == 0)
                {
                    CT_BaoCaoDoanhSoBUS.CT_BaoCaoDoanhSo_Insert(s, hx, count, tt, f);
                }
                //else
                //{
                //    CT_BaoCaoDoanhSoBUS.CT_BaoCaoDoanhSo_Update(s, hx, count, tt, f);
                //}
            }
        }

        //Hàm xử lý button Thêm chi tiết
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (KTMaSuaChua(txtMaSuaChua.Text) == false)
                {
                    if (KTNhapXuat())
                    {
                        if (KTnoidungsuachua(txtMaSuaChua.Text, cbNoiDung.Text))
                        {
                            CT_PhieuSuaChua ct_psc = new CT_PhieuSuaChua();
                            //them chi tiet vao phieu sua chua do
                            ct_psc.MaSuaChua = txtMaSuaChua.Text;
                            ct_psc.MaVatTu = cbVatTuPhuTung.Text;
                            ct_psc.NoiDungSuaChua = cbNoiDung.Text;
                            ct_psc.SoLuong = int.Parse(txtSoLuong.Text);
                            ct_psc.DonGia = double.Parse(txtDonGia.Text);
                            ct_psc.TienCong = double.Parse(txtTienCong.Text);
                            ct_psc.ThanhTien = TinhTien();
                            CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_Insert(ct_psc);
                            MessageBox.Show("Thêm chi tiết phiếu thành công!");
                            LoadDSxeTheoBienSo(cbBienSo.Text);
                            lbcSoLuongTon.Text = VatTuPhuTungBUS.VatTuPhuTung_GetSoLuongTon(cbVatTuPhuTung.Text).ToString();
                            DoanhSo_Insert();
                        }
                        else
                            MessageBox.Show("Nội dung sửa chữa của phiếu đó đã có!");
                    }
                }
                else
                    MessageBox.Show("Mã sửa chữa đã có");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}