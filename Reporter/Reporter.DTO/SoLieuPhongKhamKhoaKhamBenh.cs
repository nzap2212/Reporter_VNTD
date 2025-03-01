using System;

namespace Reporter.DTO
{
    public class SoLieuPhongKhamKhoaKhamBenh
    {
        public int STT { get; set; }
        public string PhongKham { get; set; }

        //Chỉ tiêu lượt khám
        public int? ChiTieuNgay { get; set; }
        public int? SoNgayLamViec { get; set; }
        public int? Thang { get; set; }
        public string TyLe { get; set; }

        //Nhập viện
        public int? SoLuong { get; set; }
        public string TyLeNhapVien { get; set; }

        // Chỉ tiêu tài chính đối tượng BHYT 
        public int? KeHoach_HS { get; set; }
        public int? TrungBinh_HS { get; set; }
        public string SoSanhVoiChiTieu { get; set; }

        // Chỉ tiêu tài chính đối tượng VP
        public int? KeHoach_TB_HS { get; set; }
        public int? TrungBinh_HS_VP { get; set; }
        public string SoSanhVoiChiTieu_VP { get; set; }

        public SoLieuPhongKhamKhoaKhamBenh(
            int stt, string phongkham,
            int? chitieungay, int? thang, int? songaylamviec,
            int? soluong,
            int? kehoach_hs, int? trungbinh_hs,
            int? kehoach_tb_hs, int? trungbinh_hs_vp)
        {
            STT = stt;
            PhongKham = phongkham;

            ChiTieuNgay = chitieungay;
            Thang = thang;
            TyLe = (chitieungay.HasValue && songaylamviec.HasValue && chitieungay > 0)
                ? $"{(thang.GetValueOrDefault() / (chitieungay.Value * songaylamviec.Value)) * 100}%"
                : "N/A";

            SoLuong = soluong;
            TyLeNhapVien = (soluong.HasValue && thang.HasValue && thang > 0)
                ? $"{Math.Floor((double)(soluong.Value / thang.Value) * 100)}%"
                : "N/A";

            KeHoach_HS = kehoach_hs;
            TrungBinh_HS = trungbinh_hs;
            SoSanhVoiChiTieu = (kehoach_hs.HasValue && kehoach_hs > 0)
                ? $"{(trungbinh_hs.GetValueOrDefault() / (double)kehoach_hs.Value) * 100}%"
                : "N/A";

            KeHoach_TB_HS = kehoach_tb_hs;
            TrungBinh_HS_VP = trungbinh_hs_vp;
            SoSanhVoiChiTieu_VP = (kehoach_tb_hs.HasValue && kehoach_tb_hs > 0)
                ? $"{(trungbinh_hs_vp.GetValueOrDefault() / (double)kehoach_tb_hs.Value) * 100}%"
                : "N/A";
        }
    }
}
