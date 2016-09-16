using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GaraDATA.DAL
{
    public class BaoCaoDoanhSoDAL : SqlDataProvider
    {
        //Hàm chèn báo cáo doanh số
        public void BaoCaoDoanhSo_Insert(int Thang, int Nam, string MaDS, double Tong)
        {
            using (var cmd = new SqlCommand("sp_BaoCaoDoanhSo_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd.Parameters.Add(new SqlParameter("@Nam", Nam));
                cmd.Parameters.Add(new SqlParameter("@MaDS", MaDS));
                cmd.Parameters.Add(new SqlParameter("@TongDoanhSo", Tong));
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        //Hàm lấy báo cáo doanh số lên datatable
        public DataTable BaoCaoDoanhSo_GetDuLieu(int Thang, int Nam)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_GetSoLuotSua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd.Parameters.Add(new SqlParameter("@Nam", Nam));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm trả về số lượng báo cáo doanh số
        public int BaoCaoDoanhSo_KT(string MaDS, string HieuXe)
        {
            using (var cmd = new SqlCommand("sp_BaoCaoDoanhSo_KiemTra ", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDS", MaDS));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", HieuXe));
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
