using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;
using GaraDATA.Info;

namespace GaraBUSSINESS
{
    public class TienCongBUS
    {
        private static readonly TienCongDAL db=new TienCongDAL();
        //Hàm xử lý nghiệp vụ lấy tất cả tiền công lên bảng
        public static DataTable TienCong_GetAll()
        {
            return db.TienCong_GetAll();
        }
        //Hàm xử lý nghiệp vụ chèn Tiền Công xuống CSDL
        public static void TienCong_Insert(TienCong Data)
        {
            db.TienCong_Insert(Data);
        }
        //Hàm xử lý nghiệp vụ cập nhật tiền công
        public static void TienCong_Update(TienCong Data)
        {
            db.TienCong_Update(Data);
        }
        //Hàm xử lý nghiệp vụ xóa tiền công
        public static void TienCong_Delete(TienCong Data)
        {
            db.TienCong_Delete(Data);
        }
    }
}
