using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDATA.Info
{
    //Class lấy giá trị và cài đặt giá trị cho chi tiết báo cáo doanh số
    public class CT_BaoCaoDoanhSo
    {
        public string MaCTDS { set; get; }
        public string MaDS { set; get; }
        public string HieuXe { set; get; }
        public int SoLuotSua { set; get; }
        public double ThanhTien { set; get; }
        public double TiLe { set; get; }
    }
}
