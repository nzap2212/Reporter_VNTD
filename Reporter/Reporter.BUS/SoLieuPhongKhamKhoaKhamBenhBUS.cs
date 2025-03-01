using Reporter.DTO;

namespace Reporter.BUS
{
    public class SoLieuPhongKhamKhoaKhamBenhBUS
    {
        private static SoLieuPhongKhamKhoaKhamBenhBUS instance;
        public static SoLieuPhongKhamKhoaKhamBenhBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SoLieuPhongKhamKhoaKhamBenhBUS();
                }
                return instance;
            }
        }
        private SoLieuPhongKhamKhoaKhamBenhBUS() { }
        
        public List<SoLieuPhongKhamKhoaKhamBenh> KhoiTaoDuLieu()
        {
            List<SoLieuPhongKhamKhoaKhamBenh> danhSachSoLieu = new List<SoLieuPhongKhamKhoaKhamBenh>
            {
                new SoLieuPhongKhamKhoaKhamBenh(1, "PK Bệnh Nhiệt Đới - Da liễu", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(2, "PK Mắt", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(3, "PK Ngoại 01", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(4, "PK Ngoại 02", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(5, "PK Nhi", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(6, "PK Nội hô hấp, Thận tiết niệu", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(7, "PK Nội thần kinh, cơ xương khớp", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(8, "PK Nội tiết 01", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(9, "PK Nội tiết 02", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(10, "PK Nội tiêu hóa", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(11, "PK Nội tim mạch 01", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(12, "PK Nội tim mạch 02", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(13, "PK Phục hồi chức năng", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(14, "PK Răng hàm mặt", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(15, "PK Sản phụ khoa", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(16, "PK Tai mũi họng", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(17, "PK Tâm bệnh", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(18, "PK Ung bướu", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(19, "PK Y học cổ truyền", null, 3000, null, null, null, null, null, null),
                new SoLieuPhongKhamKhoaKhamBenh(20, "PK Can Thiệp Tim Mạch - Lồng ngực", null, 3000, null, null, null, null, null, null)
            };
            return danhSachSoLieu;
        }
    }
}
