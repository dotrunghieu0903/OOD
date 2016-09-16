using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDATA.Info
{
    //Class lấy giá trị và cài đặt giá trị cho đối tượng Khách hàng
    public class KhachHang
    {
        public string BienSo { set; get; }
        public string TenChuXe { set; get; }
        public string HieuXe { set; get; }
        public int DienThoai { set; get; }
        public string DiaChi { set; get; }
        public string NgayTiepNhan { set; get; }
        public double TienNo { set; get; }
        public string Email { set; get; }
    }
}
