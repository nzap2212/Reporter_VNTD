using Reporter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter.BUS
{
    public class KetQuaThucHienDichVuTheoYeuCauBUS
    {
        private static KetQuaThucHienDichVuTheoYeuCauBUS instance;
        public static KetQuaThucHienDichVuTheoYeuCauBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KetQuaThucHienDichVuTheoYeuCauBUS();
                }
                return instance;
            }
        }
        private KetQuaThucHienDichVuTheoYeuCauBUS() { }

        public List<KetQuaThucHienDichVuTheoYeuCau> KhoiTaoDuLieu()
        {
            List<KetQuaThucHienDichVuTheoYeuCau> ketQuaThucHienDichVuTheoYeuCau
                = new List<KetQuaThucHienDichVuTheoYeuCau>
                {
                    new KetQuaThucHienDichVuTheoYeuCau(1, "Khoa Ngoại", "15", "8", "12"),
                    new KetQuaThucHienDichVuTheoYeuCau(2, "Khoa Nội", "10", "5", "7"),
                    new KetQuaThucHienDichVuTheoYeuCau(3, "Khoa Sản", "20", "10", "15"),
                    new KetQuaThucHienDichVuTheoYeuCau(4, "Khoa Nhi", "18", "9", "11"),
                    new KetQuaThucHienDichVuTheoYeuCau(5, "Khoa Cấp Cứu", "22", "12", "17"),
                    new KetQuaThucHienDichVuTheoYeuCau(6, "Khoa Hồi Sức", "14", "7", "10"),
                    new KetQuaThucHienDichVuTheoYeuCau(7, "Khoa Da Liễu", "9", "3", "5"),
                    new KetQuaThucHienDichVuTheoYeuCau(8, "Khoa Ung Bướu", "25", "13", "18"),
                    new KetQuaThucHienDichVuTheoYeuCau(9, "Khoa Tim Mạch", "16", "6", "10"),
                    new KetQuaThucHienDichVuTheoYeuCau(10, "Khoa Thận - Tiết Niệu", "12", "8", "9")
                };
            return ketQuaThucHienDichVuTheoYeuCau;
        }
    }
}
