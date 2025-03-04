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

        public List<SoLieuPhongKhamCapCuu> KhoiTaoDuLieu()
        {
            List<SoLieuPhongKhamCapCuu> danhSachSoLieu = new List<SoLieuPhongKhamCapCuu>
            {
                new SoLieuPhongKhamCapCuu("Cấp cứu", null, 3000),
                new SoLieuPhongKhamCapCuu("Cấp cứu Nhi", null, 3000),
                new SoLieuPhongKhamCapCuu("Khoa Điều trị theo yêu cầu", null, 3000),
                new SoLieuPhongKhamCapCuu("Khoa Sản", null, 3000),

            };
            return danhSachSoLieu;
        }
    }
}
