using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GaraDATA.DAL
{
   public class MayChuDAL:SqlDataProvider
    {
       private SqlCommand cmd;
       private SqlDataReader dr;
       //hàm lưu chuỗi kết nối nếu có nhiều hơn 1 connect
       public void LuuChuoiCSDL(string n_connectstring)
       {
           SqlDataProvider con = new SqlDataProvider(n_connectstring);
       }

       //hàm sao lưu dữ liệu từ máy chủ
       public void SaoLuuDLTuMayChu()
       {
           try
           {
               SqlConnection con = new SqlConnection(connectionstring);
               string query = "Backup database [QUAN LY GARA OTO] to disk= 'E:\\HK6\\MAINTANCE\\FINAL PROJECT\\QUAN LY GARA OTO\\GaraUI\\bin\\Debug\\QUAN LY GARA OTO.bak'";

               
               con.Open();
               cmd = new SqlCommand(query, con);
               cmd.ExecuteNonQuery();
               con.Close();
               
           }
           catch (SqlException e)
           {
               throw e;
           }
       }

       //Hàm lấy danh sách máy chủ hiện có 
       public List<string> LayDSMayChu()
       {
           List<string> ds_TenMayChu = new List<string>();
           DataTable dt = Microsoft.SqlServer.Management.Smo.SmoApplication.EnumAvailableSqlServers();
           foreach (DataRow dr in dt.Rows)
           {
               if (bool.Parse(dr["IsLocal"].ToString()) == true)
               {
                   ds_TenMayChu.Add(dr["Name"].ToString());
               }
           }
           return ds_TenMayChu;
       }

       //Hàm lấy CSDL trên máy chủ
       public List<string> LayDSCSDLTrenMayChu(string TenMayChu)
       {
           List<string> ds_Csdl = new List<string>();
           string str = "Server=" + TenMayChu + ";" + "Initial Catalog=master ;Integrated Security = True";
           SqlDataProvider con = new SqlDataProvider(str);
           GetConnection();
           cmd = new SqlCommand("use master", GetConnection());
           cmd.ExecuteNonQuery();
           cmd = new SqlCommand("sp_databases", GetConnection());
           dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               ds_Csdl.Add(dr[0].ToString());
           }
           GetConnection();

           SqlDataProvider con1 = new SqlDataProvider("Server=" + TenMayChu + ";" + "Initial Catalog=QUAN LY GARA OTO ;Integrated Security = True");
           return ds_Csdl;
       }
       //Hàm khôi phục CSDL
       public void KhoiPhucDuLieuLenMayChu(string TenMayChu)
       {
           try
           {
               if (File.Exists(Application.StartupPath + @"\QUAN LY GARA OTO.mdf"))
               {
                   File.Delete(Application.StartupPath + @"\QUAN LY GARA OTO.mdf");
                   File.Delete(Application.StartupPath + @"\QUAN LY GARA OTO_log.ldf");
               }
               string str = "Server=" + TenMayChu + ";Initial Catalog=master ;Integrated Security = True";
               SqlConnection con = new SqlConnection(str);
               //Connect SQL-----------
               con.Open();
               //-----------------------------------------------------------------------------------------

               //Excute SQL----------------
               cmd = new SqlCommand("use master", con);
               cmd.ExecuteNonQuery();

               string txt1 = "RESTORE FILELISTONLY FROM DISK=" + "'" + Application.StartupPath + "\\QUAN LY GARA OTO.BAK" + "'";
               cmd = new SqlCommand(txt1,con);
               cmd.ExecuteNonQuery();

               string txt2 = "restore database [QUAN LY GARA OTO] from disk= '"  + Application.StartupPath + "\\QUAN LY GARA OTO.BAK" + "'" + " WITH MOVE " + "'QUAN LY GARA OTO'" + " TO " + "'" + Application.StartupPath + @"\QUAN LY GARA OTO.mdf" + "'" + ", MOVE " + "'QUAN LY GARA OTO_log'" + " TO " + "'" + Application.StartupPath + "\\QUAN LY GARA OTO.ldf" + "'";
               cmd = new SqlCommand(txt2, con);
               cmd.ExecuteNonQuery();
               //--------------------------------------------------------------------------------------------------------
               con.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       //Hàm xóa CSDL
       public void XoaCSDL(string TenMayChu)
       {
           try
           {
               string str1 = "Server=" + TenMayChu + ";Initial Catalog=master ;Integrated Security = True";
               SqlConnection con1 = new SqlConnection(str1);

               con1.Open();
               cmd = new SqlCommand("use master", con1);
               cmd.ExecuteNonQuery();

               string str2 = "Server=" + TenMayChu + ";Initial Catalog=QUAN LY GARA OTO ;Integrated Security = True";
               SqlConnection con2 = new SqlConnection(str2);
               con2.Close();
               
               cmd = new SqlCommand("ALTER DATABASE [QUAN LY GARA OTO] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", con1);
               cmd.ExecuteNonQuery();
               cmd = new SqlCommand("drop database [QUAN LY GARA OTO]", con1);
               cmd.ExecuteNonQuery();
               con1.Close();
               
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
