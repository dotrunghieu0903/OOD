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

namespace GaraUI
{
    public partial class frmReportPhieuSuaChua : Form
    {
        private string BienSo;
        public frmReportPhieuSuaChua(string BienSo)
        {
            this.BienSo = BienSo;
            InitializeComponent();
        }

        private void frmReportPhieuSuaChua_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataTable1TableAdapter.Fill(this.rpPhieuSuaChua.DataTable1, BienSo);
                this.rpvPhieuSuaChua.RefreshReport();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void rpvPhieuSuaChua_Load(object sender, EventArgs e)
        {

        }

       }
}
