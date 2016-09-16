using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using GaraBUSSINESS;
using System.Configuration;
using System.IO;

namespace GaraUI
{
    public partial class frmChonMayChu : DevComponents.DotNetBar.OfficeForm
    {
        MayChuBUS BusMayChu_Temp;    
        public frmChonMayChu()
        {
            BusMayChu_Temp = new MayChuBUS();
            InitializeComponent();
        }

        private void frmChonMayChu_Load(object sender, EventArgs e)
        {
            cbServer.DataSource = BusMayChu_Temp.LayDSMayChu();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["GaraUI.Properties.Settings.QUAN_LY_GARA_OTOConnectionString"].ConnectionString = "Server" + cbServer.Text.ToString() + ";Initial Catalog=QUAN LY GARA OTO;Integrated Security=True";
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            Properties.Settings.Default.Reload();

            BusMayChu_Temp.LuuChuoiKetNoiMayChu("Server=" + cbServer.Text + ";Initial Catalog=QUAN LY GARA OTO;Integrated Security=True");
            if (BusMayChu_Temp.KiemTraTonTaiCuaCSDL(cbServer.Text) == false)
            {
                BusMayChu_Temp.KhoiPhucCSDL(cbServer.Text);
                BusMayChu_Temp.LuuChuoiKetNoiMayChu("Server=" + cbServer.Text + ";Initial Catalog=QUAN LY GARA OTO;Integrated Security=True");
                MessageBox.Show("Đã lưu dữ liệu chương trình lên máy chủ","THÔNG BÁO");
            }
            else
            {
                if (File.Exists(Application.StartupPath + @"QUAN LY GARA OTO.mdf")==false)
                {
                    BusMayChu_Temp.XoaCSDL(cbServer.Text);
                    BusMayChu_Temp.KhoiPhucCSDL(cbServer.Text);
                    BusMayChu_Temp.LuuChuoiKetNoiMayChu("Server=" + cbServer.Text + ";Initial Catalog=QUAN LY GARA OTO;Integrated Security=True");
                    MessageBox.Show("Đã lưu dữ liệu chương trình lên máy chủ","THÔNG BÁO");
                }
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}