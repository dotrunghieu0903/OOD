using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;
using System.Data;

namespace GaraBUSSINESS
{
    public class BaoCaoDoanhSoBUS
    {
        //tạo đối tượng kiểu báo cáo doanh số DAL
        private static readonly BaoCaoDoanhSoDAL db = new BaoCaoDoanhSoDAL();
        //Hàm Insert báo cáo doanh số thông qua tham số
        public static void BaoCaoDoanhSo_Insert(int Thang, int Nam, string MaDS, double Tong)
        {
            db.BaoCaoDoanhSo_Insert(Thang, Nam, MaDS, Tong);
        }

        //Hàm lấy báo cáo doanh số từ DAL
        public static DataTable BaoCaoDoanhSo_GetDuLieu(int Thang, int Nam)
        {
            return db.BaoCaoDoanhSo_GetDuLieu(Thang, Nam);
        }
        //hàm kiểm tra số lượng báo cáo doanh số thông qua hàm được gọi bên DAL
        public static int BaoCaoDoanhSo_Kiemtra(string MaDS, string HieuXe)
        {
            return db.BaoCaoDoanhSo_KT(MaDS, HieuXe);
        }
        
        
        
        
    }
}
