using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;
using GaraDATA.Info;
using System.Data;

namespace GaraBUSSINESS
{
    public class KhachHangBUS
    {
        private static readonly KhachHangDAL db = new KhachHangDAL();
        //Hàm xử lý nghiệp vụ chèn khách hàng
        public static void KhachHang_Insert(KhachHang Data)
        {
            db.KhachHang_Insert(Data);
        }

        //Hàm xử lý nghiệp vụ update thông tin khách hàng
        public static void KhachHang_Update(KhachHang Data)
        {
            db.KhachHang_Update(Data);
        }

        //Hàm xử lý nghiệp vụ xóa thông tin khách hàng
        public static void KhachHang_Delete(string BienSo)
        {
            db.KhachHang_Delete(BienSo);
        }
        //Hàm xử lý nghiệp vụ lấy danh sách thông tin khách hàng
        public static DataTable KhachHang_DanhSach()
        {
            return db.KhachHang_DanhSach();
        }

        //Hàm xử lý nghiệp vụ lấy danh sách thông tin khách hàng theo ngày tiếp nhận
        public static DataTable KhachHang_DStheoNgay(string NgayTiepNhan)
        {
            return db.KhachHang_DStheoNgay(NgayTiepNhan);
        }
        //Hàm xử lý nghiệp vụ lấy danh sách thông tin khách hàng theo tên chủ xe
        public static DataTable KhachHang_GetByTenChuXe(string Ten)
        {
            return db.KhachHang_GetByTenChuXe(Ten);
        }
        //Hàm xử lý nghiệp vụ lấy danh sách thông tin khách hàng theo biển số xe
        public static DataTable KhachHang_GetByBienSo(string BienSo)
        {
            return db.KhachHang_GetByBienSo(BienSo);
        }

        //Hàm xử lý nghiệp vụ lấy danh sách thông tin khách hàng theo Hiệu xe
        public static DataTable KhachHang_GetByHieuXe(string HieuXe)
        {
            return db.KhachHang_GetByHieuXe(HieuXe);
        }

        //Hàm xử lý nghiệp vụ lấy danh sách thông tin khách hàng đã sửa chữa
        public static DataTable KhachHang_DSdaSuaChua()
        {
            return db.KhachHang_DSdaSuaChua();
        }
        //Hàm xử lý nghiệp vụ lấy danh sách thông tin khách hàng đã thu tiền
        public static DataTable KhachHang_DSdaThuTien()
        {
            return db.KhachHang_DSdaThuTien();
        }
        //Hàm xử lý nghiệp vụ trả ra số lượng khách hàng theo ngày
        public static int KhachHang_CountDStheoNgay(string Ngay)
        {
            return db.KhachHang_CountDStheoNgay(Ngay);
        }
        //Hàm xử lý nghiệp vụ trả ra số lượng sửa xe
        public static int SoLuotSuaXe()
        {
            return db.KhachHang_SoLuotXeSua();
        }
        
    }
}
