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
    public partial class frmPhieuThuTien : MyFormPage
    {
        //Constructor class Phiếu thu tiền
        public frmPhieuThuTien()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;

            //Xử lý lại ngày thu tiền theo format
            dateNgayThuTien.Format=DateTimePickerFormat.Custom;
            dateNgayThuTien.CustomFormat = "MM/dd/yyyy";
        }

        //Hàm load những thông tin cần thiết lên Phiếu thu tiền
        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            cbBienSo.DataSource = KhachHangBUS.KhachHang_DanhSach();
            cbBienSo.DisplayMember = "BienSo";
            cbBienSo.ValueMember = "BienSo";

            this.cbBienSo.SelectedIndexChanged += new System.EventHandler(this.cbBienSo_SelectedIndexChanged);
            this.rpvPhieuThuTien.RefreshReport();
        }

        //Hàm kiểm soát những thay đổi của combo box Biển số
        private void cbBienSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInPhieu.Enabled = true;
            btnLapPhieu.Enabled = true;
            DataTable dtb = new DataTable();
            dtb = KhachHangBUS.KhachHang_GetByBienSo(cbBienSo.Text);
            foreach (DataRow r in dtb.Rows)
            {
                txtChuXe.Text = r["TenChuXe"].ToString();
                txtDienThoai.Text = r["DienThoai"].ToString();
                txtEmail.Text = r["Email"].ToString();
                txtSoTienNo.Text = r["SoTienNo"].ToString();
            }
        }

        //Hàm xử lý button Nhập lại
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtChuXe.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtSoTienNo.Text = "";
            txtSoTienThu.Text = "";}

        //Hàm xử lý button Lập  phiếu thu tiền
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                
                PhieuThuTien pt = new PhieuThuTien();
                pt.BienSo = cbBienSo.Text;
                pt.NgayThuTien = dateNgayThuTien.Value.ToShortDateString();
                pt.SoTienThu = int.Parse(txtSoTienThu.Text);
                string[] s = txtSoTienNo.Text.Split('.');
                if (int.Parse(txtSoTienThu.Text) > int.Parse(s[0]))
                {
                    MessageBox.Show("Số tiền thu phải nhỏ hơn số tiền nợ");
                    txtSoTienThu.Text = "";
                }
                PhieuThuTienBUS.PhieuThuTien_Insert(pt);
                MessageBox.Show("Lập phiếu thành công!!");
                DataTable dtb = new DataTable();
                dtb = KhachHangBUS.KhachHang_GetByBienSo(cbBienSo.Text);
                foreach (DataRow r in dtb.Rows)
                {
                    txtSoTienNo.Text = r["SoTienNo"].ToString();
                }
                btnInPhieu.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm xử lý thay đổi Số tiền thu
        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienThu.Text != "" && txtSoTienNo.Text != "") 
            {
                if (double.Parse(txtSoTienThu.Text) > double.Parse(txtSoTienNo.Text))
                {
                    MessageBox.Show("Số tiền thu phải nhỏ hơn tiền nợ !");
                    txtSoTienThu.Clear();
                    txtSoTienThu.Focus();
                }
                   

            }
        }

        //Hàm xử lý kí tự
        private void txtSoTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;// // Stop the character from being entered into the control since it is non-numerical
        }

        //Hàm xử lý In phiếu
        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataTable2TableAdapter.Fill(this.rpPhieuSuaChua.DataTable2, cbBienSo.Text);
                this.rpvPhieuThuTien.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
