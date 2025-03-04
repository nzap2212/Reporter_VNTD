using System;

namespace Reporter.DTO
{
    public class SoLieuPhongKhamCapCuu
    {
        public string PhongKham { get; set; }

        //Nhập viện
        public int? TongSoDenKham { get; set; }
        public int? TongSoNhapVien { get; set; }
        public string TyLeNhapVien { get; set; }

        public SoLieuPhongKhamCapCuu(
            string phongkham,
            int? tongsodenkham, int? tongsonhapvien)
        {
            PhongKham = phongkham;
            TongSoDenKham = tongsodenkham;
            TongSoNhapVien = tongsonhapvien;
            TyLeNhapVien = (tongsodenkham.HasValue && tongsonhapvien > 0)
                ? $"{(tongsonhapvien.GetValueOrDefault() / (double)tongsodenkham.Value) * 100}%"
                : "N/A";

        }
    }
}
