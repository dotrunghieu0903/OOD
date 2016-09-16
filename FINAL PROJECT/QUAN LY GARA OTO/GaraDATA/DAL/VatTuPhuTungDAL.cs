using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaraDATA.Info;
using System.Data.SqlClient;
using System.Data;

namespace GaraDATA.DAL
{
    public class VatTuPhuTungDAL:SqlDataProvider
    {
        //Hàm chèn vật tư phụ tùng xuống CSDL
        public void VatTuPhuTung_Insert(VatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.Parameters.Add(new SqlParameter("@SoLuongTon", Data.SoLuongTon));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        //Hàm lấy vật tư từ store procedure trả lên datatable
        public DataTable VatTu_GetAll()
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Hàm update vật tư phụ tùng 
        public void VatTu_Update(VatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.Parameters.Add(new SqlParameter("@SoLuongTon", Data.SoLuongTon));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        //Hàm xóa vật tư phụ tùng
        public void VatTu_Delete(VatTuPhuTung Data)
        {
            //Xoa vật tư phụ tùng thông qua Mã Vật Tư
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", Data.MaVatTu));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Hàm trả ra số lượng Vật Tư tồn kho
        public int VatTu_GetSoLuongTon(string VatTu)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_GetSoLuongTon", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTu", VatTu));
                return (int) cmd.ExecuteScalar();
            }
        }
    }
    
        
    
}
