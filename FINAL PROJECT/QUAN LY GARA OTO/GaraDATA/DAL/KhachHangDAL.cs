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
    public class KhachHangDAL:SqlDataProvider
    {
        //hàm chèn khách hàng xuống CSDL
        public void KhachHang_Insert(KhachHang Data)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_Insert",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Data.TenChuXe));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.HieuXe));
                cmd.Parameters.Add(new SqlParameter("@DienThoai", Data.DienThoai));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@NgayTiepNhan", Data.NgayTiepNhan));
                cmd.Parameters.Add(new SqlParameter("@SoTienNo", Data.TienNo));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Hàm cập nhật thông tin khách hàng
        public void KhachHang_Update(KhachHang Data)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Data.TenChuXe));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.HieuXe));
                cmd.Parameters.Add(new SqlParameter("@DienThoai", Data.DienThoai));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@NgayTiepNhan", Data.NgayTiepNhan));
                cmd.Parameters.Add(new SqlParameter("@SoTienNo", Data.TienNo));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Hàm xóa thông tin khách hàng theo biển số
        public void KhachHang_Delete(string BienSo)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                cmd.ExecuteNonQuery();
            }
        }

        //Hàm lấy danh sách khách hàng lên data table
        public DataTable KhachHang_DanhSach()
        {
            using (var cmd = new SqlCommand("sp_KhachHang_DanhSach",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Hàm lấy thông tin khách hàng thông qua tìm biển số
        public DataTable KhachHang_TimKiemBienSo(KhachHang Data)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_TimKiemBienSo", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Hàm lấy thông tin khách hàng theo ngày tiếp nhận
        public DataTable KhachHang_DStheoNgay(string NgayTiepNhan)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_DStheoNgay", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NgayTiepNhan", NgayTiepNhan));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm trả về số lượng danh sách khách hàng theo ngày tiếp nhận
        public int KhachHang_CountDStheoNgay(string Ngay)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_CountDStheoNgay", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NgayTiepNhan", Ngay));
                
                return (int)cmd.ExecuteScalar();
            }
        }
        //Hàm lấy thông tin khách hàng theo Tên Chủ Xe
        public DataTable KhachHang_GetByTenChuXe(string Ten)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_GetByTenChuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Ten));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm lấy thông tin khách hàng theo Biển Số
        public DataTable KhachHang_GetByBienSo(string BienSo)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_GetByBienSo", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm lấy thông tin khách hàng theo Hiệu Xe
        public DataTable KhachHang_GetByHieuXe(string HieuXe)
        {
            using (var cmd = new SqlCommand("sp_KhachHang_GetByHieuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", HieuXe));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Hàm lấy danh sách khách hàng đã sửa chữa
        public DataTable KhachHang_DSdaSuaChua()
        {
            using (var cmd = new SqlCommand("sp_KhachHang_DSdaSuaChua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm lấy danh sách khách hàng đã thu tiền
        public DataTable KhachHang_DSdaThuTien()
        {
            using (var cmd = new SqlCommand("sp_KhachHang_DSdaThuTien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Hàm trả về thông tin khách hàng theo số lượt sửa xe
        public int KhachHang_SoLuotXeSua()
        {
            using (var cmd=new SqlCommand("sp_SoLuotSuaXe",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
