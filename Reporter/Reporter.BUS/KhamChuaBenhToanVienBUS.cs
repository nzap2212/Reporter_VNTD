
using Reporter.DTO;

namespace Reporter.BUS
{
    public class KhamChuaBenhToanVienBUS
    {
        private static KhamChuaBenhToanVienBUS instance;
        public static KhamChuaBenhToanVienBUS Instance
        {
            get 
            {
                if(instance == null)
                {
                    instance = new KhamChuaBenhToanVienBUS();
                }
                return instance;
            }
        }
        private KhamChuaBenhToanVienBUS() { }

        private List<KhamChuaBenhToanVien> danhSachBaoCao = new List<KhamChuaBenhToanVien>() ;
        public List<KhamChuaBenhToanVien> KhoiTaoDuLieu()
        {
            danhSachBaoCao = new List<KhamChuaBenhToanVien>
            {
                new KhamChuaBenhToanVien("1", "Khám bệnh (toàn viện)", "Lượt", 28090, 19138),
                new KhamChuaBenhToanVien("2", "Khám bệnh (khoa khám bệnh)", "Lượt", 16150, 13152),
                new KhamChuaBenhToanVien("3", "Khám yêu cầu (khoa khám bệnh)", "Lượt", 3475, 2072),
                new KhamChuaBenhToanVien("4", "Khám cấp cứu (bao gồm CC Nhi)", "Lượt", 3148, 3258),
                new KhamChuaBenhToanVien("5", "Số NB vào nội trú", "NB", 4882, 3858),
                new KhamChuaBenhToanVien("6", "Tổng số ngày điều trị nội trú", "Ca", 33200, 28605),
                new KhamChuaBenhToanVien("7", "Công suất giường ĐT", "Ca", 0, 77),
                new KhamChuaBenhToanVien("8", "Số NB chuyển viện", "Ca", 208, 340),
                new KhamChuaBenhToanVien("9", "Đúng tuyến", "Ca", 185, 317),
                new KhamChuaBenhToanVien("10", "Trái tuyến", "Ca", 24, 23),
                new KhamChuaBenhToanVien("11", "Tổng số ca phẫu thuật", "Ca", 1224, 917),
                new KhamChuaBenhToanVien("12", "Số ca đẻ (bao gồm cả mổ đẻ)", "Ca", 363, 307),
                new KhamChuaBenhToanVien("13", "Chụp CT các loại", "Lần", 4860, 4873),
                new KhamChuaBenhToanVien("14", "MRI", "Lần", 816, 659),
                new KhamChuaBenhToanVien("15", "X-quang", "Lần", 11238, 9250),
                new KhamChuaBenhToanVien("16", "Siêu âm toàn viện", "Lần", 16714, 7044),
                new KhamChuaBenhToanVien("17", "Nội soi dạ dày", "Lần", 1349, 931),
                new KhamChuaBenhToanVien("18", "Nội soi đại, trực tràng", "Lần", 522, 375),
                new KhamChuaBenhToanVien("19", "Can thiệp tim mạch", "Lần", 522, 375),
                new KhamChuaBenhToanVien("20", "Xét nghiệm huyết học", "Lần", 522, 375),
                new KhamChuaBenhToanVien("21", "Xét nghiệm hóa sinh", "Lần", 522, 375),
                new KhamChuaBenhToanVien("22", "Giải phẫu bệnh", "Lần", 522, 375),
                new KhamChuaBenhToanVien("23", "Xét nghiệm vi sinh", "Lần", 522, 375),
                new KhamChuaBenhToanVien("24", "Điều trị bằng oxy cao áp", "", 522, 375),
                new KhamChuaBenhToanVien("25", "Giường yêu cầu", "Công suất", 522, 375),
                new KhamChuaBenhToanVien("26", "Dịch vụ mổ yêu cầu", "Ca", 522, 375),
                new KhamChuaBenhToanVien("", "Chọn phẫu thuật viện", "Lần", 522, 375),
                new KhamChuaBenhToanVien("", "Phẫu thuật mổ trong ngày/chọn ngày", "", null, 375),
                new KhamChuaBenhToanVien("", "Các dịch vụ mổ yêu cầu khác", "", null, 375),
            };

            return danhSachBaoCao;
        }
    }
}
