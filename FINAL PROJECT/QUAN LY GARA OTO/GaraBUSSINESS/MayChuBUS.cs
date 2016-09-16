using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;

namespace GaraBUSSINESS
{
   public class MayChuBUS
    {
       MayChuDAL DalMayChu_Temp;
       public MayChuBUS()
       {
           DalMayChu_Temp = new MayChuDAL();
       }
       //Hàm xử lý nghiệp vụ sao lưu dữ liệu từ máy chủ
       public void SaoLuuDuLieuTuMayChu()
       {
           DalMayChu_Temp.SaoLuuDLTuMayChu();
       }
       //Hàm kiểm tra sự tồn tại của máy chủ
       public bool KiemTraTonTaiCuaMayChu(string TenMayChu)
       {
           foreach (string TenMayChu_LuuTru in DalMayChu_Temp.LayDSMayChu())
           {
               if (TenMayChu_LuuTru == TenMayChu)
                   return true;
           }
           return false;
       }

       //hàm kiểm tra sự tồn tại của CSDL
       public bool KiemTraTonTaiCuaCSDL(string TenMayChu)
       {
           foreach (string temp in DalMayChu_Temp.LayDSCSDLTrenMayChu(TenMayChu))
           {
               if (temp == "QUAN LY GARA OTO")
               {
                   return true;
               }
           }
           return false;
       }
       //Hàm lưu chuỗi kết nối
       public void LuuChuoiKetNoiMayChu(string n_connectionString)
       {

           DalMayChu_Temp.LuuChuoiCSDL(n_connectionString);
       }
       //hàm lấy danh sách máy chủ hiện tại
       public List<string> LayDSMayChu()
       {
           return DalMayChu_Temp.LayDSMayChu();
       }


       //Hàm khôi phục cơ sở dữ liệu
       public void KhoiPhucCSDL(string TenMayChu)
       {
           DalMayChu_Temp.KhoiPhucDuLieuLenMayChu(TenMayChu);
       }

       //hàm xóa cơ sở dữ liệu
       public void XoaCSDL(string TenMayChu)
       {
           DalMayChu_Temp.XoaCSDL(TenMayChu);
       }
    }
}
