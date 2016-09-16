using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GaraDATA.DAL;
using GaraDATA.Info;

namespace GaraBUSSINESS
{
    public class HieuXeBUS
    {
        private static readonly HieuXeDAL db = new HieuXeDAL();

        //Hàm xử lý nghiệp vụ lấy Hiệu xe
        public static DataTable HieuXe_GetHieuXe()
        {
            return db.HieuXe_GetHieuXe();
        }
        //Hàm xử lý nghiệp vụ chèn hiệu xe
        public static void HieuXe_Insert(HieuXe Data)
        {
            db.HieuXe_Insert(Data);
        }
        //Hàm xử lý nghiệp vụ xóa hiệu xe
        public static void HieuXe_Delete(HieuXe Data)
        {
            db.HieuXe_Delete(Data);
        }
    }
}
