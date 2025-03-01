using Reporter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter.BUS
{
    public class KetQuaNoiTruThangBUS
    {
        private static KetQuaNoiTruThangBUS instance;
        public static KetQuaNoiTruThangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KetQuaNoiTruThangBUS();
                }
                return instance;
            }
        }
        private KetQuaNoiTruThangBUS() { }

        public List<KetQuaNoiTruThang> KhoiTaoDuLieu()
        {
            List<KetQuaNoiTruThang> danhSachKetQua = new List<KetQuaNoiTruThang>()
            {
                new KetQuaNoiTruThang(1, "Phòng cấp cứu nhi", 211, 279, 147, 132, 1127578, 860139),
                new KetQuaNoiTruThang(2, "Khoa Phục hồi chức năng (Nội trú)", 52, 63, 614, 532, 6805351, 6179409),
                new KetQuaNoiTruThang(3, "Khoa Y học cổ truyền", 104, 113, 1237, 1119, 7264273, 8559005),
                new KetQuaNoiTruThang(4, "Khoa Tâm Thần kinh - Cơ xương khớp", 245, 264, 1767, 1640, 7928496, 8207417),
                new KetQuaNoiTruThang(5, "Khoa Nội thần - tiết niệu và hô hấp", 205, 220, 2120, 2117, 14657859, 15210205),
                new KetQuaNoiTruThang(6, "Khoa Hồi sức tích cực Nội", 147, 157, 942, 1074, 43877909, 42022528),
                new KetQuaNoiTruThang(7, "Khoa Sơ sinh", 141, 162, 942, 814, 7165934, 6354251),
                new KetQuaNoiTruThang(8, "Khoa Nội tiết", 118, 123, 1590, 1490, 1273383, 1063512),
                new KetQuaNoiTruThang(9, "Khoa Nội Tiêu hóa", 116, 122, 1708, 1725, 8666249, 6834240),
                new KetQuaNoiTruThang(10, "Khoa Bệnh nhiệt đới", 194, 191, 1355, 1898, 9248895, 8319188),
                new KetQuaNoiTruThang(11, "Khoa chấn thương chỉnh hình và bỏng", 333, 327, 2651, 2375, 15593138, 14106876),
            };

            return danhSachKetQua;
        }

    }
}
