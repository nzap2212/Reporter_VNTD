using System;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using Reporter_wpf.Helpers;
using Reporter_wpf.Services;
using Reporter_wpf.Views;

namespace Reporter_wpf.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private UserControl _currentView;
        private DateTime _startDate;
        private DateTime _endDate;
        private string _statusMessage;
        private bool _isDataLoaded;

        // Views
        private readonly DashboardView _dashboardView;
        private readonly KhamChuaBenhView _khamChuaBenhView;
        private readonly KetQuaNoiTruView _ketQuaNoiTruView;
        private readonly DichVuYeuCauView _dichVuYeuCauView;
        private readonly KhoaKhamBenhView _khoaKhamBenhView;
        private readonly PhongKhamNgoaiTruView _phongKhamNgoaiTruView;
        private readonly PhongKhamCapCuuView _phongKhamCapCuuView;
        private readonly PhongKhamYeuCauView _phongKhamYeuCauView;
        private readonly SettingsView _settingsView;
        private readonly ReportsView _reportsView;

        // Commands
        public ICommand NavigateCommand { get; }
        public ICommand LoadDataCommand { get; }
        public ICommand ExportToWordCommand { get; }
        public ICommand ResetCommand { get; }

        public UserControl CurrentView
        {
            get => _currentView;
            set
            {
                Console.WriteLine($"Setting CurrentView to: {value?.GetType().Name}");
                SetProperty(ref _currentView, value);
            }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set => SetProperty(ref _startDate, value);
        }

        public DateTime EndDate
        {
            get => _endDate;
            set => SetProperty(ref _endDate, value);
        }

        public string StatusMessage
        {
            get => _statusMessage;
            set => SetProperty(ref _statusMessage, value);
        }

        public bool IsDataLoaded
        {
            get => _isDataLoaded;
            set
            {
                if (SetProperty(ref _isDataLoaded, value))
                {
                    Console.WriteLine($"IsDataLoaded changed to: {value}");
                    // Thông báo cho UI cập nhật trạng thái của các command
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        public MainViewModel()
        {
            Console.WriteLine("MainViewModel constructor called");
            
            try
            {
                // Khởi tạo các views và đặt DataContext cho chúng
                _dashboardView = new DashboardView { DataContext = new DashboardViewModel() };
                _khamChuaBenhView = new KhamChuaBenhView { DataContext = new KhamChuaBenhViewModel() };
                _ketQuaNoiTruView = new KetQuaNoiTruView { DataContext = new KetQuaNoiTruViewModel() };
                _dichVuYeuCauView = new DichVuYeuCauView { DataContext = new DichVuYeuCauViewModel() };
                _khoaKhamBenhView = new KhoaKhamBenhView { DataContext = new KhoaKhamBenhViewModel() };
                _phongKhamNgoaiTruView = new PhongKhamNgoaiTruView { DataContext = new PhongKhamNgoaiTruViewModel() };
                _phongKhamCapCuuView = new PhongKhamCapCuuView { DataContext = new PhongKhamCapCuuViewModel() };
                _phongKhamYeuCauView = new PhongKhamYeuCauView { DataContext = new PhongKhamYeuCauViewModel() };
                _settingsView = new SettingsView();
                _reportsView = new ReportsView();

                // Khởi tạo commands
                NavigateCommand = new RelayCommand<string>(Navigate);
                LoadDataCommand = new RelayCommand<object>(LoadData);
                ExportToWordCommand = new RelayCommand<object>(ExportToWord, CanExportToWord);
                ResetCommand = new RelayCommand<object>(Reset);

                // Khởi tạo giá trị mặc định
                StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                EndDate = DateTime.Now;
                StatusMessage = "Sẵn sàng";
                IsDataLoaded = false;

                // Hiển thị view mặc định
                CurrentView = _dashboardView;
                
                Console.WriteLine($"MainViewModel initialized with CurrentView: {CurrentView?.GetType().Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in MainViewModel constructor: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void Navigate(string pageName)
        {
            Console.WriteLine($"Navigate called with pageName: {pageName}");
            
            try
            {
                switch (pageName)
                {
                    case "Dashboard":
                        CurrentView = _dashboardView;
                        break;
                    case "KhamChuaBenh":
                        CurrentView = _khamChuaBenhView;
                        break;
                    case "KetQuaNoiTru":
                        CurrentView = _ketQuaNoiTruView;
                        break;
                    case "DichVuYeuCau":
                        CurrentView = _dichVuYeuCauView;
                        break;
                    case "KhoaKhamBenh":
                        CurrentView = _khoaKhamBenhView;
                        break;
                    case "PhongKhamNgoaiTru":
                        CurrentView = _phongKhamNgoaiTruView;
                        break;
                    case "PhongKhamCapCuu":
                        CurrentView = _phongKhamCapCuuView;
                        break;
                    case "PhongKhamYeuCau":
                        CurrentView = _phongKhamYeuCauView;
                        break;
                    case "Settings":
                        CurrentView = _settingsView;
                        break;
                    case "Reports":
                        CurrentView = _reportsView;
                        break;
                    default:
                        StatusMessage = $"Không tìm thấy trang: {pageName}";
                        break;
                }
                
                StatusMessage = $"Đã chuyển đến: {pageName}";
                Console.WriteLine($"After Navigate, CurrentView: {CurrentView?.GetType().Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Navigate: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void LoadData(object parameter)
        {
            try
            {
                StatusMessage = "Đang tải dữ liệu...";
                Console.WriteLine("LoadData method called");

                // Tải dữ liệu cho từng view
                (_dashboardView.DataContext as DashboardViewModel)?.LoadData();
                (_khamChuaBenhView.DataContext as KhamChuaBenhViewModel)?.LoadData();
                (_ketQuaNoiTruView.DataContext as KetQuaNoiTruViewModel)?.LoadData();
                (_dichVuYeuCauView.DataContext as DichVuYeuCauViewModel)?.LoadData();
                (_khoaKhamBenhView.DataContext as KhoaKhamBenhViewModel)?.LoadData();
                (_phongKhamNgoaiTruView.DataContext as PhongKhamNgoaiTruViewModel)?.LoadData();
                (_phongKhamCapCuuView.DataContext as PhongKhamCapCuuViewModel)?.LoadData();
                (_phongKhamYeuCauView.DataContext as PhongKhamYeuCauViewModel)?.LoadData();

                // Đảm bảo IsDataLoaded được đặt thành true
                IsDataLoaded = true;
                Console.WriteLine($"IsDataLoaded set to: {IsDataLoaded}");
                
                // Thông báo cho UI cập nhật trạng thái của các command
                CommandManager.InvalidateRequerySuggested();
                
                StatusMessage = $"Đã tải dữ liệu từ {StartDate:dd/MM/yyyy} đến {EndDate:dd/MM/yyyy}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadData: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                StatusMessage = $"Lỗi: {ex.Message}";
                IsDataLoaded = false;
            }
        }

        private void ExportToWord(object parameter)
        {
            try
            {
                StatusMessage = "Đang xuất báo cáo...";
                Console.WriteLine("ExportToWord method called");

                // Lấy các DataGrid từ các view
                DataGrid khamChuaBenhGrid = (_khamChuaBenhView.DataContext as KhamChuaBenhViewModel)?.DataGrid;
                DataGrid ketQuaNoiTruGrid = (_ketQuaNoiTruView.DataContext as KetQuaNoiTruViewModel)?.DataGrid;
                DataGrid dichVuYeuCauGrid = (_dichVuYeuCauView.DataContext as DichVuYeuCauViewModel)?.DataGrid;
                DataGrid khoaKhamBenhGrid = (_khoaKhamBenhView.DataContext as KhoaKhamBenhViewModel)?.DataGrid;
                DataGrid phongKhamNgoaiTruGrid = (_phongKhamNgoaiTruView.DataContext as PhongKhamNgoaiTruViewModel)?.DataGrid;
                DataGrid phongKhamCapCuuGrid = (_phongKhamCapCuuView.DataContext as PhongKhamCapCuuViewModel)?.DataGrid;
                DataGrid phongKhamYeuCauGrid = (_phongKhamYeuCauView.DataContext as PhongKhamYeuCauViewModel)?.DataGrid;

                Console.WriteLine($"DataGrids retrieved: {khamChuaBenhGrid != null}, {ketQuaNoiTruGrid != null}, {dichVuYeuCauGrid != null}, {khoaKhamBenhGrid != null}, {phongKhamNgoaiTruGrid != null}, {phongKhamCapCuuGrid != null}, {phongKhamYeuCauGrid != null}");

                // Xuất báo cáo
                WordExportService.Instance.ExportToWord(
                    khamChuaBenhGrid,
                    ketQuaNoiTruGrid,
                    dichVuYeuCauGrid,
                    khoaKhamBenhGrid,
                    phongKhamNgoaiTruGrid,
                    phongKhamCapCuuGrid,
                    phongKhamYeuCauGrid,
                    StartDate,
                    EndDate
                );

                StatusMessage = "Đã xuất báo cáo thành công";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ExportToWord: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                StatusMessage = $"Lỗi khi xuất báo cáo: {ex.Message}";
            }
        }

        private bool CanExportToWord(object parameter)
        {
            bool result = IsDataLoaded;
            Console.WriteLine($"CanExportToWord called, returning: {result}");
            return result;
        }

        private void Reset(object parameter)
        {
            // Reset các giá trị
            StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            EndDate = DateTime.Now;
            IsDataLoaded = false;
            StatusMessage = "Đã làm mới dữ liệu";

            // Reset dữ liệu trong các view
            (_dashboardView.DataContext as DashboardViewModel)?.Reset();
            (_khamChuaBenhView.DataContext as KhamChuaBenhViewModel)?.Reset();
            (_ketQuaNoiTruView.DataContext as KetQuaNoiTruViewModel)?.Reset();
            (_dichVuYeuCauView.DataContext as DichVuYeuCauViewModel)?.Reset();
            (_khoaKhamBenhView.DataContext as KhoaKhamBenhViewModel)?.Reset();
            (_phongKhamNgoaiTruView.DataContext as PhongKhamNgoaiTruViewModel)?.Reset();
            (_phongKhamCapCuuView.DataContext as PhongKhamCapCuuViewModel)?.Reset();
            (_phongKhamYeuCauView.DataContext as PhongKhamYeuCauViewModel)?.Reset();
        }

        public void ExportToWordDirectly()
        {
            ExportToWord(null);
        }
    }
}
