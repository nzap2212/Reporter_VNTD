using Reporter.DTO;

namespace Reporter.BUS
{
    public class SoLieuPhongKhamYeuCauBUS
    {
        private static SoLieuPhongKhamYeuCauBUS instance;
        public static SoLieuPhongKhamYeuCauBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SoLieuPhongKhamYeuCauBUS();
                }
                return instance;
            }
        }
        private SoLieuPhongKhamYeuCauBUS() { }

        public List<SoLieuPhongKhamYeuCau> KhoiTaoDuLieu()
        {
            List<SoLieuPhongKhamYeuCau> danhSachSoLieu = new List<SoLieuPhongKhamYeuCau>
            {
                new SoLieuPhongKhamYeuCau(1, "Phòng khám và tư vấn dịch vụ sức khỏe", null, 3000, null, null, null,null),
                new SoLieuPhongKhamYeuCau(2, "PK Mắt yêu cầu", null, 3000, null, null, null, null),
                new SoLieuPhongKhamYeuCau(3, "PK Nhi yêu cầu", null, 3000, null, null, null, null),
                new SoLieuPhongKhamYeuCau(4, "PK Nội yêu cầu 1", null, 3000, null, null, null, null),
                new SoLieuPhongKhamYeuCau(5, "PK Nội yêu cầu 2", null, 3000, null, null, null, null),
                new SoLieuPhongKhamYeuCau(6, "PK Sản phụ yêu cầu", null, 3000, null, null, null, null),
                new SoLieuPhongKhamYeuCau(7, "PK Tai mũi họng yêu cầu", null, 3000, null, null, null, null),
                new SoLieuPhongKhamYeuCau(8, "PK Ngoại yêu cầu", null, 3000, null, null, null, null),
            };
            return danhSachSoLieu;
        }
    }
}
