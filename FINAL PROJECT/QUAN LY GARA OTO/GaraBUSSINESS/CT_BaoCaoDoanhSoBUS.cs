using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;

namespace GaraBUSSINESS
{
    public class CT_BaoCaoDoanhSoBUS
    {
        private static readonly CT_BaoCaoDoanhSoDAL db = new CT_BaoCaoDoanhSoDAL();
        //Hàm xử lý nghiệp vụ Chèn chi tiết báo cáo doanh số với các tham số truyền vào
        public static void CT_BaoCaoDoanhSo_Insert(string MaDS, string HieuXe, int SoLuotSua, double ThanhTien, float TiLe)
        {
            db.CT_BaoCaoDoanhSo_Insert(MaDS, HieuXe, SoLuotSua, ThanhTien, TiLe);
        }
        //Hàm xử lý nghiệp vụ Cập nhật chi tiết báo cáo doanh số với các tham số truyền vào
        public static void CT_BaoCaoDoanhSo_Update(string MaDS, string HieuXe, int SoLuotSua, double ThanhTien, float TiLe)
        {
            db.CT_BaoCaoDoanhSo_Update(MaDS, HieuXe, SoLuotSua, ThanhTien, TiLe);
        }
    }
}
