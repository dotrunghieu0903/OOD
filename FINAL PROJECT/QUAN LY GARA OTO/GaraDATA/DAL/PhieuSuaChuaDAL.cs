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
    public class PhieuSuaChuaDAL:SqlDataProvider
    {
        //Hàm chèn phiếu sửa chữa xuống CSDL
        public void PhieuSuaChua_Insert(PhieuSuaChua Data)
        {
            using(var cmd=new SqlCommand("sp_PhieuSuaChua_Insert",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSuaChua", Data.MaSuaChua));
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@NgaySuaChua", Data.NgaySuaChua));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        //Hàm lấy tất cả Phiếu sửa chữa từ CSDL lên
        public DataTable PhieuSuaChua_GetAll()
        {
            using(var cmd = new SqlCommand("sp_PhieuSuaChua_GetAll",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Hàm lấy Phiếu sửa chữa theo Biển Số từ CSDL lên
        public DataTable PhieuSuaChua_GetByBienSo(string BienSo)
        {
            using(var cmd = new SqlCommand("sp_CT_PhieuSuaChua_GetByBienSo",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm kiểm tra Phiếu Sửa Chữa đã sửa chữa
        public int PhieuSuaChua_KiemTraDaSuaChua(string BienSo)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_KiemTraDaSuaChua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                return (int)cmd.ExecuteScalar();
            }
        }

        //Hàm lấy tổng tiến từ phiếu sửa chữa
        public DataTable PhieuSuaChua_GetTongTien(string msc, string bienso)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_GetTongTien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSuaChua", msc));
                cmd.Parameters.Add(new SqlParameter("@BienSo", bienso));
                var da = new SqlDataAdapter();
                var dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }
        //hàm trả về luồng CSDL từ database kiểm tra mã sửa chữa trong Phiếu sửa chữa
        public SqlDataReader PhieuSuaChua_KTMaSuaChua()
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
        }
        
    }
}
