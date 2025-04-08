using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reporter.DTO;

namespace Reporter.DAL
{
    public class Bang6_DAL
    {
        private static Bang6_DAL? instance;
        public static Bang6_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bang6_DAL();
                }
                return instance;
            }
        }
        private Bang6_DAL() { }

        public List<SoLieuPhongKhamCapCuu> GetBang6FromDB(string connectionStr, string query)
        {
            List<SoLieuPhongKhamCapCuu> Bang6 = new List<SoLieuPhongKhamCapCuu>();
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string PhongKham = !reader.IsDBNull(0) ? reader.GetString(0) : "Không có thông tin";
                        int TongSoDenKham = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;
                        int TongSoNhapVien = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0;

                        Bang6.Add(new SoLieuPhongKhamCapCuu(PhongKham, TongSoDenKham, TongSoNhapVien));
                    }
                }
                return Bang6;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
