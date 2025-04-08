using System;

namespace Reporter_wpf.Models
{
    public class KhamChuaBenhToanVien
    {
        public string STT { get; set; }
        public string HoatDong { get; set; }
        public string DonVi { get; set; }
        public object KeHoach { get; set; } 
        public object ThucHien { get; set; } 
        public string TyLeThucHien { get; set; }

        public KhamChuaBenhToanVien(string stt, string hoatDong, string donVi, object keHoach, object thucHien)
        {
            STT = stt;
            HoatDong = hoatDong;
            DonVi = donVi;
            KeHoach = keHoach;
            ThucHien = thucHien;
            TyLeThucHien = Convert.ToInt32(keHoach) > 0 ? (Convert.ToInt32(thucHien) * 100 / Convert.ToInt32(keHoach)) + "%" : "-";
        }
    }
} 