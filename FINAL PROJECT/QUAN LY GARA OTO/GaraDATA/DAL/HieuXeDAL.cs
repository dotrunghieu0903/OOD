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
    public class HieuXeDAL : SqlDataProvider
    {
        //Hàm lấy hiệu xe lên data table 
        public DataTable HieuXe_GetHieuXe()
        {
            using (var cmd = new SqlCommand("sp_HieuXe_GetHieuXe",GetConnection()))
            {
                cmd.CommandType=CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm chèn Hiệu Xe xuống CSDL
        public void HieuXe_Insert(HieuXe Data)
        {
            using (var cmd = new SqlCommand("sp_HieuXe_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.TenHieuXe));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Hàm xóa hiệu xe
        public void HieuXe_Delete(HieuXe Data)
        {
            using (var cmd = new SqlCommand("sp_HieuXe_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.TenHieuXe));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
