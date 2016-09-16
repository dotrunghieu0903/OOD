using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDATA.Info
{
    //Class lấy giá trị và cài đặt giá trị cho chi tiết phiếu vật tư
    public class CT_PhieuNhapVatTu
    {
        public string MaPhieuNhap { set; get; }
        public string MaVatTu { set; get; }
        public double DonGia { set; get; }
        public int SoLuong { set; get; }
        public double ThanhTien { set; get; }
        public string NhaSX { set; get; }
    }
}
