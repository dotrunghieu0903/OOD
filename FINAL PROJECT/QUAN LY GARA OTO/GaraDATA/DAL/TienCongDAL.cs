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
    public class TienCongDAL:SqlDataProvider
    {
        //Hàm lấy tất cả tiền công lên data table
        public DataTable TienCong_GetAll()
        {
            using (var cmd = new SqlCommand("sp_TienCong_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Hàm chèn tiền công xuống CSDL
        public void TienCong_Insert(TienCong Data)
        {
            using (var cmd = new SqlCommand("sp_TienCong_Insert", GetConnection()))
            {
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", Data.NoiDungSuaChua));
                    cmd.Parameters.Add(new SqlParameter("@TienCong", Data.GiaTienCong));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        //Hàm update tiền công
        public void TienCong_Update(TienCong Data)
        {
            using (var cmd = new SqlCommand("sp_TienCong_Update", GetConnection()))
            {
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", Data.NoiDungSuaChua));
                    cmd.Parameters.Add(new SqlParameter("@TienCong", Data.GiaTienCong));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //Hàm xóa tiền công (xóa nội dung sửa chữa)
        public void TienCong_Delete(TienCong Data)
        {
            using (var cmd = new SqlCommand("sp_TienCong_Delete", GetConnection()))
            {
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", Data.NoiDungSuaChua));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
