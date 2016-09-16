using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDATA.Info
{
    //Class lấy giá trị và cài đặt giá trị cho chi tiết phiếu sửa chữa
    public class CT_PhieuSuaChua
    {
        public string MaCTSC { set; get; }
        public string MaSuaChua { set; get; }
        public string NoiDungSuaChua { set; get; }
        public double TienCong { set; get; }
        public string MaVatTu { set; get; }
        public int SoLuong { set; get; }
        public double DonGia { set; get; }
        public double ThanhTien { set; get; }
    }
}
