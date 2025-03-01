using Reporter.DTO;
using Microsoft.Data.SqlClient;

namespace Reporter.DAL
{
    public class KhamChuaBenhToanVienDAL
    {
        public static List<KhamChuaBenhToanVien> _khamChuaBenhToanVienDAL = new List<KhamChuaBenhToanVien>();
        private string connectionString = "";
        public List<KhamChuaBenhToanVien> GetSoluongThucTe()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(QueryStorage.GET_TOTAL_COUNT, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                
            }

            return _khamChuaBenhToanVienDAL;
        }
    }
}
