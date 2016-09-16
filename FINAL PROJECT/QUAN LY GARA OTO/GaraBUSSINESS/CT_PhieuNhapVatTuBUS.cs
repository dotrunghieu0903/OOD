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
    public class CT_PhieuNhapVatTuBUS
    {
        private static readonly CT_PhieuNhapVatTuDAL db = new CT_PhieuNhapVatTuDAL();//tạo đối tượng của lớp DAL

        //hàm xử lý nghiệp vụ chèn chi tiết phiếu vật tư
        public static void CT_PhieuNhapVatTu_Insert(CT_PhieuNhapVatTu Data)
        {
            db.CT_PhieuNhapVatTu_Insert(Data);
        }

        //Hàm xử lý nghiệp vụ lấy lên chi tiết phiếu vật tư
        public static DataTable CT_PhieuNhapVatTu_GetByPhieuNhap(string MPN)
        {
            return db.CT_PhieuNhapVatTu_GetByPhieuNhap(MPN);
        }

        //Hàm xử lý nghiệp vụ xóa chi tiết phiếu vật tư
        public static void CT_PhieuNhapVatTu_Delete(string MPN,string MVT)
        {
            db.CT_PhieuNhapVatTu_Delete(MPN,MVT);
        }
    }
}
