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
    public partial class frmHieuXe : MyFormPage
    {
        public frmHieuXe()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;
        }
        //Hàm xử lý button thêm hiệu xe
        private void btnThem1_Click(object sender, EventArgs e)
        {
            try
            {
                HieuXe hc = new HieuXe();
                hc.TenHieuXe = txtHieuXe.Text;
                HieuXeBUS.HieuXe_Insert(hc);
                MessageBox.Show("Thêm thành công");
                tableDanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm xử lý xóa hiệu xe
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            try
            {
                HieuXe hc = new HieuXe();
                hc.TenHieuXe = txtHieuXe.Text;
                HieuXeBUS.HieuXe_Delete(hc);
                MessageBox.Show("Xoá thành công");
                tableDanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm Form load Hiệu Xe
        private void frmHieuXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_GARA_OTODataSet.sp_HieuXe_GetHieuXe' table. You can move, or remove it, as needed.
            this.sp_HieuXe_GetHieuXeTableAdapter.Fill(this.qUAN_LY_GARA_OTODataSet.sp_HieuXe_GetHieuXe);
            tableDanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();
        }

        //Hàm xử lý bảng danh sách hiệu xe
        private void tableDanhSachHieuXe_Click(object sender, EventArgs e)
        {
            txtHieuXe.DataBindings.Clear();
            txtHieuXe.DataBindings.Add("text", tableDanhSachHieuXe.DataSource, "HieuXe");
        }
    }
}
