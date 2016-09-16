using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.Info;

namespace GaraDATA.DAL
{
    public class CT_PhieuSuaChuaDAL:SqlDataProvider
    {
        //Hàm chèn chi tiết phiếu sửa chữa
        public void CT_PhieuSuaChua_Insert(CT_PhieuSuaChua Data)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSuaChua", Data.MaSuaChua));
                cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", Data.NoiDungSuaChua));
                cmd.Parameters.Add(new SqlParameter("@TienCong", Data.TienCong));
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.Parameters.Add((new SqlParameter("@SoLuong", Data.SoLuong)));
                cmd.Parameters.Add((new SqlParameter("@DonGia", Data.DonGia)));
                cmd.Parameters.Add((new SqlParameter("@ThanhTien", Data.ThanhTien)));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Hàm lấy chi tiết phiếu sửa chữa qua mã sửa chữa
        public DataTable CT_PhieuSuaChua_GetByMaSuaChua(string MaSC)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_GetByMaSuaChua",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSuaChua", MaSC));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm lấy chi tiết phiếu sửa chữa thông qua Biển Số
        public DataTable CT_PhieuSuaChua_GetByBienSo(string BienSo)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_GetByBienSo", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm kiểm tra chi tiết Phiếu sửa chữa lên data table
        public DataTable CT_PhieuSuaChua_KiemTra(string MSC,string NoiDung)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_KiemTra", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSuaChua", MSC));
                cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", NoiDung));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm xóa chi tiết Phiếu Sửa Chữa
        public void CT_PhieuSuaChua_Delete(string msc,string noidung)
        {
            using (var cmd=new SqlCommand("sp_CT_PhieuSuaChua_Delete",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSuaChua", msc));
                cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", noidung));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
