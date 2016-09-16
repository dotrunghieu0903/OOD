using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GaraDATA.DAL;
using GaraDATA.Info;namespace GaraBUSSINESS
{
    public class PhieuSuaChuaBUS
    {
        private static readonly PhieuSuaChuaDAL db = new PhieuSuaChuaDAL();
        //Hàm xử lý nghiệp vụ chèn Phiếu sửa chữa 
        public static void PhieuSuaChua_Insert(PhieuSuaChua Data)
        {
            db.PhieuSuaChua_Insert(Data);
        }
        //Hàm xử lý nghiệp vụ lấy tất cả phiếu sửa chữa
        public static DataTable PhieuSuaChua_GetAll()
        {
            return db.PhieuSuaChua_GetAll();
        }
        //Hàm xử lý nghiệp vụ lấy tất cả phiếu sửa chữa theo Biển Số

        public static DataTable PhieuSuaChua_GetByBienSo(string BienSo)
        {
            return db.PhieuSuaChua_GetByBienSo(BienSo);
        }
        //Hàm xử lý nghiệp vụ trả về số lượng phiếu sửa chữa đã sửa chữa
        public static int PhieuSuaChua_KiemTraDaSuaChua(string BienSo)
        {
            return db.PhieuSuaChua_KiemTraDaSuaChua(BienSo);
        }
        //Hàm xử lý nghiệp vụ lấy tổng tiền của phiếu sửa chữa
        public static DataTable PhieuSuaChua_GetTongTien(string msc, string bienso)
        {
            return db.PhieuSuaChua_GetTongTien(msc, bienso);
        }
        //Hàm xử lý nghiệp vụ luồng dữ liệu kiểm tra Mã sửa chữa
        public static SqlDataReader PhieuSuaChua_KTMaSuaChua()
        {
            return db.PhieuSuaChua_KTMaSuaChua();
        }
    }
}
