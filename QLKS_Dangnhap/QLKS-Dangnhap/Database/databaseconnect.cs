using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLKS_Dangnhap.Database
{
    public class DatabaseConnection
    {
        private readonly string connectionString;
        public DatabaseConnection()
        {
            // Lấy chuỗi kết nối từ file cấu hình App.config
            connectionString = ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}