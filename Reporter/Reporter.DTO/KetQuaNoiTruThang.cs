using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter.DTO
{
    public class KetQuaNoiTruThang
    {
        public int STT { get; set; }
        public string? TenKhoa { get; set; }
        public int KeHoach_chitieu { get; set; }
        public int ThucHien_chitieu { get; set; }
        public string TyLe_chitieu { get; set; }

        public int KeHoach_CongSuat { get; set; }
        public int ThucHien_CongSuat { get; set; }
        public string TyLe_CongSuat { get; set; }

        public int KeHoach_BenhAn { get; set; }
        public int ThucHien_BenhAn { get; set; }
        public string TyLe_BenhAn { get; set; }

        public KetQuaNoiTruThang(int stt, string tenkhoa, 
            int kehoach_chitieu, int thuchien_chitieu,
            int kehoach_congsuat, int thuchien_congsuat,
            int kehoach_benhan, int thuchien_benhan
            )
        {
            STT = stt;
            TenKhoa = tenkhoa;
            KeHoach_chitieu = kehoach_chitieu;
            ThucHien_chitieu = thuchien_chitieu;
            KeHoach_CongSuat = kehoach_congsuat;
            ThucHien_CongSuat = thuchien_congsuat;
            KeHoach_BenhAn = kehoach_benhan;
            ThucHien_BenhAn = thuchien_benhan;

            TyLe_chitieu = kehoach_chitieu > 0 ? (thuchien_chitieu * 100 / kehoach_chitieu) + "%" : "-";
            TyLe_CongSuat = kehoach_congsuat > 0 ? (thuchien_congsuat * 100 / kehoach_congsuat) + "%" : "-";
            TyLe_BenhAn = kehoach_benhan > 0 ? (thuchien_benhan * 100 / kehoach_benhan) + "%" : "-";
        }
    }
}
