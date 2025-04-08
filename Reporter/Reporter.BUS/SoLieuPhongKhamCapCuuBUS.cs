using Reporter.DAL;
using Reporter.DTO;

namespace Reporter.BUS
{
    public class SoLieuPhongKhamCapCuuBUS
    {
        private static SoLieuPhongKhamCapCuuBUS instance;
        public static SoLieuPhongKhamCapCuuBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SoLieuPhongKhamCapCuuBUS();
                }
                return instance;
            }
        }
        private SoLieuPhongKhamCapCuuBUS() { }

        private string connectionStr = "Server=192.168.1.2;Database=eHospital_ThuyDienUB;User Id=DEV_BV;Password=DEVBV@123#@!;";

        public List<SoLieuPhongKhamCapCuu> KhoiTaoDuLieu(string ngayvao, string ngayra)
        {
            string Query = $@"SELECT
	                            TenPhongBan = pb.TenPhongBan, 
	                            LuotKham = COUNT(*),
	                            NhapVien = COUNT(CASE WHEN lt.LyDoRa_Code = 'CK' THEN 1 END)
                                FROM NoiTru_LuuTru lt
                                LEFT JOIN DM_PhongBan pb on lt.PhongBan_Id = pb.PhongBan_Id
                                WHERE  lt.PhongBan_Id IN (40, 621, 64, 105)
                                AND LyDoVao_Code='NM' AND lt.thoigianvao  BETWEEN '{ngayvao}' AND '{ngayra}'
                                group by pb.TenPhongBan";
            return Bang6_DAL.Instance.GetBang6FromDB(connectionStr, Query);
        }
    }
}
