namespace Reporter_wpf.Models
{
    public class SoLieuPhongKhamYeuCau
    {
        public string PhongKham { get; set; }
        public int SoBenhNhan { get; set; }
        public int SoLuotKham { get; set; }
        public double TrungBinhLuotKham { get; set; }
        public decimal DoanhThu { get; set; }
        public decimal TrungBinhDoanhThu { get; set; }

        public SoLieuPhongKhamYeuCau(string phongKham, int soBenhNhan, int soLuotKham, decimal doanhThu)
        {
            PhongKham = phongKham;
            SoBenhNhan = soBenhNhan;
            SoLuotKham = soLuotKham;
            DoanhThu = doanhThu;
            TrungBinhLuotKham = soBenhNhan > 0 ? Math.Round((double)soLuotKham / soBenhNhan, 2) : 0;
            TrungBinhDoanhThu = soBenhNhan > 0 ? Math.Round(doanhThu / soBenhNhan, 2) : 0;
        }
    }
} 