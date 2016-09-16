using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;
using System.Data;
using GaraDATA.Info;


namespace GaraBUSSINESS
{
    public class PhieuNhapVatTuBUS
    {
        private static readonly PhieuNhapVatTuDAL db = new PhieuNhapVatTuDAL();
        //Hàm xử lý nghiệp vụ chèn phiếu nhập vật tư
        public static void PhieuNhapVatTu_Insert(PhieuNhapVatTu Data)
        {
            db.PhieuNhapVatTu_Insert(Data);
        }

        //Hàm xử lý nghiệp vụ lấy lên tất cả phiếu nhập vật tư theo ngày nhập hàng
        public static DataTable PhieuNhapVatTu_GetAll(string NgayNhapHang)
        {
            return db.PhieuNhapVatTu_GetAll(NgayNhapHang);
        }
        //Hàm xử lý nghiệp vụ trả về sô lượng phiếu nhập vật tư
        public static int PhieuNhapVatTu_KiemTra(string MPN)
        {
            return db.PhieuNhapVatTu_KiemTra(MPN);
        }
        //Hàm xử lý nghiệp vụ lấy phiếu nhập
        public static DataTable PhieuNhapVatTu_GetPhieuNhap()
        {
            return db.PhieuNhapVatTu_GetPhieuNhap();
        }
    }
}
