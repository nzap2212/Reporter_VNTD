using System.Collections.ObjectModel;
using System.Windows.Controls;
using Reporter_wpf.Models;
using Reporter_wpf.Services;

namespace Reporter_wpf.ViewModels
{
    public class PhongKhamNgoaiTruViewModel : ViewModelBase
    {
        private ObservableCollection<SoLieuPhongKhamNgoaiTru> _phongKhamNgoaiTruData;
        private DataGrid _dataGrid;

        public ObservableCollection<SoLieuPhongKhamNgoaiTru> PhongKhamNgoaiTruData
        {
            get => _phongKhamNgoaiTruData;
            set => SetProperty(ref _phongKhamNgoaiTruData, value);
        }

        public DataGrid DataGrid
        {
            get => _dataGrid;
            set => SetProperty(ref _dataGrid, value);
        }

        public PhongKhamNgoaiTruViewModel()
        {
            PhongKhamNgoaiTruData = new ObservableCollection<SoLieuPhongKhamNgoaiTru>();
        }

        public void LoadData()
        {
            PhongKhamNgoaiTruData = DataService.Instance.GetPhongKhamNgoaiTruData();
        }

        public void Reset()
        {
            PhongKhamNgoaiTruData.Clear();
        }
    }
} 