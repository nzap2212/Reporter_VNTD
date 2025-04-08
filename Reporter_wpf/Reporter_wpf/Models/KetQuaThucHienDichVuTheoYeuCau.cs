namespace Reporter_wpf.Models
{
    public class KetQuaThucHienDichVuTheoYeuCau
    {
        public int STT { get; set; }
        public string TenKhoa { get; set; }
        public string Tong { get; set; }
        public string ChonPTV { get; set; }
        public string MoSom { get; set; }
        public string GoiPT { get; set; }

        public KetQuaThucHienDichVuTheoYeuCau(int sTT, string tenKhoa, string chonPTV, string moSom, string goiPT)
        {
            STT = sTT;
            TenKhoa = tenKhoa;
            ChonPTV = chonPTV;
            MoSom = moSom;
            GoiPT = goiPT;
            Tong = (Convert.ToInt32(chonPTV) + Convert.ToInt32(moSom) + Convert.ToInt32(goiPT)).ToString();
        }
    }
} 