using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.DAL;
using GaraDATA.Info;
using System.Data;
using System.Data.SqlClient;

namespace GaraBUSSINESS
{
   public class NhanVienBUS
    {
      //Hàm lấy danh sách nhân  viên
       public List<NhanVien> LayDsNV()
       {
           NhanVienDAL DalNhanVien_Temp = new NhanVienDAL();
           return DalNhanVien_Temp.LayNhanVien();
       }
       
    }
}
