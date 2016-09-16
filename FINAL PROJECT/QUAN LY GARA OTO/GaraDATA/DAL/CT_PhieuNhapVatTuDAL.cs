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
    public class CT_PhieuNhapVatTuDAL:SqlDataProvider
    {

        //Hàm chèn chi tiết phiếu vật tư
        public void CT_PhieuNhapVatTu_Insert(CT_PhieuNhapVatTu Data)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuNhapVatTu_Insert",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuNhap", Data.MaPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.Parameters.Add(new SqlParameter("@NhaSX", Data.NhaSX));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        ////Hàm lấy chi tiết phiếu vật tư qua mã phiếu nhập
        public DataTable CT_PhieuNhapVatTu_GetByPhieuNhap(string MPN)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuNhapVatTu_GetByPhieuNhap", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuNhap", MPN));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Hàm xóa chi tiết phiếu vật tư thông qua mã vật tư và mã phiếu nhập
        public void CT_PhieuNhapVatTu_Delete(string MPN,string MVT)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuNhapVatTu_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuNhap", MPN));
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", MVT));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
