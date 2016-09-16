using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GaraDATA.Info;

namespace GaraDATA.DAL
{
   public class NhanVienDAL:SqlDataProvider
    {
        
        private SqlDataReader rdr;//biến dùng để đọc luồng dữ liệu từ a SQL Server database
        private SqlCommand cmd;//provide a statement or store procedure to execute
        
       //Hàm lấy danh sách nhân viên từ database
       public List<NhanVien> LayNhanVien()
       {
           try
           {
               List<NhanVien> ds_NhanVien = new List<NhanVien>();
               connection.Open();
               cmd = new SqlCommand("Sp_LayDanhSachNhanVien", GetConnection());//Lấy từ store procedure những giá trị từ database
               cmd.CommandType = CommandType.StoredProcedure;
               rdr = cmd.ExecuteReader();
               while (rdr.Read())
               {
                   NhanVien nvTemp = new NhanVien();
                   nvTemp.MaNV = rdr["MaNV"].ToString();
                   nvTemp.HoTen = rdr["HoTen"].ToString();
                   nvTemp.Username = rdr["Username"].ToString();
                   nvTemp.Password = rdr["Password"].ToString();
                   nvTemp.ChucVu = rdr["ChucVu"].ToString();
                   ds_NhanVien.Add(nvTemp);
               }
               connection.Close();
               return ds_NhanVien;
           }
           catch (Exception e)
           {
               throw e;
           }
       }
    }
}
