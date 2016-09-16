using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;
using GaraDATA.Info;

namespace GaraBUSSINESS
{
    public class PhieuThuTienBUS
    {
        private  static readonly PhieuThuTienDAL db=new PhieuThuTienDAL();

        //Hàm xử lý nghiệp vụ chèn Phiếu thu tiền
        public static void PhieuThuTien_Insert(PhieuThuTien Data)
        {
            db.PhieuThuTien_Insert(Data);
        }
    }
}
