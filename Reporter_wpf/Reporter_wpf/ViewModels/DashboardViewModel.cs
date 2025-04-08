using System.Collections.ObjectModel;
using System.Windows.Input;
using Reporter_wpf.Helpers;
using Reporter_wpf.Models;
using Reporter_wpf.Services;

namespace Reporter_wpf.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        private int _totalPatients;
        private int _totalVisits;
        private int _totalEmergency;
        private int _totalInpatient;
        private decimal _totalRevenue;

        public int TotalPatients
        {
            get => _totalPatients;
            set => SetProperty(ref _totalPatients, value);
        }

        public int TotalVisits
        {
            get => _totalVisits;
            set => SetProperty(ref _totalVisits, value);
        }

        public int TotalEmergency
        {
            get => _totalEmergency;
            set => SetProperty(ref _totalEmergency, value);
        }

        public int TotalInpatient
        {
            get => _totalInpatient;
            set => SetProperty(ref _totalInpatient, value);
        }

        public decimal TotalRevenue
        {
            get => _totalRevenue;
            set => SetProperty(ref _totalRevenue, value);
        }

        public DashboardViewModel()
        {
            // Khởi tạo giá trị mặc định
            TotalPatients = 0;
            TotalVisits = 0;
            TotalEmergency = 0;
            TotalInpatient = 0;
            TotalRevenue = 0;
        }

        public void LoadData()
        {
            // Tính tổng số bệnh nhân từ các nguồn dữ liệu
            var ngoaiTruData = DataService.Instance.GetPhongKhamNgoaiTruData();
            var capCuuData = DataService.Instance.GetPhongKhamCapCuuData();
            var yeuCauData = DataService.Instance.GetPhongKhamYeuCauData();
            var noiTruData = DataService.Instance.GetKetQuaNoiTruData();

            // Tính tổng số bệnh nhân
            TotalPatients = 0;
            foreach (var item in ngoaiTruData)
            {
                TotalPatients += item.SoBenhNhan;
            }

            // Tính tổng số lượt khám
            TotalVisits = 0;
            foreach (var item in ngoaiTruData)
            {
                TotalVisits += item.SoLuotKham;
            }

            // Tính tổng số cấp cứu
            TotalEmergency = 0;
            foreach (var item in capCuuData)
            {
                TotalEmergency += item.TongSoDenKham;
            }

            // Tính tổng số nội trú
            TotalInpatient = 0;
            foreach (var item in noiTruData)
            {
                TotalInpatient += item.ThucHien_chitieu;
            }

            // Tính tổng doanh thu
            TotalRevenue = 0;
            foreach (var item in yeuCauData)
            {
                TotalRevenue += item.DoanhThu;
            }
        }

        public void Reset()
        {
            TotalPatients = 0;
            TotalVisits = 0;
            TotalEmergency = 0;
            TotalInpatient = 0;
            TotalRevenue = 0;
        }
    }
} 