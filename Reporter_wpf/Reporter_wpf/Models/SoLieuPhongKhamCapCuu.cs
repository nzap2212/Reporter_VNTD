namespace Reporter_wpf.Models
{
    public class SoLieuPhongKhamCapCuu
    {
        public string PhongKham { get; set; }
        public int TongSoDenKham { get; set; }
        public int TongSoNhapVien { get; set; }
        public string TyLeNhapVien { get; set; }

        public SoLieuPhongKhamCapCuu(string phongKham, int tongSoDenKham, int tongSoNhapVien)
        {
            PhongKham = phongKham;
            TongSoDenKham = tongSoDenKham;
            TongSoNhapVien = tongSoNhapVien;
            TyLeNhapVien = tongSoDenKham > 0 ? Math.Round((double)tongSoNhapVien / tongSoDenKham * 100, 2) + "%" : "-";
        }
    }
} 