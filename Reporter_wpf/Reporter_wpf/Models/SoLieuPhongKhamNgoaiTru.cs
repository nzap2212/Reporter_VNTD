namespace Reporter_wpf.Models
{
    public class SoLieuPhongKhamNgoaiTru
    {
        public string PhongKham { get; set; }
        public int SoBenhNhan { get; set; }
        public int SoLuotKham { get; set; }
        public double TrungBinhLuotKham { get; set; }

        public SoLieuPhongKhamNgoaiTru(string phongKham, int soBenhNhan, int soLuotKham)
        {
            PhongKham = phongKham;
            SoBenhNhan = soBenhNhan;
            SoLuotKham = soLuotKham;
            TrungBinhLuotKham = soBenhNhan > 0 ? Math.Round((double)soLuotKham / soBenhNhan, 2) : 0;
        }
    }
} 