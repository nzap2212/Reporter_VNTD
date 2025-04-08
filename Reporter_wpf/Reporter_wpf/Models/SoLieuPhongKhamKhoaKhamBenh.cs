namespace Reporter_wpf.Models
{
    public class SoLieuPhongKhamKhoaKhamBenh
    {
        public string PhongKham { get; set; }
        public int SoBenhNhan { get; set; }
        public int SoLuotKham { get; set; }
        public double TrungBinhLuotKham { get; set; }
        public int SoChuyenKhoa { get; set; }
        public string TyLeChuyenKhoa { get; set; }

        public SoLieuPhongKhamKhoaKhamBenh(string phongKham, int soBenhNhan, int soLuotKham, int soChuyenKhoa)
        {
            PhongKham = phongKham;
            SoBenhNhan = soBenhNhan;
            SoLuotKham = soLuotKham;
            SoChuyenKhoa = soChuyenKhoa;
            TrungBinhLuotKham = soBenhNhan > 0 ? Math.Round((double)soLuotKham / soBenhNhan, 2) : 0;
            TyLeChuyenKhoa = soBenhNhan > 0 ? Math.Round((double)soChuyenKhoa / soBenhNhan * 100, 2) + "%" : "-";
        }
    }
} 