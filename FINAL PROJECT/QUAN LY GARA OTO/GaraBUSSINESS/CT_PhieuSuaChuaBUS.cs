using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;
using GaraDATA.Info;
using  System.Data;

namespace GaraBUSSINESS
{
    public class CT_PhieuSuaChuaBUS
    {
        private  static  readonly CT_PhieuSuaChuaDAL db=new CT_PhieuSuaChuaDAL();

        public static void CT_PhieuSuaChua_Insert(CT_PhieuSuaChua Data)
        {
            db.CT_PhieuSuaChua_Insert(Data);
        }

        //Hàm xử lý nghiệp vụ lấy lên chi tiết phiếu sửa chữa thông qua Mã sửa chữa
        public static DataTable CT_PhieuSuaChua_GetByMaSuaChua(string MSC)
        {
            return db.CT_PhieuSuaChua_GetByMaSuaChua(MSC);
        }
        //Hàm xử lý nghiệp vụ lấy lên chi tiết phiếu sửa chữa thông qua Biển số
        public static DataTable CT_PhieuSuaChua_GetByBienSo(string BienSo)
        {
            return db.CT_PhieuSuaChua_GetByBienSo(BienSo);
        }

        //Hàm xử lý nghiệp vụ kiểm tra chi tiết phiếu sửa chữa
        public static DataTable CT_PhieuSuaChua_KiemTra(string MSC,string NoiDung)
        {
            return db.CT_PhieuSuaChua_KiemTra(MSC, NoiDung);
        }

        //Hàm xử lý nghiệp vụ xóa chi tiết phiếu sửa chữa
        public static void CT_PhieuSuaChua_Delete(string msc,string noidung)
        {
            db.CT_PhieuSuaChua_Delete(msc, noidung);
        }

    }
}
