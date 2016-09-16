using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GaraDATA.DAL
{
    public class CT_BaoCaoDoanhSoDAL:SqlDataProvider
    {

        //Hàm chèn Chi tiết báo cáo doanh số
        public void CT_BaoCaoDoanhSo_Insert(string MaDS, string HieuXe, int SoLuotSua, double ThanhTien, float TiLe)
        {
            using (var cmd = new SqlCommand("sp_CT_BaoCaoDoanhSo_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDS", MaDS));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", HieuXe));
                cmd.Parameters.Add(new SqlParameter("@SoLuotSua", SoLuotSua));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@TiLe", TiLe));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Hàm cập nhật chi tiết báo cáo doanh số
        public void CT_BaoCaoDoanhSo_Update(string MaDS, string HieuXe, int SoLuotSua, double ThanhTien, float TiLe)
        {
            using (var cmd = new SqlCommand("sp_CT_BaoCaoDoanhSo_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDS", MaDS));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", HieuXe));
                cmd.Parameters.Add(new SqlParameter("@SoLuotSua", SoLuotSua));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@TiLe", TiLe));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
