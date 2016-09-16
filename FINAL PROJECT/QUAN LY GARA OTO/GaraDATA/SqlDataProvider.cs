using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace GaraDATA
{
    public class SqlDataProvider
    {
       public static string connectionstring;//khai báo chuỗi kết nối
       public static SqlConnection connection;//kết nối
        //Constructor SqlDataProvider
        public SqlDataProvider()
        {//Nếu connection null khởi tạo connection
            if (connection == null)
            {
                //chuỗi kết nối
               connectionstring = @"Data Source=VEN\VEN;Initial Catalog=QUAN LY GARA OTO;Integrated Security=True";
              
               connection = new SqlConnection(connectionstring);
               
            }
        }
        //Constructor SqlDataProvider với tham số truyền vào
        public SqlDataProvider(string n_connectionstring)
        {
            connectionstring = n_connectionstring;
            connection = new SqlConnection(connectionstring);
        }
        //Hàm trả về kết nối và đóng mở kết nối
        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                return connection;
            }
            else
            {
                return connection;
            }
        }
       
    }
}
