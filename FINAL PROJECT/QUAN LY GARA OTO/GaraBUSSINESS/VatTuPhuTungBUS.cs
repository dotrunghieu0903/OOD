using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GaraDATA.Info;
using GaraDATA.DAL;

namespace GaraBUSSINESS
{
    public class VatTuPhuTungBUS
    {
        private static readonly VatTuPhuTungDAL db = new VatTuPhuTungDAL();
        //Hàm xử lý nghiệp vụ chèn vật tư phụ tùng
        public static void VatTuPhuTung_Insert(VatTuPhuTung Data)
        {
            db.VatTuPhuTung_Insert(Data);
        }

        //Hàm xử lý nghiệp vụ lấy tất cả vật tư phụ tùng lên bảng
        public static DataTable VatTuPhuTung_GetAll()
        {
            return db.VatTu_GetAll();
        }
        //Hàm xử lý nghiệp vụ cập nhật vật tư phụ tùng
        public static void VatTuPhuTung_Update(VatTuPhuTung Data)
        {
            db.VatTu_Update(Data);
        }

        //Hàm xử lý nghiệp vụ xóa vật tư phụ tùng
        public static void VatTuPhuTung_Delete(VatTuPhuTung Data)
        {
            db.VatTu_Delete(Data);
        }

        //Hàm xử lý nghiệp vụ lấy số lượng tồn của vật tư phụ tùng
        public static int VatTuPhuTung_GetSoLuongTon(string VatTu)
        {
            return db.VatTu_GetSoLuongTon(VatTu);
        }
    }
}
