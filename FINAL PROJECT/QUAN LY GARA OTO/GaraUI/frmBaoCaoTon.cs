using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraUI
{
    public partial class frmBaoCaoTon : MyFormPage
    {
        public frmBaoCaoTon()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;
        }
        //Hàm form load của class báo cáo tồn
        private void frmBaoCaoTon_Load(object sender, EventArgs e)
        {
       
        }
        //hàm xử lý button lập báo cáo
        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNam.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Năm lập báo cáo không được lớn hơn năm hiện tại");
            }
            else
            {
                if (int.Parse(txtNam.Text) == DateTime.Now.Year)
                {
                    if (int.Parse(cbThang.Text) > DateTime.Now.Month)
                    {
                        MessageBox.Show("Tháng lập báo cáo không được lớn hơn tháng hiện tại");
                    }
                    else
                    {
                        this.BaoCaoTonTableAdapter.Fill(this.rpPhieuSuaChua.BaoCaoTon);
                        this.rpvBaoCaoTon.RefreshReport();
                    }
                }
                else
                {
                    this.BaoCaoTonTableAdapter.Fill(this.rpPhieuSuaChua.BaoCaoTon);
                    this.rpvBaoCaoTon.RefreshReport();
                }

            }
        }
    }
}
