using System;
using System.Collections.ObjectModel;
using Reporter_wpf.Models;

namespace Reporter_wpf.Services
{
    public class DataService
    {
        private static DataService instance;
        public static DataService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataService();
                }
                return instance;
            }
        }
        private DataService() { }

        public ObservableCollection<KhamChuaBenhToanVien> GetKhamChuaBenhData()
        {
            return new ObservableCollection<KhamChuaBenhToanVien>
            {
                new KhamChuaBenhToanVien("1", "Khám bệnh", "Lượt", 25000, 23500),
                new KhamChuaBenhToanVien("2", "Điều trị nội trú", "Bệnh nhân", 5000, 4800),
                new KhamChuaBenhToanVien("3", "Phẫu thuật", "Ca", 1200, 1150),
                new KhamChuaBenhToanVien("4", "Xét nghiệm", "Test", 35000, 34200),
                new KhamChuaBenhToanVien("5", "Chẩn đoán hình ảnh", "Ca", 8000, 7600),
                new KhamChuaBenhToanVien("6", "Thủ thuật", "Ca", 4500, 4300)
            };
        }

        public ObservableCollection<KetQuaNoiTruThang> GetKetQuaNoiTruData()
        {
            return new ObservableCollection<KetQuaNoiTruThang>
            {
                new KetQuaNoiTruThang(1, "Khoa Nội", 120, 115, 85, 80, 110, 105),
                new KetQuaNoiTruThang(2, "Khoa Ngoại", 100, 95, 90, 85, 95, 90),
                new KetQuaNoiTruThang(3, "Khoa Sản", 80, 75, 85, 80, 75, 70),
                new KetQuaNoiTruThang(4, "Khoa Nhi", 90, 85, 80, 75, 85, 80),
                new KetQuaNoiTruThang(5, "Khoa Tai Mũi Họng", 60, 55, 75, 70, 55, 50),
                new KetQuaNoiTruThang(6, "Khoa Mắt", 50, 45, 80, 75, 45, 40),
                new KetQuaNoiTruThang(7, "Khoa Răng Hàm Mặt", 40, 35, 85, 80, 35, 30),
                new KetQuaNoiTruThang(8, "Khoa Da liễu", 30, 25, 80, 75, 25, 20)
            };
        }

        public ObservableCollection<KetQuaThucHienDichVuTheoYeuCau> GetDichVuYeuCauData()
        {
            return new ObservableCollection<KetQuaThucHienDichVuTheoYeuCau>
            {
                new KetQuaThucHienDichVuTheoYeuCau(1, "Khoa Nội", "25", "15", "10"),
                new KetQuaThucHienDichVuTheoYeuCau(2, "Khoa Ngoại", "35", "20", "15"),
                new KetQuaThucHienDichVuTheoYeuCau(3, "Khoa Sản", "20", "10", "5"),
                new KetQuaThucHienDichVuTheoYeuCau(4, "Khoa Nhi", "15", "8", "3"),
                new KetQuaThucHienDichVuTheoYeuCau(5, "Khoa Tai Mũi Họng", "18", "10", "5"),
                new KetQuaThucHienDichVuTheoYeuCau(6, "Khoa Mắt", "22", "12", "8"),
                new KetQuaThucHienDichVuTheoYeuCau(7, "Khoa Răng Hàm Mặt", "30", "15", "10")
            };
        }

        public ObservableCollection<SoLieuPhongKhamKhoaKhamBenh> GetKhoaKhamBenhData()
        {
            return new ObservableCollection<SoLieuPhongKhamKhoaKhamBenh>
            {
                new SoLieuPhongKhamKhoaKhamBenh("Phòng khám Nội", 450, 520, 85),
                new SoLieuPhongKhamKhoaKhamBenh("Phòng khám Ngoại", 380, 420, 65),
                new SoLieuPhongKhamKhoaKhamBenh("Phòng khám Sản", 220, 240, 40),
                new SoLieuPhongKhamKhoaKhamBenh("Phòng khám Nhi", 320, 350, 55),
                new SoLieuPhongKhamKhoaKhamBenh("Phòng khám Tai Mũi Họng", 180, 200, 30),
                new SoLieuPhongKhamKhoaKhamBenh("Phòng khám Mắt", 150, 170, 25),
                new SoLieuPhongKhamKhoaKhamBenh("Phòng khám Răng Hàm Mặt", 200, 220, 35),
                new SoLieuPhongKhamKhoaKhamBenh("Phòng khám Da liễu", 120, 130, 20)
            };
        }

        public ObservableCollection<SoLieuPhongKhamNgoaiTru> GetPhongKhamNgoaiTruData()
        {
            return new ObservableCollection<SoLieuPhongKhamNgoaiTru>
            {
                new SoLieuPhongKhamNgoaiTru("Phòng khám Nội", 450, 520),
                new SoLieuPhongKhamNgoaiTru("Phòng khám Ngoại", 380, 420),
                new SoLieuPhongKhamNgoaiTru("Phòng khám Sản", 220, 240),
                new SoLieuPhongKhamNgoaiTru("Phòng khám Nhi", 320, 350),
                new SoLieuPhongKhamNgoaiTru("Phòng khám Tai Mũi Họng", 180, 200),
                new SoLieuPhongKhamNgoaiTru("Phòng khám Mắt", 150, 170),
                new SoLieuPhongKhamNgoaiTru("Phòng khám Răng Hàm Mặt", 200, 220),
                new SoLieuPhongKhamNgoaiTru("Phòng khám Da liễu", 120, 130)
            };
        }

        public ObservableCollection<SoLieuPhongKhamCapCuu> GetPhongKhamCapCuuData()
        {
            return new ObservableCollection<SoLieuPhongKhamCapCuu>
            {
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Nội", 450, 180),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Ngoại", 380, 210),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Sản", 220, 95),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Nhi", 320, 150),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Tai Mũi Họng", 180, 60),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Mắt", 120, 40),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Răng Hàm Mặt", 90, 25),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Thần kinh", 150, 85),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Tim mạch", 200, 110),
                new SoLieuPhongKhamCapCuu("Phòng cấp cứu Hồi sức", 280, 190)
            };
        }

        public ObservableCollection<SoLieuPhongKhamYeuCau> GetPhongKhamYeuCauData()
        {
            return new ObservableCollection<SoLieuPhongKhamYeuCau>
            {
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Nội", 320, 380, 95000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Ngoại", 280, 310, 85000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Sản", 190, 210, 65000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Nhi", 250, 290, 72000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Tai Mũi Họng", 150, 170, 51000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Mắt", 180, 200, 60000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Răng Hàm Mặt", 220, 240, 72000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Da liễu", 130, 150, 45000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Thần kinh", 110, 130, 39000000),
                new SoLieuPhongKhamYeuCau("Phòng khám yêu cầu Tim mạch", 160, 180, 54000000)
            };
        }
    }
}