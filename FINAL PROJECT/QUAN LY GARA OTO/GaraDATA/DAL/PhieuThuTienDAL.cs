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
    public class PhieuThuTienDAL:SqlDataProvider
    {
        //Hàm chèn phiếu thu tiền
        public void PhieuThuTien_Insert(PhieuThuTien Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_Insert",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@TongTienThu", Data.SoTienThu));
                cmd.Parameters.Add(new SqlParameter("@NgayThuTien", Data.NgayThuTien));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
