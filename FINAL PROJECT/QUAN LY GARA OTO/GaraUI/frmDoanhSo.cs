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
    public partial class frmDoanhSo : MyFormPage
    {
        public frmDoanhSo()
        {
            InitializeComponent();
            this.pnl = tableLayoutPanel1;
        }

        private void frmDoanhSo_Load(object sender, EventArgs e)
        {
            
            
        }
        
        //Hàm xử lý button báo cáo doanh số
        private void btnLapBaoCao_Click_1(object sender, EventArgs e)
        {
            try
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
                            this.DoanhSoTableAdapter.FillByDate(this.rpPhieuSuaChua.DoanhSo, int.Parse(cbThang.Text), int.Parse(txtNam.Text));
                            this.rpvDoanhSo.RefreshReport();
                        }
                    }
                    else
                    {
                        this.DoanhSoTableAdapter.FillByDate(this.rpPhieuSuaChua.DoanhSo, int.Parse(cbThang.Text), int.Parse(txtNam.Text));
                        this.rpvDoanhSo.RefreshReport();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
