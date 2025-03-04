using Reporter.DTO;

namespace Reporter.BUS
{
    public class SoLieuPhongKhamNgoaiTruBUS
    {
        private static SoLieuPhongKhamNgoaiTruBUS instance;
        public static SoLieuPhongKhamNgoaiTruBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SoLieuPhongKhamNgoaiTruBUS();
                }
                return instance;
            }
        }
        private SoLieuPhongKhamNgoaiTruBUS() { }

        public List<SoLieuPhongKhamNgoaiTru> KhoiTaoDuLieu()
        {
            List<SoLieuPhongKhamNgoaiTru> danhSachSoLieu = new List<SoLieuPhongKhamNgoaiTru>
            {
                new SoLieuPhongKhamNgoaiTru("Khoa Nhi (Ngoại trú)", null, 3000),
                new SoLieuPhongKhamNgoaiTru("Khoa Nội Thận - Tiết niệu - Hô hấp (Ngoại trú)", null, 3000),
                new SoLieuPhongKhamNgoaiTru("Khoa Phục hồi chức năng", null, 3000),
                new SoLieuPhongKhamNgoaiTru("Khoa Y học cổ truyền (Ngoại trú)", null, 3000),

            };
            return danhSachSoLieu;
        }
    }
}
