using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GaraDATA.Info;

namespace GaraDATA.DAL
{
    public class PhieuNhapVatTuDAL : SqlDataProvider
    {
        //Hàm chèn phiếu nhập vật tư
        public void PhieuNhapVatTu_Insert(PhieuNhapVatTu Data)
        {
            using (var cmd=new SqlCommand("sp_PhieuNhapVatTu_Insert",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuNhap", Data.MaPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@NgayNhapHang", Data.NgayNhapHang));
                cmd.Parameters.Add(new SqlParameter("@DiaDiem", Data.DiaDiem));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            
        }

        //hàm lấy tất cả phiếu nhập vật tư
        public DataTable PhieuNhapVatTu_GetAll(string NgayNhapHang)
        {
            using(var cmd=new SqlCommand("sp_PhieuNhapVatTu_GetAll",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NgayNhapHang", NgayNhapHang));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Hàm trả về phiếu nhập tư
        public int PhieuNhapVatTu_KiemTra(string MPN)
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTu_KiemTra", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuNhap", MPN));
                return (int)cmd.ExecuteScalar();
            }
        }

        //hàm lấy lên datatable Phiếu nhập vật tư
        public DataTable PhieuNhapVatTu_GetPhieuNhap()
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTu_GetPhieuNhap", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
