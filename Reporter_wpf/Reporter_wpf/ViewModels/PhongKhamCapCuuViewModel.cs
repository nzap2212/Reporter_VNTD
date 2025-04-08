using System.Collections.ObjectModel;
using System.Windows.Controls;
using Reporter_wpf.Models;
using Reporter_wpf.Services;

namespace Reporter_wpf.ViewModels
{
    public class PhongKhamCapCuuViewModel : ViewModelBase
    {
        private ObservableCollection<SoLieuPhongKhamCapCuu> _phongKhamCapCuuData;
        private DataGrid _dataGrid;

        public ObservableCollection<SoLieuPhongKhamCapCuu> PhongKhamCapCuuData
        {
            get => _phongKhamCapCuuData;
            set => SetProperty(ref _phongKhamCapCuuData, value);
        }

        public DataGrid DataGrid
        {
            get => _dataGrid;
            set => SetProperty(ref _dataGrid, value);
        }

        public PhongKhamCapCuuViewModel()
        {
            PhongKhamCapCuuData = new ObservableCollection<SoLieuPhongKhamCapCuu>();
        }

        public void LoadData()
        {
            PhongKhamCapCuuData = DataService.Instance.GetPhongKhamCapCuuData();
        }

        public void Reset()
        {
            PhongKhamCapCuuData.Clear();
        }
    }
} 