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

namespace GaraUI
{
    public partial class frmTienCong : MyFormPage
    {
        public frmTienCong()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;
        }
        //Hàm xử lý số
        private bool IsNumber(string s)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(s);
        }
        //hàm form load tiền công
        private void frmTienCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_GARA_OTODataSet.sp_TienCong_GetAll' table. You can move, or remove it, as needed.
            this.sp_TienCong_GetAllTableAdapter.Fill(this.qUAN_LY_GARA_OTODataSet.sp_TienCong_GetAll);
            tableDanhSachTienCong.DataSource = TienCongBUS.TienCong_GetAll();
        }

        //Hàm xử lý button thêm tiền công
        private void btnThem3_Click(object sender, EventArgs e)
        {
            try
            {
                TienCong tc = new TienCong();
                tc.NoiDungSuaChua = txtNoiDung.Text;
                tc.GiaTienCong = double.Parse(txtGiaTri.Text);
                TienCongBUS.TienCong_Insert(tc);
                MessageBox.Show("Thêm thành công !");
                tableDanhSachTienCong.DataSource = TienCongBUS.TienCong_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //hàm xử lý button sửa tiền công
        private void btnSua3_Click(object sender, EventArgs e)
        {
            try
            {
                TienCong tc = new TienCong();
                tc.NoiDungSuaChua = txtNoiDung.Text;
                tc.GiaTienCong = double.Parse(txtGiaTri.Text);
                TienCongBUS.TienCong_Update(tc);
                MessageBox.Show("Sửa thành công !");
                tableDanhSachTienCong.DataSource = TienCongBUS.TienCong_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm xử lý button xóa Tiền công
        private void btnXoa3_Click(object sender, EventArgs e)
        {
            try
            {
                TienCong tc = new TienCong();
                tc.NoiDungSuaChua = txtNoiDung.Text;
                TienCongBUS.TienCong_Delete(tc);
                MessageBox.Show("Xoá thành công !");
                tableDanhSachTienCong.DataSource = TienCongBUS.TienCong_GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nội dung sửa chữa đang được sử dụng, k thể xoá!");
            }
        }
        //Hàm xử lý bảng danh sách Tiền Công
        private void tableDanhSachTienCong_Click(object sender, EventArgs e)
        {
            try
            {
                txtGiaTri.DataBindings.Clear();
                txtGiaTri.DataBindings.Add("text", tableDanhSachTienCong.DataSource, "TienCong");
                txtNoiDung.DataBindings.Clear();
                txtNoiDung.DataBindings.Add("text", tableDanhSachTienCong.DataSource, "NoiDungSuaChua");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
