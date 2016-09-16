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
    public partial class frmKhoVatTu : Form
    {
        public frmKhoVatTu()
        {
            InitializeComponent();
        }

        private void frmKhoVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_GARA_OTODataSet.sp_VatTuPhuTung_GetAll' table. You can move, or remove it, as needed.
            this.sp_VatTuPhuTung_GetAllTableAdapter.Fill(this.qUAN_LY_GARA_OTODataSet.sp_VatTuPhuTung_GetAll);

        }
    }
}
