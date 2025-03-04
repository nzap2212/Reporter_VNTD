using System;


namespace Reporter.DTO
{
    public class SoLieuPhongKhamNgoaiTru
    {
        public string PhongKham { get; set; }
        public int? KeHoach_TB_HS { get; set; }
        public int? TrungBinh_HS_BHYT { get; set; }
        public string SoSanhVoiChiTieu_BHYT { get; set; }

        public SoLieuPhongKhamNgoaiTru(
            string phongkham,
            int? kehoach_tb_hs, int? trungbinh_hs_bhyt)
        {
            PhongKham = phongkham;
            KeHoach_TB_HS = kehoach_tb_hs;
            TrungBinh_HS_BHYT = trungbinh_hs_bhyt;
            SoSanhVoiChiTieu_BHYT = (kehoach_tb_hs.HasValue && kehoach_tb_hs > 0)
                ? $"{(trungbinh_hs_bhyt.GetValueOrDefault() / (double)kehoach_tb_hs.Value) * 100}%"
                : "N/A";

        }
    }
}
